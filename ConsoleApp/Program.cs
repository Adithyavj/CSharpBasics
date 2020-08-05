using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        
        //Main method is executed first
        static void Main(string[] args)
        {
            //Console.WriteLine("Print Main");
            //Main1();
            Loops lp = new Loops();
            //lp.main();
            //lp.forloop();
            lp.foreachloop();
        }

        static void Main1()
        {
            Console.WriteLine("Enter Name");
            string UserName = "";
            UserName = Console.ReadLine();

            //Using Placeholder
            Console.WriteLine("Name is {0}", UserName);

            //using appending string
            //Console.WriteLine("Name :" + UserName);
        }
    }
}
