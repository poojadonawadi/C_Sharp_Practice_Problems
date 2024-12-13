using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasicProblems
{
    internal class SumAndDiff
    {
        public int SumSquare(int a, int b)
        {
            return a * a + b * b;
        }

        public int DiffSquare(int a, int b)
        {
            return a * a - b * b; ;
        }
        /*static void Main(string[] args)
        {
            SumAndDiff num = new SumAndDiff();
            Console.WriteLine("Enter the 1st Number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 2nd Number:");
            int b = int.Parse(Console.ReadLine());
            int sum = num.SumSquare(a, b);
            int difference = num.DiffSquare(a, b);
            Console.WriteLine("The sum of square of two numbers is: " + sum);
            Console.WriteLine("The sum of square of two numbers is: " + difference);
        }*/

    }
}
