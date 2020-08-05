using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class interfacevsabstractclass
    {

    }
    //COMMON FEATURES
    //1. Both are incomplete
    //2. Both can't have instances
    //3. Both can only act as base types

    //DIFFERENCES
    //1. Abstract class can have implementation for some of its members
    //   but interface cannot have implementation for any of its members
    //2. Abstract class can have fields
    //   but interface cannot have fields
    //3. Abstract class members are private by default and can have access modifiers
    //   but interface members cannot have access modifiers and are public by default
    //4. Interface can inherit from another interface only and cant inherit an abstract class
    //   but abstract class can inherit from another abstract class as well as interfaces
    //5. A class can inherit from multiple interfaces at the same time
    //   but class cannot inherit from multiple abstract classes at the same time

    public abstract class A1
    {
        int i = 0; //field
        public void print() //method with implementation
        {
            Console.WriteLine("A");
        }

        public abstract void pa(); //abstract method
    }

    interface Ia
    {
        void IPrint();
    }
}
