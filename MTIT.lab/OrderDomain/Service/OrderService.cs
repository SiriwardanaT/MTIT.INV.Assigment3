using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderDomain.Service
{
    public class OrderService : IOrderServicecs
    {
        public Modals.Order CreateOrder(Modals.Order order)
        {
            Data.OrderDAO.Orders.Add(order);
            return order;
        }

        public string DeleteOrder(int orderid)
        {
            Modals.Order getOrder=  Data.OrderDAO.Orders.Find(order => order.OrderId == orderid);
            Data.OrderDAO.Orders.Remove(getOrder);
            return orderid.ToString();
        }

        public List<Modals.Order> GetAllOrders()
        {
            return Data.OrderDAO.Orders;
        }

        public Modals.Order GetOrdersOrderId(int orderid)
        {
            return Data.OrderDAO.Orders.FirstOrDefault(order => order.OrderId == orderid);
        }
    }
}
