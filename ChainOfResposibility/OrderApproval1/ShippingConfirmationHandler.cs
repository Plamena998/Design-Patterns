using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApproval1
{
    public class ShippingConfirmationHandler : BaseOrderHandler
    {
        protected override bool CanProcessOrder(Order order)
        {
            if (order.TotalAmount >10.0M)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected override void ProcessOrder(Order order)
        {
            Console.WriteLine("Shipping confirmation completed for order: " + order.OrderId);
        }
    }
}
