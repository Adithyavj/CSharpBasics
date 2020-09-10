using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public delegate void SampleDelegate();


    //A delegate that points to more than one function is called a multicastdelgate
    //It has reference to mulitple functions
    class MultiCastDelegate
    {
        static void main()
        {
            //Normal invoking of a delegate
            //SampleDelegate del = new SampleDelegate(SampleMethodOne);
            //del();

            //1. The first method to mulitcast a Delegate
            SampleDelegate del1, del2, del3, del4;
            del1 = new SampleDelegate(SampleMethodOne);
            del2 = new SampleDelegate(SampleMethodTwo);
            del3 = new SampleDelegate(SampleMethodThree);
            //we can chain the delegates together using a + operator
            del4 = del1 + del2 + del3;
            del4(); //this delegate del4 is a mulitcast delegate and it will invoke all the 3 methods

            //if we cant to exclude a delegate use a minus sign
            del4 = del1 + del2 + del3 - del2;
            del4();


            //2. Second method to invoke a multicast delegate
            SampleDelegate del = new SampleDelegate(SampleMethodOne);
            del += SampleMethodTwo; //we use + / += to register a method with the delegate
            del += SampleMethodThree;

            del -= SampleMethodOne; //we use -/-= to unregister a method from a delegate

            del(); //the methods in the invokation list are invoked in the same order they are registered
        }

        static void SampleMethodOne()
        {
            Console.WriteLine("Sample Method one invoked");
        }

        static void SampleMethodTwo()
        {
            Console.WriteLine("Sample Method two invoked");
        }

        static void SampleMethodThree()
        {
            Console.WriteLine("Sample Method three invoked");
        }
    }

    //Let us see the case of a multicast delegate with a return type

    public delegate int Delwithreturntype();

    class DelegateWithReturnType
    {
        static void main()
        {
            Delwithreturntype delr = new Delwithreturntype(MethOne);
            delr += MethTwo;
            int i = delr(); //the delegate will only return the value returned by the last function in the invokation list
                            //in this case it is methTwo ie, 2
            Console.WriteLine("Return Value = {0}", i);
        }

        static int MethOne()
        {
            return 1;
        }

        static int MethTwo()
        {
            return 2;
        }
    }
}
