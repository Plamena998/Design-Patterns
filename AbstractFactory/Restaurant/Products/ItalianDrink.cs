using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Products
{
    internal class ItalianDrink : IDrink
    {
        public void Pour()
        {
            Console.WriteLine("Champain");      
        }
    }
}
