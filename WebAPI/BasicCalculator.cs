using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI
{
    public class BasicCalculator
    {

        public int Sum(int a, int b)
        {
            int total = a + b;
            return total;
        }

        public int Subtraction(int a, int b)
        {
            int Difference = a - b;
            return Difference;
        }

    }
}
