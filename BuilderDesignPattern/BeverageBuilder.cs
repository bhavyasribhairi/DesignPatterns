using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public abstract class BeverageBuilder

    { 
        public Beverage builder;
        public void CreateBeverage()
        {
            builder = new Beverage();
        }

        public Beverage GetBeverage()
        {
            return builder;
        }


        public abstract void SetBeverageType();
        public abstract void SetMilk();
        public abstract void SetWater();
        public abstract void SetPowder();
        public abstract void SetSugar();


    }
}
