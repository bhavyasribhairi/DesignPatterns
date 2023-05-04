using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public abstract class EmployeePrototype
    {
        public string Name { get; set; }
        public string  Department { get; set; }

        public string EmploymentType { get; set; }


        public abstract EmployeePrototype GetClone();

        public abstract void ShowDetails();

        

    }
}
