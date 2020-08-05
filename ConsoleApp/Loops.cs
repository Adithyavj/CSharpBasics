using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    //The 4 types of loop statements in c# are
    //1. while
    //2. do while
    //3. for
    //4. foreach
    public class Loops
    {
        public void main()
        {
            string UserChoice = "";
            do
            {
                Console.WriteLine("Enter your target?");
                int UserTarget = int.Parse(Console.ReadLine());

                int start = 0;
                while (start <= UserTarget)
                {
                    Console.Write(start + " ");
                    start = start + 2;
                }
                do
                {
                    Console.WriteLine("Do you want to continue - Yes or No");
                    UserChoice = Console.ReadLine().ToUpper();
                    if (UserChoice != "YES" && UserChoice != "NO")
                    {
                        Console.WriteLine("Invalid Choice, Please select Yes/No");
                    }
                } while (UserChoice != "YES" && UserChoice != "NO");
            } while (UserChoice == "YES");
        }

        static void whileloop()
        {
            Console.WriteLine("Enter your target?");
            int UserTarget = int.Parse(Console.ReadLine());

            int start = 0;
            while (start <= UserTarget)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
        }

        static void dowhileloop()
        {
            string UserChoice = "";
            do
            {
                Console.WriteLine("Enter your target?");
                int UserTarget = int.Parse(Console.ReadLine());

                int start = 0;
                while (start <= UserTarget)
                {
                    Console.Write(start + " ");
                    start = start + 2;
                }
                do
                {
                    Console.WriteLine("Do you want to continue - Yes or No");
                    UserChoice = Console.ReadLine().ToUpper();
                    if (UserChoice != "YES" && UserChoice != "NO")
                    {
                        Console.WriteLine("Invalid Choice, Please select Yes/No");
                    }
                } while (UserChoice != "YES" && UserChoice != "NO");
            } while (UserChoice == "YES");
        }

        public void forloop()
        {
            int[] Numbers = new int[3];
            Numbers[0] = 100;
            Numbers[1] = 200;
            Numbers[2] = 300;

            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine(Numbers[i]);
            }
            Console.ReadLine();
        }

        public void foreachloop()
        {
            int[] Numbers = new int[3];
            Numbers[0] = 100;
            Numbers[1] = 200;
            Numbers[2] = 300;

            foreach (int num in Numbers)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
    }
}
