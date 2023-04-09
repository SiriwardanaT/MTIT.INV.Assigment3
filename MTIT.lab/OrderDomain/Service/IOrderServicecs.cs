using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderDomain.Service
{
    public interface IOrderServicecs
    {
        Modals.Order CreateOrder(Modals.Order order);

        List<Modals.Order> GetAllOrders();

        Modals.Order GetOrdersOrderId(int orderId);

        string DeleteOrder(int orderId);
    }
}
