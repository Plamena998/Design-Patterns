using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersForRestaurant
{
    public class PastaOrder : ICommand
    {
        private Chef chef;
        public PastaOrder(Chef chef)
        {
         this.chef = chef;   
        }
        public void Execute()
        {
            chef.CookPasta();
        }
    }
}
