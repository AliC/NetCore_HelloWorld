using Microsoft.Extensions.DependencyInjection;
using System;

namespace HelloWorld.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ServiceProvider provider = DependencyInjection(args);

            var questionScript = new QuestionScript(provider.GetService<IConverser>());
            questionScript.Go();

        }

        private static ServiceProvider DependencyInjection(string[] args)
        {
            var now = args.Length == 1 ? DateTime.Parse(args[0]) : (DateTime?)null;

            var services = new ServiceCollection();
            services.AddTransient<IConverser, Converser>();
            services.AddTransient<ICommunicator, ConsoleCommunicator>();
            services.AddTransient<ITimeService, TimeService>(t => new TimeService(now));

            return services.BuildServiceProvider();
        }
    }
}
