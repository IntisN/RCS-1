using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmarterCalculator
{
    class MathParser
    {
        //function which receives banana's text; calculates and returns result
        public int ParseMath(string input)
        {
            //int result;
            //Create a variable where saves entered cahracter count starting from 0, increasing each while loop
            string FirstEnteredNumber = "";
            string SecondEnteredNumber = "";
            char EnteredOperation = ' ';
            bool OperationFound = false;
            int counter = 0;

            while (counter < input.Length)
            {
                char symbol = input[counter];
                if (symbol == '+')
                {

                    //Save operation in a variable
                    //Console.WriteLine("Plus");
                    EnteredOperation = symbol;
                    //Bool when completed
                    OperationFound = true;
                }
                else
                {
                    if (OperationFound == false)
                    {
                        //Write a value in first number
                        FirstEnteredNumber = FirstEnteredNumber + symbol;
                    }
                    else
                    {
                        //Write a value in second number
                        SecondEnteredNumber = SecondEnteredNumber + symbol;
                    }


                }

                input = input.Remove(1, input.Length - 1);
                counter = counter + 1;


                if (OperationFound == true && counter == input.Length)
                {
                    int result = Int32.Parse(FirstEnteredNumber) + Int32.Parse(SecondEnteredNumber);
                    return result;
                }
            }
            Console.WriteLine("Bad input");
            return 0;
        }
    }
}
