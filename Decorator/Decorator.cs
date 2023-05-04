using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Decorator : ICar
    {
        public ICar Car;

        public Decorator(ICar Car)
        {
            this.Car = Car;

        }


        public void Design()
        {
            Console.WriteLine("Car details");
        }
    }
}
