using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounts
{
    public class Owner : DiscountHandler
    {
        public override void proccessRequest(double percent)
        {
            if (percent > 10 && percent<15) 
            {
                Console.WriteLine($"The {nameof(Owner)} proccess the discount of {percent}%.");
            } 
        }
    }
}
