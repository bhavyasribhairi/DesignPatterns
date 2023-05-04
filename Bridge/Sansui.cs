using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Sansui : ILedTV
    {
        void ILedTV.SetChannel(int channelNumber)
        {
            string s= String.Format("Samsung tv playing {0} channel number", channelNumber);
            Console.WriteLine(s);
        }

        void ILedTV.TurnOFF()
        {
            Console.WriteLine("samsung tv turned off");
        }

        void ILedTV.TurnON()
        {
            Console.WriteLine("samsung tv turned on");
        }
    }

}
