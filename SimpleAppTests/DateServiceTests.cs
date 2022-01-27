using SimpleApp.Services;
using System;
using System.Globalization;
using System.Threading;
using Xunit;

namespace SimpleAppTests
{
    public class DateServiceTests
    {
        [Fact]
        public void FormatDate_ShouldReturn_ShortDateString()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("pt-BR");

            var service = new DateService();
            var date = new DateTime(2022, 01, 01);

            var formatedDate = service.FormatDate(date);

            Assert.Equal("01/01/2022", formatedDate);
        }
    }
}