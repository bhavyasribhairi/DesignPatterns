using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterC
{
    public class ThirdPartyBillingSystem
    {
        public void ProcessSalaryTP(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine("Salary of {employee.id} is : {employee.salary}", employee.ID, employee.Salary);
            }
        }
    }
}