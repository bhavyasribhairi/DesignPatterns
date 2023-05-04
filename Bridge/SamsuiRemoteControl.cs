using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Bridge
{
    public class SamsuiRemoteControl : AbstractRemoteControll
    {
        private readonly ILedTV ledTV;

        public SamsuiRemoteControl(ILedTV ledTV)
        {
            this.ledTV = ledTV;
        }
        public override void SetChannel(int channelNumber)
        {
            ledTV.SetChannel(channelNumber);
        }

        public override void Turnoff()
        {
          ledTV.TurnOFF();
        }

        public override void Turnon()
        {
            ledTV.TurnON();
        }
    }
}
