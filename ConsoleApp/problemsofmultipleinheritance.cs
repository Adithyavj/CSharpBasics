using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class ClassA
    {
        public virtual void Print()
        {
            Console.WriteLine("A Implementation");
        }
    }

    class ClassB : ClassA
    {
        public override void Print()
        {
            Console.WriteLine("B Implementation");
        }
    }

    class ClassC : ClassA
    {
        public override void Print()
        {
            Console.WriteLine("C Implementation");
        }
    }

    class ClassD : ClassB //, ClassC //assuming c# does support mulitple inheritance
    {
        
    }

    class problemsofmultipleinheritance
    {
        static void main()
        {
            ClassD d = new ClassD();
            d.Print(); //here which overriden method will be called ?? 
            //will it call Print of ClassB/ClassC
            //This ambiguity is called diamond Problem
        }
    }
}
