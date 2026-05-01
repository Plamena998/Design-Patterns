using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    public class HamDecorator : PizzaDecorator
    {
        public HamDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", ham";
        }
        public override double GetPrice()
        {
            return base.GetPrice() + 3.00;
        }

    }
}
