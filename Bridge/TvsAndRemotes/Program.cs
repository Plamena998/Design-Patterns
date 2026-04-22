using TvsAndRemotes.TvsAndRemotes;

namespace TvsAndRemotes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LGTv LGtv = new LGTv();
            Remote remote = new Remote(LGtv);
            remote.TogglePower();
            remote.setVolume(50);
            remote.MuteTv();

        }
    }
}
