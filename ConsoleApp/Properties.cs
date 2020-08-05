using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    //Properties are essential because using class fields as public is a bad practise
    //In programming languages that didn't have properties, we use get and set methods
    //this was using encapsulation
    //we use encapsulation here
    //get and set methods are used to encapsulate the fields in the student class
    class Properties
    {
        public static void main()
        {
            //1.Old Code implementation
            //here since the fields are public we can change the values here 
            //thus we have to make them private
            #region Code
            //Students s = new Students();
            //s.ID = -3;
            //s.Name = null;
            //s.PassMark = 0;
            //Console.WriteLine("ID is {0}, Name is {1}, PassMark is {2}",
            //    s.ID, s.Name, s.PassMark);
            #endregion

            Students s = new Students();
            s.SetId(-101);
            s.SetName("Name");
            Console.WriteLine("Student ID is {0}", s.GetId());
            Console.WriteLine("Student Name is {0}", s.GetName());
            Console.WriteLine("Student PassMark is {0}", s.Getpassmark());
        }

    }

    class Students
    {
        //1.Old Code
        //public int ID; //shouldn't be negative
        //public string Name; //shouldn't be null
        //public int PassMark = 35; //shouldn't be changed


        //2. Changed Code
        private int _ID; //shouldn't be negative
        private string _Name; //shouldn't be null
        //Readonly since it has only a get method, value cannot be assigned to it
        private int _PassMark = 35; //shouldn't be changed

        //Set Method -- this method sets the private field _id to an appropriate value
        public void SetId(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Student Id cannot be negative");
            }
            this._ID = id;
        }

        //Get Method -- this method is used to get the id value (read ID value)
        public int GetId()
        {
            return this._ID;
        }


        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Name cannot be null or empty");
            }
            this._Name = name;
        }

        public string GetName()
        {
            return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;
            //if (string.IsNullOrEmpty(this._Name))
            //{
            //    return "No Name";
            //}
            //return this._Name;
        }

        public int Getpassmark()
        {
            return this._PassMark;
        }
             
    }
}
