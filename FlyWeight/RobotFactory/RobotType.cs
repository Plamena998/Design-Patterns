using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotFactory
{
    public class RobotType
    {
        public string Color;
        public string Name;
        public string Image;

        public RobotType(string name, string color, string image)
        {
           this.Name = name;
           this.Color = color;
           this.Image = image;
            Console.WriteLine($"New model {Name} {Color} has been create.");
        }

        public void Display(int x, int y, int XP)
        {
            Console.WriteLine($"Drawing model {Name} with position ({x}, {y} with {XP} points)");
        }
    }
}
