using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Products
{
    public class FrenchDrink : IDrink
    {
        public void Pour()
        {
            Console.WriteLine("Wine");
        }
    }
}
