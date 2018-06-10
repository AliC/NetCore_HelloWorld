using AutoFixture;
using HelloWorld.Console;
using Moq;
using Xunit;

namespace HelloWorld.Tests
{
    public class QuestionScriptTests
    {
        IFixture _fixture = new Fixture();

        [Fact]
        public void Conversation_Follows_Correct_Sequence()
        {
            string expectedName = _fixture.Create<string>();

            var converser = new Mock<IConverser>(MockBehavior.Strict);

            var sequence = new MockSequence();
            converser.InSequence(sequence).Setup(c => c.AskName()).Returns(expectedName);
            converser.InSequence(sequence).Setup(c => c.LineFeed());
            converser.InSequence(sequence).Setup(c => c.SayHello(expectedName));
            converser.InSequence(sequence).Setup(c => c.LineFeed());

            var script = new QuestionScript(converser.Object);
            script.Go();

            converser.Verify(c => c.AskName(), Times.Once);
            converser.Verify(c => c.SayHello(expectedName), Times.Once);
            converser.Verify(c => c.LineFeed(), Times.Exactly(2));
        }
    }
}
