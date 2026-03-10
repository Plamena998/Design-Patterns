using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Products
{
    public class ItalianDish : IDish
    {
        public void Serve()
        {
            Console.WriteLine("Pasta Carbonara");
        }
    }
}
