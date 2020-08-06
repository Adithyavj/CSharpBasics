using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    //the signature of a delegate is very similar to that of a function
    //it has an access modifier, a delegate keyword, a return type and arguments
    //the below defined delegate can point to any function with a void return type and a single string argument
    public delegate void HellofunctionDelegate(string Message);

    //The way we call a delegate is very similar to that of a class
    // we create an object and call the delegate

    class Delegatesincsharp
    {
        static void main()
        {
            //We pass a function to the constructor of the delegate
            HellofunctionDelegate del = new HellofunctionDelegate(Hello); //the constructor of delegate takes a function with void return type and string argument
            del("This is a call from Delegate"); //this point to the Hello function
            //if the signature of the delegate doesnt match that of the function,
            //then there will be a compiler error, this is why delegate are called type safe
        }

        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
        //DEFINITION
        //A delegate is a tyep safe function pointer
        //ie, a delegate points to a function and when you invoke the delegate the function will be invoked
        //it holds a reference(pointer) to a function
    }
}
