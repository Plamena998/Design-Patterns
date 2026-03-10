using Restaurant.Abstraction;
using Restaurant.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.ConcreteFactories
{
    internal class BulgarianFactory : RestaurantFactory
    {
        public override IChef CreateChef()
        {
            return new BulgarianChef();
        }

        public override IDish CreateDish()
        {
            return new BulgarianDish();
        }

        public override IDrink CreateDrink()
        {
            return new BulgarianDrink();
        }
    }
}
