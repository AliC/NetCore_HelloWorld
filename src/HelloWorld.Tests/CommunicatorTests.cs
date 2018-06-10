using HelloWorld.Console;
using Moq;
using Xunit;

namespace HelloWorld.Tests
{
    public class CommunicatorTests
    {
        [Fact]
        public void Name_Is_Asked_For()
        {
            var communicator = Mock.Of<ICommunicator>();

            var expectedQuestion = "What is your name?";

            var talker = new Conversation(communicator);
            talker.AskName();

            Mock.Get(communicator).Verify(x => x.Ask(expectedQuestion), Times.Once);
        }
    }
}
