namespace HelloWorld.Console
{
    public class ConsoleCommunicator : ICommunicator
    {
        public string Say(string question)
        {
            System.Console.WriteLine(question);
            return System.Console.ReadLine();
        }

        public void LineFeed()
        {
            System.Console.WriteLine();
        }
    }
}