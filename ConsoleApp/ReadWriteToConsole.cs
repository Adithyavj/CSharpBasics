using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class ReadWriteToConsole
    {
        static void ReadandWrite()
        {
            Console.WriteLine("Enter your First Name");
            string FirstName = "", LastName = "";
            FirstName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name");
            LastName = Console.ReadLine();
            //Using Placeholder
            Console.WriteLine("Name is {0},{1}", FirstName, LastName);

            //using appending string
            Console.WriteLine("Name :" + FirstName + " " + LastName);
        }
    }
}
