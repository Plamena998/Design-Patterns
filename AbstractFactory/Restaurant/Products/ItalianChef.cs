using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Products
{
    public class ItalianChef : IChef
    {
        public void Cook()
        {
            Console.WriteLine("The chef is Chef Gustino");
        }
    }
}
