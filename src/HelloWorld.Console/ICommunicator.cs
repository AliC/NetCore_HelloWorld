namespace HelloWorld.Console
{
    public interface ICommunicator
    {
        string Ask(string question);
        void LineFeed();
    }
}