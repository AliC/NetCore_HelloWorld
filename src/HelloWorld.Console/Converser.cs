using System;

namespace HelloWorld.Console
{
    public class Converser : IConverser
    {
        private ICommunicator _communicator;

        public Converser(ICommunicator communicator)
        {
            _communicator = communicator;
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

            var now = DateTime.Now;
            //string date = now.Date;
            //string time = now.TimeOfDay;
            //Console.WriteLine($"Hello, {name}, on {date} at {time}");
        }
    }
}