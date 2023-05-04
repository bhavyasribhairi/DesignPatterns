using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public interface ILedTV
    {
        void TurnON();
        void TurnOFF();
        void SetChannel(int channelNumber);



    }
}
