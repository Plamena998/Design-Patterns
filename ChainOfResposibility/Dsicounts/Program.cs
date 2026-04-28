namespace Dsicounts
{
        public abstract class DiscountHandler
        {
            protected DiscountHandler _nextHandler;

            public void SetNext(DiscountHandler nextHandler)
            {
                _nextHandler = nextHandler;
            }

            public abstract void ProcessRequest( double discountPercent);
        }

        public class Waiter : DiscountHandler
        {
            public override void ProcessRequest( double discountPercent)
            {
                if (discountPercent <= 5)
                {
                    Console.WriteLine($"[Waiter]: {discountPercent}% отстъпка.");
                }
                else if (_nextHandler != null)
                {
                    Console.WriteLine($"[Waiter]:Прехвърлям на мениджъра...");
                    _nextHandler.ProcessRequest(discountPercent);
                }
            }
        }

        public class Manager : DiscountHandler
        {
            public override void ProcessRequest(double discountPercent)
            {
                if (discountPercent <= 15)
                {
                    Console.WriteLine($"[Manager]: одобрявам {discountPercent}% отстъпка.");
                }
                else if (_nextHandler != null)
                {
                    Console.WriteLine($"[Manager]: Трябва да питам собственика...");
                    _nextHandler.ProcessRequest(discountPercent);
                }
            }
        }

        public class Owner : DiscountHandler
        {
            public override void ProcessRequest(double discountPercent)
            {
                if (discountPercent <= 50)
                {
                    Console.WriteLine($"[Owner]:{discountPercent}% отстъпка.");
                }
                else
                {
                    Console.WriteLine($"Отказано!");
                }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                var waiter = new Waiter();
                var manager = new Manager();
                var owner = new Owner();

                waiter.SetNext(manager);
                manager.SetNext(owner);

                Console.WriteLine("3%");
                waiter.ProcessRequest(3);

                Console.WriteLine("\n12%");
                waiter.ProcessRequest( 12);

                Console.WriteLine("\n40%");
                waiter.ProcessRequest( 40);

                Console.WriteLine("\n 80%");
                waiter.ProcessRequest(80);
            }
        }
}
