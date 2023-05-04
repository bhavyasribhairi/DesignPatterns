using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class CreditCardFactory
    {

        public CreditCard GetCreditCard(string cardType)
        {
            CreditCard card= null;
            if (cardType == "MoneyBack")
            {
                card= new MoneyBack();
            }
            else if (cardType == "Platinum")
            {
                card= new Platinum();
            }
            else if(cardType == "Titanium")
            {
                card= new Titanium();
            }
            return card;
        }
    }
}
