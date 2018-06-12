using Microsoft.Extensions.DependencyInjection;
using System;

namespace HelloWorld.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddTransient<IConverser, Converser>();
            services.AddTransient<ICommunicator, ConsoleCommunicator>();
            services.AddTransient<ITimeService, TimeService>();
            var provider = services.BuildServiceProvider();

            var converser = provider.GetService<IConverser>();
            
            var questionScript = new QuestionScript(converser);
            questionScript.Go();

        }
    }
}
