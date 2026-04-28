using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApproval1
{
    public class ValidationHandler : BaseOrderHandler
    {
        protected override bool CanProcessOrder(Order order)
        {
            if (order.TotalAmount < 5.0M)
            {
                Console.WriteLine("Validation complete.");
                return true;
            }
            else
            {
                return false;
            }
        }

        protected override void ProcessOrder(Order order)
        {
            Console.WriteLine("Validation completed for order: " + order.OrderId);
        }
    }
}
