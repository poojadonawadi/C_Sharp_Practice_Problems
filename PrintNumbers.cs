using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasicProblems
{
    internal class PrintNumbers
    {
        private int n { get; }
        public static void Print1to100(int n)
        {

            if (n > 100)
            {
                Console.WriteLine(n);
                PrintNumbers.Print1to100(n + 1);
                return;
            }
        }
    }
}
