using System;
using AzurePipelineWeb.Controllers;
using Xunit;

namespace AzurePipeline.Test
{
    public class HomeControllerTest
    {
        [Fact]
        public void ForTest_should_return_string()
        {
            // arrange
            var controller = new HomeController();

            // act
            var str = controller.ForTest();

            // assert
            Assert.Equal("23333", str);
        }
    }
}
