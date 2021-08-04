using System;
using Xunit;
using AzureApi.Controllers;

namespace AzureApi.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();

        [Fact]
        public void getForecast(){
            var forecast = controller.Get(3);
            Assert.Equal("Cool", forecast);
        }
        [Fact]
        public void Test1()
        {
        
        }
    }
}
