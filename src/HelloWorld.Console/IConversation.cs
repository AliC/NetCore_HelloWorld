namespace HelloWorld.Console
{
    public interface IConversation
    {
        string AskName();
        void SayHello(string answer);
        void LineFeed();
    }
}