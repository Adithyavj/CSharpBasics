using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    // similar to classes interfaces can also contain 
    // 1. Properies
    // 2. Methods
    // 3. Delegates
    // 4. Events
    // But Interface can only DECLARE them NO IMPLEMETATION
    class Interfacesincsharp
    {
        static void main()
        {
            CustomerNew c1 = new CustomerNew();
            c1.Print1();
            c1.Print2();
            c1.Print3();
            c1.Print4();
        }
    }

    //naming convention of interfaces is Begining with capital I
    interface ICustomer1
    {
        //we declare a method
        //Interface members are public by default, they cannot have an explicit access modifier
        //interfaces cannot have fields
        void Print1();
    }

    interface ICustomer2
    {
        void Print2();
    }

    // one interface can inherit from another one
    interface ICustomer3
    {
        void Print3();
    }

    interface ICustomer4 : ICustomer3
    {
        void Print4();
    }


    //A class can inherit multiple Interfaces
    // ie, multiple inheritance is possible in the case of interfaces
    // multiple class inheritance is not possible
    class CustomerNew : ICustomer1, ICustomer2 ,ICustomer4
    {
        //when a class inherits an interface, it has to provide the implementaion for all the methods
        //that were defined in the interface

        //here we implement the Print Method in the interface
        public void Print1()
        {
            Console.WriteLine("ICustomer1 Print Method");
        }

        public void Print2()
        {
            Console.WriteLine("ICustomer2 Print Method");
        }
        //Since CustomerNew class inherits Icustomer4,
        // it has to implement the methods in Icustomer4 as well as the
        // Interface which it inherits, ie Icustomer3

        public void Print3()
        {
            Console.WriteLine("ICustomer3 Print Method");
        }

        public void Print4()
        {
            Console.WriteLine("ICustomer4 Print Method");
        }


        //IMPORTANT :
        //We cannot Create an instance of an interface
        //but an interface reference variable can point to a derived class object

        //ICustomer1 cust = new ICustomer1();
        //cust.Print1();
        //Intefaces are incomplete
        //the above is not possible as Icustomer1 does not implement the Print1() method
        // do there is nothing to call
        //thus interface cannot have objects

        //However we can do this
        ICustomer1 cust = new CustomerNew(); //we can create an object refer
        //parent class reference variable can point to a child class
        //here, Icustomer1 is parent
        //      CustomerNew is child
    }
}
