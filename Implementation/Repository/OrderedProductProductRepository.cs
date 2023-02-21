using EcommerceMVC.Context;
using EcommerceMVC.Interface.IRepository;
using EcommerceMVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace EcommerceMVC.Implementation.Repository
{
    public class OrderedProductRepository : IOrderedProductRepository
    {
        private readonly ApplicationContext _context;
        public OrderedProductRepository(ApplicationContext context)
        {
            _context = context;
        }

        public OrderedProduct Create(OrderedProduct orderedProduct)
        {
            _context.OrderedProduct.Add(orderedProduct);
            _context.SaveChanges();
            return orderedProduct;

        }

        public bool Delete(OrderedProduct orderedProduct)
        {
            _context.OrderedProduct.Remove(orderedProduct);
            _context.SaveChanges();
            return true;
        }

        public IEnumerable<OrderedProduct> GetAllOrderedProduct()
        {
            var orderedProduct = _context.OrderedProduct.ToList();
            return orderedProduct;
        }

        public OrderedProduct GetById(int orderedProductId)
        {
            var orderedProduct = _context.OrderedProduct.SingleOrDefault(x => x.Id == orderedProductId);
            return orderedProduct;
        }

        public OrderedProduct Update(OrderedProduct orderedProduct)
        {
            _context.OrderedProduct.Update(orderedProduct);
            _context.SaveChanges();
            return orderedProduct;
        }
    }
}
