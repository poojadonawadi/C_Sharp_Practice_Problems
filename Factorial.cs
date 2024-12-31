using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasicProblems
{
    internal class Factorial
    {
        public int GetFactorial(int n)
        {
            int fact = 1;
            for(int i = 1; i<=n; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}
