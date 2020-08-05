using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    //In c# to encapsulate and protect fields we use properites
    class Propertiesincsharp
    {
        //We have the following properties in c#
        //1. Read/Write properties
        //2. ReadOnly properties
        //3. WriteOnly properties
        //4. AutoImplemented properties
        public static void main()
        {
            Student1 s = new Student1();
            s.Id = 100;
            s.name = "Name";
        }

    }

    //replace get and set using properties
    public class Student1
    {
        private int _ID; //shouldn't be negative
        private string _Name; //shouldn't be null
        private int _PassMark = 35;

        //This is a read/write property
        public int Id
        {
            //Get and Set are called accessors
            //properties are implemented using get and set accessors
            set
            {
                //the value keyword gets the value passed
                if (value <= 0)
                {
                    throw new Exception("Student Id cannot be negative");
                }
                this._ID = value;
            }
            get
            {
                return this._ID;
            }
        }

        //This is a read/write property
        public string name
        {
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be null or empty");
                }
                this._Name = value;
            }
            get
            {
                return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;
            }
        }

        //Read only property
        public int passmark
        {
            get
            {
                return this._PassMark;
            }
        }

        //AutoImplemented Properties in c#
        public string city
        {
            //here the complier will create a private string field city that can only be accessed using the get and set accessors
            //this is used for properties with no logic in the set and get
            get;
            set;
        }

        //AutoImplemented Properties was introduced in c# 3.0
        public string email { get; set; }
    }
}

