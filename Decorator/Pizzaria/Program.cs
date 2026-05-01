namespace Pizzaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPizza pizza = new Pizza();

            pizza = new CheeseDecorator(pizza);

            pizza = new HamDecorator(pizza);

            Console.WriteLine($"Order: {pizza.GetDescription()}");
            Console.WriteLine($"Price: {pizza.GetPrice()}");
        }
    }
}
