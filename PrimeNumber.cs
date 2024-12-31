using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasicProblems
{
    internal class PrimeNumber
    {
        public static int[] PrimeNumberFromArray(int[] array)
        {
            List<int> primeNumbers = new List<int>();
            foreach(int num in array)
            { 
                if(IsPrime(num))
                {
                    primeNumbers.Add(num);
                }
            }
            return primeNumbers.ToArray();
        }
        public static bool IsPrime(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false; 
                }
            }
            return true;
        }

    }
}
