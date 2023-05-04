using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class SonyRemoteControl : AbstractRemoteControll
    {
        private readonly ILedTV ledtv;

        public SonyRemoteControl(ILedTV ledtv)
        {
            this.ledtv = ledtv;
        }
        public override void SetChannel(int channelNumber)
        {
            ledtv.SetChannel(channelNumber);
        }

        public override void Turnoff()
        {
            ledtv.TurnOFF();
        }

        public override void Turnon()
        {
            ledtv.TurnON();
        }
    }
}
