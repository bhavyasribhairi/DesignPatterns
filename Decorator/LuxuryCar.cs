using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class LuxuryCar : Decorator
    {
        public LuxuryCar(ICar Car) : base(Car)
        {
        }

        public void Design()
        {
            base.Design();
            Console.WriteLine("Luxury car design");
        }
    }
}
