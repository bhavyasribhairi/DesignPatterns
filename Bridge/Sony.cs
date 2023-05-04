using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Sony : ILedTV
    {
        void ILedTV.SetChannel(int channelNumber)
        {
            Console.WriteLine("channel number {0} was changed", channelNumber);
        }

        void ILedTV.TurnOFF()
        {
            Console.WriteLine("Turnoff");
        }

        void ILedTV.TurnON()
        {
            Console.WriteLine("Turnon");
        }
    }
}
