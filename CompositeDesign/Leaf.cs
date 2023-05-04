using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesign
{
    public class Leaf : Component
    {
        public int Salary { get; }

        public Leaf(string Name, int Salary) :base(Name)
        {
            this.Salary = Salary;

        }
        public override int GetSalary()
        {
            return Salary;
        }
    }
}
