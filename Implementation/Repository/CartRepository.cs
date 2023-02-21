using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using EcommerceMVC.Context;
using EcommerceMVC.Interface.IRepository;
using EcommerceMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceMVC.Implementation.Repository
{
    public class CartRepository : ICartRepository
    {
        private readonly ApplicationContext _context;
        public CartRepository(ApplicationContext context)
        {
            _context = context;
        }

        public Cart Create(Cart cart)
        {
            _context.Carts.Add(cart);
            _context.SaveChanges();
            return cart;
        }

        public bool Delete(Cart cart)
        {
            _context.Carts.Update(cart);
            _context.SaveChanges();
            return true;
        }

        public Cart Get(Expression<Func<Cart, bool>> expression)
        {
             var get = _context.Carts.Include(x => x.Customer).FirstOrDefault(expression);
            return get;
        }

        public IList<Cart> GetAllCart(Expression<Func<Cart, bool>> expression)
        {
            var getAllCart = _context.Carts.Include(_ => _.Customer).Where(expression).ToList();
            return getAllCart;
        }

        public Cart GetById(int id)
        {
             var carts = _context.Carts.SingleOrDefault(x => !x.IsPaid && !x.IsDeleted && x.Id == id);
            return carts;
        }

        public Cart NotPaidExist(int customerId)
        {
             var carts = _context.Carts.FirstOrDefault(x => !x.IsPaid && !x.IsDeleted && x.Id == customerId);
            return carts;

        }

        public Cart Update(Cart cart)
        {
            _context.Carts.Update(cart);
            _context.SaveChanges();
            return cart;
        }
    }
}