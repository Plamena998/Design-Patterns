using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotFactory
{
    public class Robot
    {
        private int x;
        private int y;
        private int XP;
        private RobotType Type;

        public Robot(int x, int y, int xp, RobotType type)
        {
            this.y = y;
            this.x = x;
            this.XP = xp;
            this.Type = type;
        }

        public void ShowType()
        {
            Type.Display(x, y, XP);
        }
    }
}
