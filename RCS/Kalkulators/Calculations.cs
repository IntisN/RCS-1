using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulators
{
    class Calculations
    {
        public int AskBananaForNumber()
        {
            //Print text asking for a number
            Console.WriteLine("Enter a number, banana!");
            //Read number from console
            //Define variable for a number
            int number;
            //Entering number in variable
            string inputText = Console.ReadLine();
            //Checking if number is entered
            bool success = Int32.TryParse(inputText, out number);

            if (success == false)
            {
                //Warning banana that wrong value is entered
                Console.WriteLine("Wrong value entered! :p");
                //Returning to function
                number = this.AskBananaForNumber();
            }

            //Return number to function
            return number;
        }
    }
}
