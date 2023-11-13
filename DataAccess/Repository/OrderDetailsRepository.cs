using BusinessObject.Models;
using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailsRepository : IOrderDetailsRepository
    {
        public void Create(OrderDetail orderDetail) => OrderDetailDAO.Instance.Create(orderDetail);

        public void Delete(OrderDetail orderDetail) => OrderDetailDAO.Instance.Remove(orderDetail);

        public void DeleteById(int orderId) => OrderDetailDAO.Instance.DeleteById(orderId);

        public IEnumerable<OrderDetail> findAll() => OrderDetailDAO.Instance.GetOrderDetails();

        public OrderDetail findById(int id) => OrderDetailDAO.Instance.findByOrderId(id);

        public OrderDetail findByProductID(int productID) => OrderDetailDAO.Instance.findByProductId(productID);
        public void Update(OrderDetail orderDetail) => OrderDetailDAO.Instance.Update(orderDetail);
    }
}
