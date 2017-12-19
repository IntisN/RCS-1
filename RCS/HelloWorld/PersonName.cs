using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class PersonName
    {
        public void sayHello()
        {
            //Asking for some text
            Console.WriteLine("Please enter your name.");
            //Adding variable with my name
            string myName;
            //Adding data to created variable
            myName = Console.ReadLine();
            //Printing Hello World on screen
            Console.WriteLine("Hello World! Es esmu te! " + myName);
        }
}
}
