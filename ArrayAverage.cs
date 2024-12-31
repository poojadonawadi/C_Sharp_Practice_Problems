using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasicProblems
{
    internal class ArrayAverage
    {
        public static double FindAverage(double[] array)
        {
            double sum = 0;
            double avg = 0;
            for(int i=0;i<array.Length; i++)
            {
                sum = sum + array[i];
                avg = sum / array.Length;
            }
            return avg;
        }
    }
}
