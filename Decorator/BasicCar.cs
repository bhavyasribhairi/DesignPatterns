using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class BasicCar : ICar
    {
        public  void Design()
        {
            Console.WriteLine("Basic Car Details");
        }
    }
}
