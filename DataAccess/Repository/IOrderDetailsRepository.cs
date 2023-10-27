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
        IEnumerable<OrderDetail> findById(int id);
        IEnumerable<OrderDetail> findByProductID(int productID);

        void Create(OrderDetail orderDetail);
        void Update(OrderDetail orderDetail);
        void Delete(OrderDetail orderDetail);
    }
}
