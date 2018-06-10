namespace HelloWorld.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            IConversation conversation = null;
            var questionScript = new QuestionScript(conversation);
            questionScript.Go();
        }
    }
}
