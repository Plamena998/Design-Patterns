using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMaker
{
    public class PizzaBuilder
    {
        private Pizza _pizza = new Pizza();

        public PizzaBuilder SetDough(string dough)
        {
            _pizza.Dough = dough;
            return this;
        }

        public PizzaBuilder setSauce(string sauce)
        {
            _pizza.Sauce = sauce;
            return this;
        }

        public PizzaBuilder AddChees()
        {
            _pizza.Toppings.Add("Mozzarella");
            return this;
        }

        public PizzaBuilder AddPepperoni()
        {
            _pizza.Toppings.Add("Pepperoni");
            return this;
        }
        public PizzaBuilder AddOlives()
        {
            _pizza.Toppings.Add("Black olives");
            return this;
        }

        public Pizza Build()
        {
            return _pizza;
        }
    }
}
