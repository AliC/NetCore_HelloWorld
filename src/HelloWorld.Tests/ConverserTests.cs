using AutoFixture;
using HelloWorld.Console;
using Moq;
using Xunit;

namespace HelloWorld.Tests
{
    public class ConverserTests
    {
        private IFixture _fixture = new Fixture();
        private Mock<ICommunicator> _communicator = null;
        private Mock<ITimeService> _timeService = null;
        private Converser _converser = null;

        public ConverserTests()
        {
            _communicator = new Mock<ICommunicator>();
            _timeService = new Mock<ITimeService>();
            _converser = new Converser(_communicator.Object, _timeService.Object);
        }

        [Fact]
        public void Name_Is_Asked_For()
        {
            var expectedQuestion = "What is your name?";

            _converser.AskName();

            _communicator.Verify(x => x.Say(expectedQuestion), Times.Once);
        }

        [Fact]
        public void Says_Hello_In_Response_To_Name()
        {
            _timeService.Setup(t => t.Date).Returns("14/10/2017");
            _timeService.Setup(t => t.Time).Returns("5:35 PM");
            var expectedName = _fixture.Create<string>();
            var expectedHelloResponse = $"Hello, {expectedName}, on 14/10/2017 at 5:35 PM!";

            _converser.SayHello(expectedName);

            _communicator.Verify(x => x.Say(expectedHelloResponse), Times.Once);
        }
    }
}
