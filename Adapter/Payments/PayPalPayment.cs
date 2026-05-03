using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments
{
    public class PayPalPayment : IPaymentProccessor
    {
        protected readonly OldPaymentSystem oldPayment;
        public PayPalPayment(OldPaymentSystem oldPayment)
        {
            this.oldPayment = oldPayment;
        }
        public void Pay(double price)
        {
            string format = price.ToString("F2");
            oldPayment.MakeTransaction(format, "BGN");
        }
    }
}
