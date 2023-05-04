using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class Platinum : CreditCard
    {
        int CreditCard.GetAnnualCharge()
        {
            return 700;
        }

        string CreditCard.GetCardType()
        {
            return "Platinum";
        }

        int CreditCard.GetCreditLimit()
        {
            return 30000;
        }
    }
}
