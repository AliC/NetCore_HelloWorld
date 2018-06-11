using System;

namespace HelloWorld.Console
{
    public class Conversation : IConversation
    {
        private ICommunicator _communicator;

        public Conversation(ICommunicator communicator)
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

        public void SayHello(string answer)
        {

            var now = DateTime.Now;
            //string date = now.Date;
            //string time = now.TimeOfDay;
            //Console.WriteLine($"Hello, {name}, on {date} at {time}");
        }
    }
}