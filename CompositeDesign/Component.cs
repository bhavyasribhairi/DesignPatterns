using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesign
{
    public abstract class Component
    {
        public string Name { get; }
        public Component(string name)
        {
            this.Name = name;
        }
        public abstract int GetSalary();
    }
}
