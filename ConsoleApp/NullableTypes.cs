using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class NullableTypes
    {
        //There are two types in c#
        /// <summary>
        /// 1.Value Types   --  int,double,float,struct,enum are all value types
        /// 2.Reference Types -- class,interface,delegates,array,string are all reference types
        /// Default value of values types is 0 and that of reference types in null
        /// 
        /// </summary>
        static void Nullable()
        {
            string name = null; // since string is a reference type we can assign null to it
            int i = 0; // we cannot assign null to it since its a value type

            //Value types can be two types
            //1. Nullable
            //2. Non Nullable

            int? integer = null; //by using ? after the value type we can make it nullable
        }

        static void NullCoalesceingOperator()
        {
            int? TicketsOnSale = null;
            int AvailableTickets = 0;
            if (TicketsOnSale == null)
                AvailableTickets = 0;
            else
                AvailableTickets = (int)TicketsOnSale;
            Console.WriteLine("AvailableTickets = {0}", AvailableTickets);

            //Using Null Coalescing Operator to do this
            int? Tickets = null;
            int avail = Tickets ?? 0; //?? is the null coalescing operator
            ///<summary>
            /// Here if tickets is null, automatically avail will be assigned 0
            /// else the values of tickets
            ///<summary>
        }
        
    }
}
