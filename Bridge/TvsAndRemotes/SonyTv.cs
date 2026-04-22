using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvsAndRemotes
{
    public class SonyTv : IDevice
    {
        public void isOn(bool isOn)
        {
            Console.WriteLine($"{GetType} is on.");
        }
        public void setVolume(int volumeByUser)
        {
            if (volumeByUser == 0)
            {
                Console.Write("0");
            }
            else
            {
                Console.WriteLine($"Set volume: {volumeByUser}");

            }
        }
    }
}
