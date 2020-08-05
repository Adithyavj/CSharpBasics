using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class MethodHiding_Inheritance_
    {
        static void main()
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.Firstname = "Full";
            FTE.Lastname = "Time";
            FTE.PrintFullName();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.Firstname = "Part";
            PTE.Lastname = "TIme";
            PTE.PrintFullName();
            //we can typecast PTE to call the hidden base class method
            ((Employee)PTE).PrintFullName();


            //or we can do this
            //parent class reference objects can point to child class
            Employee PTE1 = new PartTimeEmployee();
            PTE1.Firstname = "Part";
            PTE1.Lastname = "TIme";
            PTE1.PrintFullName();

        }
    }


    //base class
    class EmployeeA
    {
        public string Fname = "";
        public string Lname = "";

        public void PrintFullName()
        {
            Console.WriteLine("Full Name is {0}", Fname + " " + Lname);
        }
    }

    //inherits base class Employee (Derived Class)
    class FullTimeEmployeeA : EmployeeA
    {
        
    }

    class PartTimeEmployeeA : EmployeeA
    {
        //If it is a parttime employee there should be a - after this name
        //There is also a method of the same name in the parent class
        //if we create an object for parttimeEmployeeA and call the PrintFullName() method
        //this method will be called... The one in base class will be hidden
        //this is called method hiding
        //To hide the base class member we use the new keyword

        //public new void PrintFullName()
        //{
        //    Console.WriteLine("Full Name is {0}", Fname + " " + Lname+" - Contractor");
        //}

        //However if we want to call the base class method PrintFullName,
        //we use the following

        public new void PrintFullName()
        {
            //base keyword can be use to call the hidden member
            base.PrintFullName();
            //Console.WriteLine("Full Name is {0}", Fname + " " + Lname + " - Contractor");
        }
    }
}
