using System;
using System.Collections.Generic;
using SimpleAPI;
using SimpleAPI.Controllers;
using Xunit;

namespace SimpleAPITest.test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();

        [Fact]
        public void Test1()
        {
            IEnumerable<WeatherForecast> returnValue = controller.Get();
            //Assert.True(returnValue != null);

        }
    }
}
