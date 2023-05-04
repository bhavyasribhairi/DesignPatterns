using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public  class BeverageDirector
    {
        public Beverage MakeBevarage(BeverageBuilder beverageBuilder)
        {
            beverageBuilder.CreateBeverage();
            beverageBuilder.SetBeverageType();
            beverageBuilder.SetWater();
            beverageBuilder.SetMilk();
            beverageBuilder.SetPowder();
            beverageBuilder.SetSugar();
            return beverageBuilder.GetBeverage();
        }
    }
}
