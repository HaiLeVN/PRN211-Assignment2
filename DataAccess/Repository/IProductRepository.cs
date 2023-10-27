using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        void Create(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
