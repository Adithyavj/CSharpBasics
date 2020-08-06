using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class DelegateEmployeeExampleusingLambda
    {
        static void main()
        {
            List<EmployeeN> empList = new List<EmployeeN>();

            empList.Add(new EmployeeN() { ID = 101, Name = "Adi", Salary = 20000, Experience = 2 });
            empList.Add(new EmployeeN() { ID = 102, Name = "Fasil", Salary = 25000, Experience = 5 });
            empList.Add(new EmployeeN() { ID = 103, Name = "Jishnu", Salary = 10000, Experience = 2 });
            empList.Add(new EmployeeN() { ID = 104, Name = "Ashraf", Salary = 20000, Experience = 6 });

            //calling the function using Lambda expression
            EmployeeN.PromoteEmployee(empList, emp => emp.Experience >= 5);
        }
    }

    delegate bool IsPromotableN(EmployeeN employeeN);

    class EmployeeN
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        //Method to check if employee is promoted
        public static void PromoteEmployee(List<EmployeeN> employeeList, IsPromotableN IsEligibleToPromote) // to passin a function as a parameter use a delegate
        {
            foreach (EmployeeN employee in employeeList)
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
