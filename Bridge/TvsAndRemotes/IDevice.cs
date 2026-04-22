using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvsAndRemotes
{
    public interface IDevice
    {
        void isOn(bool isOn);

        void setVolume(int volumeByUser);
    }
}
