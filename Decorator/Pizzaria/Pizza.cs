using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    public class Pizza : IPizza
    {
        public string GetDescription()
        {
            return "Pizza";
        }

        public double GetPrice()
        {
            return 5.00;
        }
    }
}
