using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{

    //Polymorphism enable us to invoke derived class methods using a base class
    //reference variable at runtime
    //--in the base class the method is declared virtual and in the derived class we override the same method
    //the virtual keyword indicates that it can be overriden in any derived class 
    class Polymorphism 
    {
        //also called method Overriding (it is an example of run time polymorphism
        static void main()
        {
            //base class reference varable is used
            Employee1[] employee = new Employee1[4];
            employee[0] = new Employee1();
            employee[1] = new FullTimeEmployee1();
            employee[2] = new PartTimeEmployee1();
            employee[3] = new TemporaryEmployee1();

            foreach (Employee1 e in employee)
            {
                e.PrintFullName1();
            }
        }
    }

    public class Employee1
    {
        public string FirstName = "FName";
        public string LastName = "LName";

        //For the derived class to override this method we use the virtual keyword
        //Virtual keyword in the parent class method denotes to the derived class that they can override this if necessary
        public virtual void PrintFullName1()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    public class FullTimeEmployee1 : Employee1
    {
        public override void PrintFullName1()
        {
            Console.WriteLine(FirstName + " " + LastName + " - Full Time");
        }
    }

    public class PartTimeEmployee1 : Employee1
    {
        public override void PrintFullName1()
        {
            Console.WriteLine(FirstName + " " + LastName + " - Part Time");
        }
    }

    public class TemporaryEmployee1 : Employee1
    {
        public override void PrintFullName1()
        {
            Console.WriteLine(FirstName + " " + LastName + " - Temporary");
        }
    }
}
