using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(value: "Please enter your name.");
            //Adding variable with my name
            string myName;
            //Adding data to created variable
            myName = Console.ReadLine();
            //Printing Hello World on screen
            Console.WriteLine(value: "Hello World! Es esmu te! " + myName);
            //Pausing app so we could read this text
            Console.ReadLine();
        }
    }
}
