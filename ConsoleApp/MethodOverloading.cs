using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class MethodOverloading
    {
        //a function can be overloaded base on the SIGNATURE of a function
        //SIGNATURE - the name,type,kind,and number of parameters of a method form the signature of a method
        //we cannot overload a function based on returntypes
        //we also cannot overload method based on params keyword
        public static void main()
        {
            Add(1, 2);
            Add(1.2F, 1.4F);
            Add(1, 2, 3);
            Add(1, 2, 3, 4);
        }

        public static void Add(int FN,int SN)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
        }

        public static void Add(float FN, float SN)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
        }


        public static void Add(int FN, int SN, int TN)
        {
            Console.WriteLine("Sum = {0}", FN + SN + TN);
        }

        public static void Add(int FN, int SN, int TN,int FRN)
        {
            Console.WriteLine("Sum = {0}", FN + SN + TN + FRN);
        }
    }
}

