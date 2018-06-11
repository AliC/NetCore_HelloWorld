using AutoFixture;
using HelloWorld.Console;
using System;
using System.Text.RegularExpressions;
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

            var actualDate = timeService.Date;

            Assert.Equal(expectedDate, actualDate);
        }

        [Fact]
        public void Returns_Correctly_Formatted_Time_When_Minutes_Under_Ten()
        {
            var now = new DateTime(2017, 10, 14, 17, 3, 0);
            var timeService = new TimeService(now);
            var expectedTime = "5:03 PM";

            var actualTime = timeService.Time;

            Assert.Equal(expectedTime, actualTime);
        }

        [Fact]
        public void Returns_Correctly_Formatted_Time_When_Minutes_Over_Nine()
        {
            var now = new DateTime(2017, 10, 14, 17, 35, 0);
            var timeService = new TimeService(now);
            var expectedTime = "5:35 PM";

            var actualTime = timeService.Time;

            Assert.Equal(expectedTime, actualTime);
        }

        [Fact]
        public void Returns_Correctly_Formatted_Time_When_Hours_Under_Ten()
        {
            var now = new DateTime(2017, 10, 14, 5, 35, 0);
            var timeService = new TimeService(now);
            var expectedTime = "5:35 AM";

            var actualTime = timeService.Time;

            Assert.Equal(expectedTime, actualTime);
        }

        [Fact]
        public void Returns_Correctly_Formatted_Time_When_Hours_Over_Nine()
        {
            var now = new DateTime(2017, 10, 14, 11, 35, 0);
            var timeService = new TimeService(now);
            var expectedTime = "11:35 AM";

            var actualTime = timeService.Time;

            Assert.Equal(expectedTime, actualTime);
        }

        [Fact]
        public void Returns_Correctly_Formatted_Date_When_Date_Not_Known()
        {
            var now = new DateTime(2017, 10, 14, 17, 35, 0);
            var timeService = new TimeService();
            var expectedDateFormat = "^([1-31]|[1-2][0-9]|[3][0-1])\\([1-9]|[1][0-2]\\/d{4})$";

            var actualDate = timeService.Date;

            Assert.Matches(expectedDateFormat, actualDate);
        }

        [Fact]
        public void Returns_Correctly_Formatted_Time_When_Time_Not_Known()
        {
            var timeService = new TimeService(null);
            var expectedTimeFormat = "^([0-9]|[1-9][0-2]):([0-5][0-9]) [AP]M$";

            var actualTime = timeService.Time;

            Assert.Matches(expectedTimeFormat, actualTime);
        }
    }
}
