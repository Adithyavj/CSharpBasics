using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{

    //Inheritance allows code reuse and saves time and reduces the amount of error since less code is written
    //
    class Inheritance
    {
        static void main()
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.Firstname = "Adithya";
            FTE.Lastname = "Vijay";
            FTE.YearlySalary = 10000;
            FTE.PrintFullName();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.Firstname = "Part";
            PTE.Lastname = "TIme";
            PTE.HourlyRate = 70;
            PTE.PrintFullName();

            //MultiLevel Inheritance
            A a1 = new A();

        }
    }

    //base class
    class Employee
    {
        public string Firstname = "";
        public string Lastname = "";
        public string Email = "";

        public void PrintFullName()
        {
            Console.WriteLine("Full Name is {0}", Firstname + " " + Lastname);
        }
    }

    //inherits base class Employee (Derived Class)
    class FullTimeEmployee : Employee
    {
        public float YearlySalary = 0F;
    }

    class PartTimeEmployee : Employee
    {
        public float HourlyRate = 0F;
    }

    //MultiLevel Inheritance is possbile in c# however multiple inheritance is not possible
    //This class A can have the properties,methods and fields of both PartTimeEmployee and Employee
    class A : PartTimeEmployee
    {

    }
}
