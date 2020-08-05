using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    //There are 4 types of method parameters in c#
    //1.Value Parameters
    //2.Reference Parameters
    //3.OutPut Parameters
    //4.Parameter Arrays
    class MethodParameters
    {
        public static void main()
        {
            int i = 0;
            PassbyValue(i);
            Console.WriteLine(i);
            //This is pass by value
            //here i and j point to different memory locations 
            //so value of i will still be 0
            PassbyReference(ref i);
            Console.WriteLine(i);
            //This is pass by reference
            //here both i and j point to same memory location
            //so value of i will change and become 101
            int total=0;
            int product=0;
            OutputParameters(10, 20, out total, out product);


            int[] Numbers = new int[3] { 202, 203, 204 };

            //In case of parameter arrays we can pass values to it in the following three ways
            // it is used when a method takes variable number of arguments
            // params keyword should be the last argument for the function
            // only a single params argument can be present in a function 
            ParamsArray();
            ParamsArray(Numbers);
            ParamsArray(1, 2, 3, 4, 5, 6, 7, 8);

        }

        public static void PassbyValue(int j)
        {
            j = 101;
        }

        public static void PassbyReference(ref int j)
        {
            j = 101;
        }

        /// <summary>
        /// output parameters : a function can only return a single value so if we want to return multiple values we can use output parameters
        /// it is used with an out keyword before the parameter
        /// </summary>
        /// <param name="FN"></param>
        /// <param name="SN"></param>
        /// <param name="Sum"></param>
        /// <param name="Product"></param>
        public static void OutputParameters(int FN,int SN, out int Sum,out int Product)
        {
            Sum = FN + SN;
            Product = FN * SN;
        }

        public static void ParamsArray(params int [] Numbers)
        {
            Console.Write("There are {0} elements in the array", Numbers.Length);
            foreach (int i in Numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
