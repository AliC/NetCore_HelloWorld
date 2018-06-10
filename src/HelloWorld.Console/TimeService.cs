using System;

namespace HelloWorld.Console
{
    public class TimeService : ITimeService
    {
        private DateTime? _now;

        public TimeService(DateTime now)
        {
            _now = now;
        }

        public DateTime Now
        {
            get
            {
                return _now ?? DateTime.Now;
            }
            private set
            {
                _now = value;
            }
        }

        public string Date()
        {
            return Now.Date.ToShortDateString();
        }

        public string Time()
        {
            return Now.ToString("h:m tt");
        }
    }
}