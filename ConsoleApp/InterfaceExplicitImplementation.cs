using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class InterfaceExplicitImplementation : I1, I2
    {
        //Are we implementing I1 or I2 ???
        //public void InterfaceMethod()
        //{
        //    Console.WriteLine("I1 Interface Method");
        //}
        //we have to use explicit implemetation of the interface
        void I1.InterfaceMethod()
        {
            Console.WriteLine("I1 Method");
        }

        void I2.InterfaceMethod()
        {
            Console.WriteLine("I2 Method");
        }

        //Default method to implement, we implement this interface method normally
        public void InterfaceMethod()
        {
            Console.WriteLine("Default Method");
        }

        static void main()
        {
            InterfaceExplicitImplementation i = new InterfaceExplicitImplementation();
            ((I1)i).InterfaceMethod(); //we typecast interface1 the object
            ((I2)i).InterfaceMethod(); //in case of explicit implemetation we have to typcast the object with the interface
             // here i acts as an interface reference variable
            i.InterfaceMethod(); //Default interface Method



            //some points to note
            //1. when a class explicity implements an interface
            //   it cannot be accessed using a class reference variable
            //   it can only be accessed using an interface reference variable
            //2. Access modifiers are not allowed on explicitly implemented interface members
            //3. If we want to make one interface method default,
            //   implement that interface method normally and the other interface method explicitly

            //Another way to implement the methods is using base class reference variable
            I1 i1 = new InterfaceExplicitImplementation();
            I2 i2 = new InterfaceExplicitImplementation();
            i1.InterfaceMethod();
            i2.InterfaceMethod();

        }
    }

    interface I1
    {
        void InterfaceMethod();
    }

    interface I2
    {
        //same method as I1
        void InterfaceMethod();
    }

    interface Idefault
    {
        void InterfaceMethod();
    }
}
