using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class ClassIncsharp
    {
        //A class can have data and behaviour

        //These are data
        string _firstName = "";
        string _lastName = "";


        //Here we have overloaded constructors. one with no parameters and one with 2 parameters

        //If an instance of the class is created using no arguments we can use this constructor to initialise the firstname and lastname
        public ClassIncsharp() : this("No First Name","No Last Name Provided")
        {

        }

        //Constructor of a class has the same name of the class and no return type
        public ClassIncsharp(string Fname,string Lname)
        {
            this._firstName = Fname;
            this._lastName = Lname;
            //this._firstName ---- this keyword refers to an instance of the class/ or an object of the class
        }
        
        //Method
        public void PrintFullName()
        {
            Console.WriteLine("Full Name is {0}", this._firstName + " " + this._lastName);
        }

        //Destructors are used to clean up the objects used in the class
        //It cannot take parameters and has a tilde symbol before it 
        //It is used to clean any resources used by the class in its lifetime
        //In c# they are automatically called by the garbage collector
        ~ClassIncsharp()
        {
            //Clean the code
        }

    }

    class Program1
    {
        public static void main()
        {
            ClassIncsharp C1 = new ClassIncsharp();
            C1.PrintFullName();

            ClassIncsharp C2 = new ClassIncsharp("Adithya", "Vijay");
            C1.PrintFullName();
        }
    }
}