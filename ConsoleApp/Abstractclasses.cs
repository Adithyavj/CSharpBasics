using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    //non abstract class
    class Abstractclasses : Custom //since this inherits the abstract class it has to implement all the abstract members
    {
        public override void PrintA() //to implement the abstract method we have to use override keyword
        {

        }

        static void main()
        {
            //we can call this using 2 ways
            Abstractclasses c = new Abstractclasses();
            c.PrintA();

            //OR
            Custom c1 = new Abstractclasses();
            c1.PrintA();
        }
    }

    //abstract classes are incomplete
    //abstract class can only be used as base class
    //an abstract class cannot be sealed
    //it can have both abstract methods and non abstract methods

    //ABSTRACT -- It can only be used as a base class 
    //SEALED   -- It cannot be used as a base class
    //(abstract class cannot be sealed and vice versa)

    //now this class is abstract -- abstract keyword
    public abstract class Custom
    {
        //Non Abstract method
        public void Print()
        {

        }
        //Abstract method -- this method cannot have implementation
        //this method has to be implemented in the class which inherits the abstract class
        public abstract void PrintA();
    }
}
