using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class Titanium : CreditCard
    {
        int CreditCard.GetAnnualCharge()
        {
            return 600;
        }

        string CreditCard.GetCardType()
        {
            return "Titanium";
        }

        int CreditCard.GetCreditLimit()
        {
            return 20000;
        }
    }
}
