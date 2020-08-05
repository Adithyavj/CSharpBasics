using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Operators
    {
        static void Operator()
        {
            //Assignment operator is =
            //Arithmetic operator +,-,*,/,%
            //Comparison operator ==,!=,>=,<=
            //Conditional operator ||,&&
            //Ternary operator :?
            int number = 10;
            bool isNumber10=false;
            if (number == 10)
                isNumber10 = true;
            else
                isNumber10 = false;
            Console.WriteLine("Number=10, {0}", isNumber10);

            //Using Ternary Operator to do the same operation
            isNumber10 = number == 10 ? true : false;
        }
    }
}
