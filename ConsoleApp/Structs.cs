using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Structs
    {

        //Just like classes a structure can also have
        //1. Private fields
        //2. Public properties
        //3. Constructors
        //4. Methods
        public static void main()
        {

            //using constructor to initialize the fields
            Customer c1 = new Customer(100, "Mark");
            c1.PrintDetails();

            //using property to initialise
            Customer c2 = new Customer();
            c2.id = 101;
            c2.Name = "John";
            c2.PrintDetails();

            //using object initialise syntax
            Customer c3= new Customer{
                id=103,
                Name="Ravi"
            };
            c3.PrintDetails();
        }
    }


    public struct Customer
    {
        //Fields
        private int _ID;
        private string _Name;

        //property
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public int id
        {
            set { this._ID = value; }
            get { return this._ID; }
        }

        //constructor
        public Customer(int id,string name)
        {
            this._ID = id;
            this._Name = name;
        }

        //method
        public void PrintDetails()
        {
            Console.WriteLine("Id = {0} and Name = {1}", this._ID, this._Name);
        }

    }
}
