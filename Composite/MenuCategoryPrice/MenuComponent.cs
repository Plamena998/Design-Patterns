using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCategoryPrice
{
    public abstract class MenuComponent
    {
        public abstract void Display(int depth);

        public virtual double GetPrice()
        {
            return 0;
        }
    }

}
