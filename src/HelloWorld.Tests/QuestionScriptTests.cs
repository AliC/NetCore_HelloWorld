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

            var conversationService = new Mock<IConversation>(MockBehavior.Strict);

            var sequence = new MockSequence();
            conversationService.InSequence(sequence).Setup(c => c.AskName()).Returns(expectedName);
            conversationService.InSequence(sequence).Setup(c => c.LineFeed());
            conversationService.InSequence(sequence).Setup(c => c.SayHello(expectedName));
            conversationService.InSequence(sequence).Setup(c => c.LineFeed());

            var script = new QuestionScript(conversationService.Object);
            script.Go();

            conversationService.Verify(c => c.AskName(), Times.Once);
            conversationService.Verify(c => c.SayHello(expectedName), Times.Once);
            conversationService.Verify(c => c.LineFeed(), Times.Exactly(2));
        }
    }
}
