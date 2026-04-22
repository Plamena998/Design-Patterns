using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvsAndRemotes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Threading.Tasks;

    namespace TvsAndRemotes
    {
        public class LGTv : IDevice
        {
            public void isOn(bool isOn)
            {
                Console.WriteLine($"{nameof(LGTv)} is on.");
            }
            public void setVolume(int volumeByUser)
            {
                if(volumeByUser == 0)
                {
                    Console.Write("0");
                }
                else
                {
                    Console.Write($"Set volume: {volumeByUser}");

                }
            }
        }
    }

}
