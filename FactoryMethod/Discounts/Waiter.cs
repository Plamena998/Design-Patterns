using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounts
{
    public class Waiter : DiscountHandler
    {
        public override void proccessRequest(double percent)
        {
            if (percent==0 || percent>15)
            {
                Console.WriteLine($"Discount cannot be proccess.");
            }
            if(percent <= 5)
            {
                Console.WriteLine($"The {nameof(Waiter)} proccess the discount of {percent}%.");
            }
            
            else
            {
                nextHadler.proccessRequest(percent);
            }
        }
    }
}
