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
            //Calling class PersonName for greet Hello
            PersonName greet;
            greet = new PersonName();
            greet.HelloText = "Hello, World! ";
            greet.sayHello();

            //Calling class PersonName for greet Ahoy
            PersonName seagreet;
            seagreet = new PersonName();
            seagreet.HelloText = "Ahoy, World! ";
            seagreet.sayHello();

            //Pausing app so we could read this text
            Console.ReadLine();
        }
    }
}
