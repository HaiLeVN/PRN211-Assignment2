using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderDetailsRepository
    {
        IEnumerable<OrderDetail> findAll();
        OrderDetail findById(int id);
        OrderDetail findByProductID(int productID);
        public void DeleteById(int orderId);
        void Create(OrderDetail orderDetail);
        void Update(OrderDetail orderDetail);
        void Delete(OrderDetail orderDetail);
    }
}
