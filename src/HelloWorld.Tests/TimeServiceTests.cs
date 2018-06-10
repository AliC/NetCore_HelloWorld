using AutoFixture;
using HelloWorld.Console;
using Moq;
using System;
using Xunit;

namespace HelloWorld.Tests
{
    public class TimeServiceTests
    {
        private IFixture _fixture = new Fixture();

        [Fact]
        public void Returns_Correctly_Formatted_Date()
        {
            var now = new DateTime(2017, 10, 14, 17, 35, 0);
            var timeService = new TimeService(now);
            var expectedDate = "14/10/2017";

            var actualDate = timeService.Date();

            Assert.Equal(expectedDate, actualDate);
        }

        [Fact]
        public void Returns_Correctly_Formatted_Time()
        {
            var now = new DateTime(2017, 10, 14, 17, 35, 0);
            var timeService = new TimeService(now);
            var expectedTime = "5:35 PM";

            var actualTime = timeService.Time();

            Assert.Equal(expectedTime, actualTime);
        }
    }
}
