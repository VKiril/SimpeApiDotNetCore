using System;
using Xunit;
using SimpleApi.Controllers;

namespace SimpleApi.TEST
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();
        [Fact]
        public void GetReturnsMyName()
        {
            var returnValue = controller.Get(1);
            Assert.Equal("Test User", returnValue.Value);
        }


        [Fact]
        public void Test1()
        {

        }
    }
}
