using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasicProblems
{
    internal class Numbers
    {
        //divisible by 7 but are not multiple of 5 in the range of 2000 to 3200
        public List<int> DivisibleBy7(int start, int end)
        {
            List<int> result = new List<int>();
            for(int i=start; i<=end; i++)
            {
                if(i%7 == 0 && i % 5 != 0)
                {
                    result.Add(i);
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Numbers n = new Numbers();
            List<int> number = n.DivisibleBy7(2000, 3200);
            foreach(int i in number)
            {
                Console.WriteLine(i);
            }
        }
        
    }
}
