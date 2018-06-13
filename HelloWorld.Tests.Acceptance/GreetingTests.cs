using HelloWorld.Console;
using System;
using System.IO;
using Xunit;

namespace HelloWorld.Tests.Acceptance
{
    public class GreetingTests
    {
        [Fact]
        public void When_Name_Is_Entered_Then_Greeting_Occurs()
        {
            string expectedQuestion = "What is your name?";
            string expectedName = "Alastair";
            string expectedGreeting = $"Hello, {expectedName}, on 14/10/2017 at 5:35 PM!";

            using (var writer = new StringWriter())
            {
                System.Console.SetOut(writer);

                using (var reader = new StringReader(expectedName))
                {
                    System.Console.SetIn(reader);

                    Program.Main(new string[] { "2017-10-14T17:35" });
                }

                Assert.StartsWith(expectedQuestion, writer.ToString());
                Assert.Contains(expectedGreeting, writer.ToString());
            }
        }
    }
}
