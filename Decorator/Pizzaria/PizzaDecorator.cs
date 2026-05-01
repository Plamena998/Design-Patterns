using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    public class PizzaDecorator : IPizza
    {
        protected IPizza _pizza;
        public PizzaDecorator(IPizza pizza)
        {
            this._pizza = pizza;
        }
        public virtual string GetDescription()
        {
            return _pizza.GetDescription();
        }

        public virtual double GetPrice()
        {
            return _pizza.GetPrice();
        }
    }
}
