using System;
using System.Collections.Generic;
using System.Text;

namespace Factorial
{
    class Factorial
    {
        public int FactorialResult(int n)
        {
            int result = 1;
            for (int i = n; i > 1; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}
