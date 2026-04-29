using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCategoryPrice
{
    public class MenuCategory : MenuComponent
    {   
        private string _name;
        private List<MenuComponent> _children = new List<MenuComponent>();

        public MenuCategory(string name) => _name = name;
        public void Add(MenuComponent component) => _children.Add(component);
       
        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + " [" + _name.ToUpper() + "]");
            foreach (var component in _children)
            {
                component.Display(depth + 2);
            }
        }
        public override double GetPrice()
        {
            double total = 0;
            foreach (var component in _children) total += component.GetPrice();
            return total;
        }


    }
}
