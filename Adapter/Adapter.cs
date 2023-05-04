using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AdapterC
{
    public class Adapter : ITarget
    {

        ThirdPartyBillingSystem tpBillingSystem = new ThirdPartyBillingSystem();


        public void ProcessSalary(string[,] employeesArray)
        {

            ThirdPartyBillingSystem thirdPartyBillingSystem = new ThirdPartyBillingSystem();
            string Id = null;
            string Name = null;
            //string Designation = null;
            string Salary = null;

            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < employeesArray.GetLength(0); i++)
            {
                for (int j = 0; j < employeesArray.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        Id = employeesArray[i, j];
                    }
                    else if (j == 1)
                    {
                        Name = employeesArray[i, j];
                    }
                    else
                    {
                        Salary = employeesArray[i, j];
                    }

                }
                employees.Add(new Employee(Convert.ToInt32(Id), Name, Convert.ToInt32(Salary)));
                thirdPartyBillingSystem.ProcessSalaryTP(employees);
            }
        }
    }


}
