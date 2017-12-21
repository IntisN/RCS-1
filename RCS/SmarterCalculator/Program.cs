using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmarterCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating calculator object
            MathParser parser;
            parser = new MathParser();

            //Asking banana to enter calculation
            Console.WriteLine("Please enter calculation");
            string input = Console.ReadLine();

            //calculating things
            int result = parser.ParseMath(input);

            //Printing result on screen
            Console.WriteLine("Your result is " + result);

            //Pausing an app so people can read things
            Console.ReadLine();
        }
    }
}
