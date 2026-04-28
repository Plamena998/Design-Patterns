using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounts
{
    public class Manager : DiscountHandler
    {
        public override void proccessRequest(double percent)
        {
            if (percent <= 10) 
            {
                Console.WriteLine($"The {nameof(Manager)} proccess the discount of {percent}%.");
            }
            else
            {
                nextHadler.proccessRequest(percent);
            }
        }    
    }
}
