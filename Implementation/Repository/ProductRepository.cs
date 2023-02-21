using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceMVC.Context;
using EcommerceMVC.Interface;
using EcommerceMVC.Interface.IRepository;
using EcommerceMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceMVC.Implementation.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationContext _context;
        public ProductRepository(ApplicationContext context)
        {
            _context = context;
        }
        public Product Create(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        public bool Delete(Product product)
        {
             _context.Products.Remove(product);
            _context.SaveChanges();
            return true;
        }

        public Product GetById(int productId)
        {
           var product = _context.Products.SingleOrDefault(x => x.Id == productId);
           return product;
        }

        public IEnumerable<Product> GetAllProduct()
        {
            var products = _context.Products.ToList();
            return products;
        }

        public Product Update(Product product)
        { 
            _context.Products.Update(product);
            _context.SaveChanges();
            return product;
        }
    }
}