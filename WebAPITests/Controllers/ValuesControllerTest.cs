using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Controllers;
using Xunit;

namespace WebAPITests.Controllers
{     
    public class ValuesControllerTest
    {
        [Fact]
        public void Get()
        {
            //// Arrange
            //ValuesController controller = new ValuesController();

            //// Act
            //IEnumerable<string> result = controller.Get();

            //// Assert
            //Assert.IsNotNull(result);
            //Assert.AreEqual(2, result.Count());
            //Assert.AreEqual("value1", result.ElementAt(0));
            //Assert.AreEqual("value2", result.ElementAt(1));

            // Assert
            Assert.Equal(5, 6);
        }
    }
}
