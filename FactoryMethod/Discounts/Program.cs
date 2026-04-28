using System.ComponentModel;

namespace Discounts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DiscountHandler waiter = new Waiter();
            DiscountHandler manager = new Manager();
            DiscountHandler owner = new Owner();

            waiter.setNext(manager);
            manager.setNext(owner);

            Console.WriteLine("Enter your discount (0-15%)");
            double discountPercent = Double.Parse(Console.ReadLine());
            waiter.proccessRequest(discountPercent);

        }
    }
}
