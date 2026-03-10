using Restaurant.Abstraction;
using Restaurant.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.ConcreteFactories
{
    public class ItalianFactory : RestaurantFactory
    {
        public override IChef CreateChef()
        {
            return new ItalianChef();
        }

        public override IDish CreateDish()
        {
            return new ItalianDish();
        }

        public override IDrink CreateDrink()
        {
            return new ItalianDrink();
        }
    }
}
