using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ratioCalculator
{
    class Program
    {
        private static int Gcd(int a, int b)
        {
            // if the value of a is 0 then return the value of b (otherwise the program will crash)
            if (a == 0)
                return b;
            //else carry out the calculation below
            else
                return Gcd(b % a, a);
        }
        static void Main(string[] args)
        {
            //A Numerator is the top number in a fraction, it shows how many parts we have.
            //The bottom number is the Denominator and shows how many equal parts the item is divided into.
            int numerator = 100;
            int denominator = 25;

            //call the function above
            int gcd = Gcd(100, 25);
            Console.WriteLine(numerator + ":" + denominator + " = " + numerator / gcd + ":" + denominator / gcd);
            Console.ReadKey();
        }
    }
}
