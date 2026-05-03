using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersForRestaurant
{
    public class SushiOrder : ICommand
    {
        private Chef _chef;
        public SushiOrder(Chef chef)
        {
            _chef = chef;
        }
        public void Execute()
        {
            _chef.CookSushi();
        }
    }
}
