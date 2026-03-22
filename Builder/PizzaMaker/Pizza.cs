using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMaker
{
    public class Pizza
    {
        public string Dough {  get; set; }
        public string Sauce { get; set; }
        public List<string> Toppings { get; set; } = new List<string>();
    
    
        public void Show()
        {
            Console.WriteLine($"Пица с {Dough} тесто, {Sauce} сос и добавки: {string.Join(", ", Toppings)}");
        }
    }
}
