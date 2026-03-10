using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Products
{
    public class BulgarianDish : IDish
    {
        public void Serve()
        {
            Console.WriteLine("Banitsa");
        }
    }
}
