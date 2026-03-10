using Restaurant.Abstraction;
using Restaurant.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.ConcreteFactories
{
    public class FrechFactory : RestaurantFactory
    {
        public override IChef CreateChef()
        {
            return new FrenchChef();
        }

        public override IDish CreateDish()
        {
            return new FrenchDish();
        }

        public override IDrink CreateDrink()
        {
            return new FrenchDrink();
        }
    }
}
