using System;

namespace HelloWorld.Console
{
    public class Converser : IConverser
    {
        private readonly ICommunicator _communicator;
        private readonly ITimeService _timeService;

        public Converser(ICommunicator communicator, ITimeService timeService)
        {
            _communicator = communicator;
            _timeService = timeService;
        }

        public string AskName()
        {
            return _communicator.Say("What is your name?");
        }

        public void LineFeed()
        {
            _communicator.LineFeed();
        }

        public void SayHello(string name)
        {
            _communicator.Say($"Hello, {name}, on {_timeService.Date} at {_timeService.Time}!");
        }
    }
}