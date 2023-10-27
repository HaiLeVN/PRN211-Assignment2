using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        Order findById(int id);
        public IEnumerable<Order> GetAllOrders();
        public IEnumerable<Order> FindOrdersByMemberId(int memberId);
        public void AddOrder(Order order);
        public void UpdateOrder(Order order);
        public bool DeleteOrder(Order order);
    }
}
