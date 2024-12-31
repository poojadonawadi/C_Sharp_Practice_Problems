using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasicProblems
{
    internal class CheckSpecifiedCharacters
    {
        public static void CheckPresenceOfChar(string word)
        {
            if (word.Contains('e') && word.Contains('a') && word.Contains('p'))
            {
                Console.WriteLine("AllPresent");
            }
            else if(word.Contains('e') || word.Contains('a') || word.Contains('p'))
            {
                Console.WriteLine("Only one character is present");
            }
            else
            {
                Console.WriteLine("You enterd string does not contain all a, e, and p");
            }
        }
    }
}
