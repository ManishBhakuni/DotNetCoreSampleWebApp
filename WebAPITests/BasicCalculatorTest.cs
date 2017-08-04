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
        public void SumTest(int a, int b)
        {
            Assert.Equal(6, objBasicCalculator.Sum(2, 4));           
        }


    }
}
