using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class Beverage
    {
        public int Water { get; set; }
        public int Milk { get; set; }
        public int Sugar { get; set; }
        public int Powder { get; set; }
        public string BeverageName { get; set; }




        public string BeverageMakingProcess()
        {
            return $"Add {Water}ml of water with {Milk}ml of Milk. Add {Powder} spoons of Powder" +
                $" of your choice with {Sugar} spoons of Sugar. And the {BeverageName} is ready";
        }



    }
}
