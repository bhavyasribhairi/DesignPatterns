using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class AbstractRemoteControll
    {
        protected ILedTV ledTV;
        public abstract void SetChannel(int channelNumber);
        public abstract void Turnon();
        public abstract void Turnoff();

    }
}
