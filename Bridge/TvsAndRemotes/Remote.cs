using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvsAndRemotes
{
    public class Remote
    {
        private IDevice device;

        public Remote(IDevice device)
        {
            this.device = device;
        }
        public void MuteTv()
        {
            Console.Write("Mute tv:");
            device.setVolume(0);
        }
        public void setVolume(int volumeByUser)
        {
            Console.WriteLine($"Set volume: {volumeByUser}");
        }
        public void TogglePower()
        {
            
            device.isOn(true);
        }
    }
}
