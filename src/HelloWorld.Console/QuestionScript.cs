namespace HelloWorld.Console
{
    public class QuestionScript
    {
        private IConversation _conversation;

            public QuestionScript(IConversation conversation)
            {
                _conversation = conversation;
            }

        public void Go()
        {
            var name = _conversation.AskName();
            _conversation.LineFeed();
            _conversation.SayHello(name);
            _conversation.LineFeed();
        }
    }
}
