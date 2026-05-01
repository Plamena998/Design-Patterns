using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    public class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(IPizza pizza) : base(pizza)
        {
        }
        public override string GetDescription()
        {
            return base.GetDescription() + ", cheese";
        }
        public override double GetPrice()
        {
            return base.GetPrice() + 2.5;
        }
    }
}
