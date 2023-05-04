using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class TemporaryEmployeeConcretePrototype :EmployeePrototype
    {
        public string Designation { get; set; }

        public override EmployeePrototype GetClone()
        {
            return(TemporaryEmployeeConcretePrototype)this.MemberwiseClone();
        }

        public override void ShowDetails()
        {
            Console.WriteLine("TemporaryEmployee");
            Console.WriteLine("Desgination is" + this.Designation);
        }
    }
}
