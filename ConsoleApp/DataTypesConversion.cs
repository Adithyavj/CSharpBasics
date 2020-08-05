using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class DataTypesConversion
    {
        //Implicit and Explicit Conversions

        //Implicit Conversion
        static void ImplicitConversion()
        {
            int i = 100;
            float f = i; // ImplicitConversion, this is automatically done by the complier
        }

        //Explicit Conversion
        static void ExplicitConversion()
        {
            float f = 123.45F;
            int i = Convert.ToInt32(f); // using convert class in .net operator
            int j = (int)f; // Type Casting float to int
        }

        static void ParseMethod()
        {
            string number = "100";
            int Result = 0;
            Result = int.Parse(number);
            Console.WriteLine(Result);
        }

        static void TryParseMethod()
        {
            string number = "100"; //if number has some characters then the tryparseMethod will return false
            int Result = 0;
            bool isResultSuccessful = int.TryParse(number, out Result);
            if (isResultSuccessful)
                Console.WriteLine(Result);
            else
                Console.WriteLine("Enter a Valid Number");
        }


    }
}
