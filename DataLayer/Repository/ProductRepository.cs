using BusinessLayer.Models;
using DataLayer.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public class ProductRepository : IProductRepository
    {
        public void Create(Product product) => ProductDAO.Instance.Create(product);
        public List<Product> GetAll() => ProductDAO.Instance.GetAll();  
    }
}
