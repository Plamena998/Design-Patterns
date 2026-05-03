namespace Payments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPaymentProccessor payment = new PayPalPayment(new OldPaymentSystem());
            Console.WriteLine("Paying the bill...");
            payment.Pay(5.5);
        }
    }
}
