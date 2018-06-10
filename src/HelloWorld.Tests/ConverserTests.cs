using AutoFixture;
using HelloWorld.Console;
using Moq;
using Xunit;

namespace HelloWorld.Tests
{
    public class ConverserTests
    {
        private IFixture _fixture = new Fixture();

        [Fact]
        public void Name_Is_Asked_For()
        {
            var communicator = Mock.Of<ICommunicator>();

            var expectedQuestion = "What is your name?";

            var converser = new Converser(communicator);
            converser.AskName();

            Mock.Get(communicator).Verify(x => x.Say(expectedQuestion), Times.Once);
        }

        [Fact]
        public void Says_Hello_In_Response_To_Name()
        {
            var communicator = Mock.Of<ICommunicator>();
            var timeService = Mock.Of<ITimeService>();

            var expectedName = _fixture.Create<string>();
            var expectedHelloResponse = $"Hello, {expectedName}, on 14/10/2017 at 5:35 PM!";

            var converser = new Converser(communicator);
            converser.SayHello(expectedName);

            Mock.Get(communicator).Verify(x => x.Say(expectedHelloResponse), Times.Once);
        }
    }
}
