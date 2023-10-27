using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class ProductDAO
    {
        
        public static ProductDAO instance = null;
        public static object instanceLock = new object();
        public static ProductDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProductDAO();
                }
                return instance;
            }
        }

        public IEnumerable<Product> findAll()
        {
            IEnumerable<Product> products = new List<Product>();
            try
            {
                var context = new SalesManagementContext();
                products = context.Products;
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return products;
        }

        public void insert(Product product)
        {
            try
            {
                var context = new SalesManagementContext();
                context.Products.Add(product);
                context.SaveChanges();
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void update(Product product)
        {
            try
            {
                var context = new SalesManagementContext();
                context.Products.Update(product);
                context.SaveChanges();
            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void delete(Product product)
        {
            try
            {
                var context = new SalesManagementContext();
                context.Products.Remove(product);
                context.SaveChanges();
            } catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
