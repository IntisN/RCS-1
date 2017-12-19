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
            //Calling class PersonName
            PersonName greet;
            greet = new PersonName();
            greet.sayHello();
            //Pausing app so we could read this text
            Console.ReadLine();
        }
    }
}
