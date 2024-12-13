using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasicProblems
{
    internal class AreaOfCircle
    {
        public double FindArea(double diameter)
        {
            double radius = diameter / 2;
            double area = 3.142 * radius * radius;
            return area;
        }
       /* static void Main(string[] args)
        {
            AreaOfCircle a = new AreaOfCircle();
            Console.WriteLine("Enter the diameter of circle");
            double diameter = double.Parse(Console.ReadLine());
            Console.WriteLine("The area of a circle is: "+a.FindArea(diameter));
        }*/
    }
}
