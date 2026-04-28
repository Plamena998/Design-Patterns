using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discounts
{
     public abstract class DiscountHandler
    {
        protected DiscountHandler nextHadler;

        public abstract void proccessRequest(double percent);
        public void setNext(DiscountHandler handler)
        {
            this.nextHadler = handler;
        }
    }
}
