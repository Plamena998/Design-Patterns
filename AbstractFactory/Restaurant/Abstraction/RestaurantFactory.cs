using Restaurant.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Abstraction
{
    public abstract class RestaurantFactory
    {
        public abstract IChef CreateChef();
        public abstract IDish CreateDish();
        public abstract IDrink CreateDrink();

    }
}
