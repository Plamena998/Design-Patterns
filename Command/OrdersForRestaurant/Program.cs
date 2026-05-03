namespace OrdersForRestaurant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();
            Waiter waiter = new Waiter();

            ICommand order1 = new PastaOrder(chef);
            ICommand order2 = new SushiOrder(chef);

            waiter.TakeOrder(order1);
            waiter.TakeOrder(order2);

            
        }
    }
}
