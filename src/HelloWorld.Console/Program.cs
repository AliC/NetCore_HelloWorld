namespace HelloWorld.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            IConverser conversation = null;
            var questionScript = new QuestionScript(conversation);
            questionScript.Go();
        }
    }
}
