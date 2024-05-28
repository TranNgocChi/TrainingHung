using BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DAO
{
    public class ProductDAO
    {
        //Using Singleton Design Pattern
        private static ProductDAO instance = new();
        private static readonly object instanceLock = new();
        private ProductDAO() { }
        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    instance ??= new ProductDAO();
                }
                return instance;
            }
        }

        public List<Product> GetAll()
        {
            List<Product> products = new();
            using AppDbContext context = new();
            try
            {
                products = context.Products.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return products;
        }

        public void Create(Product product)
        {
            using AppDbContext context = new();
            try
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
