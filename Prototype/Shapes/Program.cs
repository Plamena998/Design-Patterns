namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle initialCircle = new Circle
            {
                x = 10,
                y = 10,
                color = "Розов",
                radius = 50
            };

            Circle clonedCircle = (Circle)initialCircle.Clone();

            clonedCircle.x = 100;
            clonedCircle.y = 100;

            Console.WriteLine($"Оригинал: {initialCircle}");
            Console.WriteLine($"Клонинг:  {clonedCircle}");

            
            Console.WriteLine($"Еднакви обекти ли са? {ReferenceEquals(initialCircle, clonedCircle)}");
        }
    }
}
