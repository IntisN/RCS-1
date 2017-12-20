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
            //Asking banana to enter calculation
            Console.WriteLine("Please enter calculation");
            string input = Console.ReadLine();
            //
            int result;
            int counter = 0;
            while (counter < input.Length)
            {
                char symbol = input[counter];
                if (symbol == '+')
                {

                }
                else
                {
                    int number;
                    number = Int32.Parse(symbol.ToString());
                    Console.WriteLine("Number" + number);
                }

                input = input.Remove(1, input.Length - 1);
                counter = counter + 1;
            }

            Console.ReadLine();
        }
    }
}
