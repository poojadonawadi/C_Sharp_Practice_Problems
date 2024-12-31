using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasicProblems
{
    internal class ConvertNumToString
    {
        public static void ConvertToString(int a)
        {
            if (a % 3 == 0)
            {
                Console.WriteLine("Pling");
            }
            else if (a % 5 == 0)
            {
                Console.WriteLine("Plong");
            }
            else if (a % 7 == 0)
            {
                Console.WriteLine("Plung");
            }
            else if(a%3==0 && a%5 == 0)
            {
                Console.WriteLine("PlingPlong");
            }
            else if(a%3==0&& a % 7 == 0)
            {
                Console.WriteLine("PlingPlung");
            }
            else if(a%3!=0 && a%5!=0 && a % 7 != 0)
            {
                Console.WriteLine($"{a}");
            }
        }
    }
}
