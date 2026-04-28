using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApproval1
{
    public class PaymentVerificationHandler : BaseOrderHandler
    {
        protected override bool CanProcessOrder(Order order)
        {
            if (order.TotalAmount < 10.0M && order.TotalAmount>5.0M)
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
            Console.WriteLine("Payment verification completed for order: " + order.OrderId);
        }
    }
}
