using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class MoneyBack : CreditCard
    {
        int CreditCard.GetAnnualCharge()
        {
           return 500;
        }

        string CreditCard.GetCardType()
        {
            return "MoneyBack";
        }

        int CreditCard.GetCreditLimit()
        {
            return 10000;
        }
    }
}
