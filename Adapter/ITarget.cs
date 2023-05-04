using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterC
{
    public interface ITarget
    {
        void ProcessSalary(string[,] employeesArray);
    }
}
