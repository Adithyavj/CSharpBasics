using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class BuildInTypes
    {
        static void IntegralDataType()
        {
            //Following are the integral data types in c# in their bit order
            byte b=0;
            sbyte sb = 0;
            char c = '0';
            short s = 0;
            ushort us = 0;
            int i = 0;
            uint ui = 0;
            long l = 0;
            ulong ul = 0;
            //To get the size of a datatype we can use this property
            Console.WriteLine("Min = {0}", int.MinValue);
            Console.WriteLine("Max = {0}", int.MaxValue);
        }

        static void FloatingPointDataType()
        { 
            float f = 0; //32 Bits
            double d = 0.0; //64 Bits
        }

        static void DecimalDataType()
        {
            decimal dec = 0;
        }

        static void StringDataType()
        {
            string Name = "";
            Name = "Adithya Vijay";
            //Escape Character in c#
            Name = "\"Adithya Vijay K\""; //Here the Back Slash treats the character following it as an escape character

            //Verbatim Literal in c#
            //using @ before a string is called Verbatim literal
            Name = @"\Adithya Vijay K\"; //It escapes backslash
        }
    }
}
