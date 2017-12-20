using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating calculation object
            Calculations calc;
            calc = new Calculations();
            //Askig banana for a first value
            int FirstNumber = calc.AskBananaForNumber();
            //Asking banana for a second value
            int SecondNumber = calc.AskBananaForNumber();
            //sum
            int result = FirstNumber + SecondNumber;
            //Print result on screen
            Console.WriteLine("Result is: ");
            Console.WriteLine(result);
            //Pausing app
            Console.ReadLine();
        }
    }
}
