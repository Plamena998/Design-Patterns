using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    public interface IPizza
    {
        public string GetDescription();
        public double GetPrice();
    }
}
