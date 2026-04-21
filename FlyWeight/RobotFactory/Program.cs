using System.Security.Cryptography.X509Certificates;

namespace RobotFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var RedType = RobotsFactory.GetRobotType("Fighter", "red", "redRobot");
            var BlueType = RobotsFactory.GetRobotType("Watcher", "blue", "blueRobot");

            List<Robot> robots = new List<Robot>();
            Random random = new Random();

            RobotType selectedType;

            for(int i=0; i<1000; i++)
            {
                if (i % 2 == 0)
                {
                    selectedType = RedType;
                }
                else
                {
                 selectedType=BlueType;
                }

                int randomX = random.Next(1,100);
                int randomY = random.Next(1,100);
                int randomXp = random.Next(1,50);

                Robot robot = new Robot(randomX, randomY, randomXp, selectedType);

                robots.Add(robot);
            }
        }
    }
}
