namespace OrderApproval1
{
        public class Program
        {
            static void Main(string[] args)
            {
                ValidationHandler validationHandler = new ValidationHandler();
                InventoryCheckHandler inventoryCheckHandler = new InventoryCheckHandler();
                PaymentVerificationHandler paymentVerificationHandler = new PaymentVerificationHandler();
                ShippingConfirmationHandler shippingConfirmationHandler = new ShippingConfirmationHandler();

                validationHandler.SetNextHandler(inventoryCheckHandler);
                inventoryCheckHandler.SetNextHandler(paymentVerificationHandler);
                paymentVerificationHandler.SetNextHandler(shippingConfirmationHandler);

                
                Order order1 = new Order { OrderId = "12345", TotalAmount = 20.0M };
                Order order2 = new Order { OrderId = "13664", TotalAmount = 7.0M };
                Order order3 = new Order { OrderId = "12345", TotalAmount = 4.0M };

                List<Order> orders = new List<Order>();
                orders.Add(order1);
                orders.Add(order2);
                orders.Add(order3);

                foreach(var order in orders)
                {
                    validationHandler.DistributeOrderProcessing(order);
                }

            }
        }
}
   