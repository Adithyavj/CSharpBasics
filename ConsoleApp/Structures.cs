using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    //Structures are similar to classes 
    //They have
    //1. Fields
    //2. Properties
    //3. Constructors
    //4. Methods
    //The differences are : 
    //Class is a reference type whereas struct is a value type

    //Value types :
    // int,enum,struct etc  (stored on the stack)
    //Reference types:
    // classes,interface,delegates (stored on the heap)

    //lets understand this in detail
    public sealed class Cust //this class cannot be a base class {sealed keyword to prevent inheritance}
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    class Structures
    {
        static void main()
        {
            int i = 0;    //int is a structure therefore value type
                          // when declared it is stored in the stack in m/m
                        //they hold value where they are declared
            Cust c1 = new Cust(); //customer is a class and therefore reference type
                                   //the object reference variable c1 is stored in the stack
                                   //the actual object however is stored in the heap
            c1.id = 101; //in the heap
            c1.name = "Mark"; //in the heap
        }
        //the value types are destroyed once their scope is over
        //in case of referenc types
        // 1. reference object is destroyed once its scope is over
        // 2. the actual object in the heap is destoyed by the GC(garbage collector) when it finds
        //    that the object has no reference variable


        static void diff()
        {
            int i = 10; //i is a struct
            int j = i;  //j is a struct  value of i is assigned to j
            j = j + 1;  //operations on j will not affect the value of i because i & j are two different copies on the stack
            Console.WriteLine("i = {0} && j = {1}", i, j);



            Cust c2 = new Cust();
            c2.id = 101;
            c2.name = "Name";

            Cust c3 = c2; //now what happens is c3 is a copy of the reference variable
                          //both c2 and c3 points toward the same objects in the heap
            c3.name = "New";

            Console.WriteLine("c2.Name= {0} and c3.Name = {1}", c2.name, c3.name); //here both will be "New"
        }
        //structures can't have destructors
        //structures can't have parameter less contructors
        //the above makes sense as a structure is a value type and doesn't need a reference object
        //thus it doesnt need destructor/paramterless constructors

        //structues or classes cannot inherit from other structures but can inherit from interfaces
        //struct are sealed types
    }
}
