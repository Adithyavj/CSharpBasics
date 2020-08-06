using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    interface InterfaceA
    {
        void AMethod();
    }

    class impA : InterfaceA
    {
        public void AMethod()
        {
            Console.WriteLine("A");
        }
    }

    interface InterfaceB
    {
        void BMethod();
    }

    class impB : InterfaceB
    {
        public void BMethod()
        {
            Console.WriteLine("B");
        }
    }

    class impAB : InterfaceA, InterfaceB //multiple inheritance using interfaces
    {
        //we can create an instance of the classes a and b which have already implemented the interfaces
        impA A = new impA();
        impB B = new impB();
        public void AMethod()
        {
            A.AMethod(); //we dont need to implement the interface, we can call the method using object
        }

        public void BMethod()
        {
            B.BMethod();
        }
    }

    class mutlipleinheritanceusinginterface
    {
        static void main()
        {
            impAB AB = new impAB();
            AB.AMethod();
            AB.BMethod();
        }
    }
}
