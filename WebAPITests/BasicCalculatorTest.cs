using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using WebAPI;

namespace WebAPITests
{
    public class BasicCalculatorTest
    {
        BasicCalculator objBasicCalculator = new BasicCalculator();

        [Fact]
        public void SumTest()
        {
            Assert.Equal(12, objBasicCalculator.Sum(2, 10));
            Assert.Equal(20, objBasicCalculator.Sum(10, 10));
        }

        [Fact]
        public void SubtractionTest()
        {
            Assert.Equal(10, objBasicCalculator.Subtraction(16, 6));
        }

    }
}
