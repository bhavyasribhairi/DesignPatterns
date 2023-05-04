using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterC
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public long Salary { get; set; }




        public Employee(int id, string name, long salary)
        {
            this.ID = id;
            this.Name = name;
            this.Salary = salary;

        }


    }
}
