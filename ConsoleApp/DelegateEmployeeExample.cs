using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class DelegateEmployeeExample
    {
        static void main()
        {
            List<EmployeeD> empList = new List<EmployeeD>();

            empList.Add(new EmployeeD() { ID = 101, Name = "Adi", Salary = 20000, Experience = 2 });
            empList.Add(new EmployeeD() { ID = 102, Name = "Fasil", Salary = 25000, Experience = 5 });
            empList.Add(new EmployeeD() { ID = 103, Name = "Jishnu", Salary = 10000, Experience = 2 });
            empList.Add(new EmployeeD() { ID = 104, Name = "Ashraf", Salary = 20000, Experience = 6 });

            //instance of the delegate
            IsPromotable isPromotable = new IsPromotable(Promote);

            //calling the function
            EmployeeD.PromoteEmployee(empList, isPromotable);
        }


        //This is the function which does the logic for us
        //It has the same signature as that of the delegate
        public static bool Promote(EmployeeD emp)
        {
            if (emp.Experience >= 5)
                return true;
            else
                return false;
        }
    }

    delegate bool IsPromotable(EmployeeD empl);

    //we make this class reusable
    //depending on the need the method should be flexible
    class EmployeeD
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        //Method to check if employee is promoted
        public static void PromoteEmployee(List<EmployeeD> employeeList, IsPromotable IsEligibleToPromote) // to passin a function as a parameter use a delegate
        {
            foreach (EmployeeD employee in employeeList)
            {
                //here the logic is hardcoded, to replace this and make it reusable
                // we use delegate
                //if (employee.Experience >= 5)
                //{
                //    Console.WriteLine(employee.Name + " Promoted");
                //}

                //We replace the old code with a delegate
                if (IsEligibleToPromote(employee))
                {
                    Console.WriteLine(employee.Name + " Promoted");
                }
            }
        }
    }
}
