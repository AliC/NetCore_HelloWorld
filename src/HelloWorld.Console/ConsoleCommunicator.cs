namespace HelloWorld.Console
{
    public class ConsoleCommunicator : ICommunicator
    {
        public string Say(string question)
        {
            throw new System.NotImplementedException();

            //System.Console.WriteLine(question);
            //return System.Console.ReadLine();
        }

        public void LineFeed()
        {
            throw new System.NotImplementedException();

            //System.Console.WriteLine();
        }
    }
}