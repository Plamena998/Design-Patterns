using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersForRestaurant
{
    public class Waiter
    {
        public List<ICommand> orders = new List<ICommand>();

        public void TakeOrder(ICommand order)
        {
            orders.Add(order);
            order.Execute();
        }
    }
}
