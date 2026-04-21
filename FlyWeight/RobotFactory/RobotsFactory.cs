using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotFactory
{
    public class RobotsFactory
    {
        private static Dictionary<string, RobotType> robotTypes = new Dictionary<string, RobotType>();

        public static RobotType GetRobotType(string name, string color, string image)
        {
            if (!robotTypes.ContainsKey(name))
            {
                return robotTypes[name] = new RobotType(name, color, image);
            }
            else return robotTypes[name];
        }
    }
}
