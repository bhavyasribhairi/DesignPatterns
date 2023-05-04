using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class PassengerCar : Decorator
    {
        public PassengerCar(ICar Car) :base(Car) 
        {
        }


        public void Design()
        {
            base.Design();
            Console.WriteLine("OPassenger car details");
        }
    }
}
