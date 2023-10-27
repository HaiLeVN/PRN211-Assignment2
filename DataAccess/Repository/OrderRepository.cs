using BusinessObject.Models;
using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public void AddOrder(Order order) => OrderDAO.Instance.AddOrder(order);

        public bool DeleteOrder(Order order) => OrderDAO.Instance.RemoveOrder(order);

        public Order findById(int id) => OrderDAO.Instance.findById(id);

        public IEnumerable<Order> FindOrdersByMemberId(int memberId) => OrderDAO.Instance.GetAllOrdersByMemberId(memberId);

        public IEnumerable<Order> GetAllOrders() => OrderDAO.Instance.GetAllOrders();

        public void UpdateOrder(Order order) => OrderDAO.Instance.UpdateOrder(order);
    }
}
