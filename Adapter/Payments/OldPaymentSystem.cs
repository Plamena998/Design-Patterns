using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments
{
    public class OldPaymentSystem
    {
        public void MakeTransaction(string amountString, string currency)
        {
            Console.WriteLine($"PayPal: Извършена транзакция за {amountString} {currency}.");
        }
    }
}
