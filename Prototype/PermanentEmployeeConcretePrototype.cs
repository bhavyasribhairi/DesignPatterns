using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class PermanentEmployeeConcretePrototype : EmployeePrototype
    {


        public int Salary { get; set; }
        public override EmployeePrototype GetClone()
        {
            return (PermanentEmployeeConcretePrototype)this.MemberwiseClone();
        }

        public override void ShowDetails()
        {
            Console.WriteLine("Permanent Employee");
            Console.WriteLine("Salary is"+this.Salary);
        }
    }
}
