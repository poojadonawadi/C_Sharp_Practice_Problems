using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasicProblems
{
    internal class RootsOfQuadraticEquation
    {
        //double a;
        //double b;
        //double c;
        //double discriminant;
        
        public static double GetDiscriminant(double a, double b, double c)
        {
            double discriminant = b * b - 4 * c;
            return discriminant;
        }

        public static void GetRoots(double a, double b, double c)
        {
            
            double discriminant = GetDiscriminant(a, b, c);
            
            if(discriminant > 0)
            {
                double root1 = (-b + Math.Sqrt(discriminant) / 2 * a);
                double root2 = (-b + Math.Sqrt(discriminant) / 2 * a);
                Console.WriteLine($"The roots are {root1} and {root2}");
            }
            else if(discriminant == 0)
            {
                double root = (-b / 2 * a);
                Console.WriteLine($"The roots of quadrstic equation are {root}");
            }
            else
            {
                Console.WriteLine("No real roots are formed");
            }
        }
    }
}
