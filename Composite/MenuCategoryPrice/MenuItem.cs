using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCategoryPrice
{
    public class MenuItem : MenuComponent
    {
        private string _name;
        private double _price;

        public MenuItem(string name, double price)
        {
            this._name = name;
            this._price = price;
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + " " + _name + ": " + _price + " €.");
        }
        public override double GetPrice()
        {
            return _price;
        }
    }
}
