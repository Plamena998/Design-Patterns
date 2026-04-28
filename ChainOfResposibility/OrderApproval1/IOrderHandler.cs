using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApproval1
{
    public interface IOrderHandler
    {
        void SetNextHandler(IOrderHandler orderHandler);

        void DistributeOrderProcessing(Order order);
    }
}
