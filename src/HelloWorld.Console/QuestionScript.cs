namespace HelloWorld.Console
{
    public class QuestionScript
    {
        private IConverser _converser;

        public QuestionScript(IConverser converser)
        {
            _converser = converser;
        }

        public void Go()
        {
            var name = _converser.AskName();
            _converser.LineFeed();
            _converser.SayHello(name);
            _converser.LineFeed();
        }
    }
}
