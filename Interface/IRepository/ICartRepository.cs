using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using EcommerceMVC.Models;

namespace EcommerceMVC.Interface.IRepository
{
    public interface ICartRepository
    {
        Cart Create(Cart cart);
        Cart Update(Cart cart);
        bool Delete(Cart cart);
        IList<Cart> GetAllCart(Expression<Func<Cart, bool>> expression);
        Cart Get(Expression<Func<Cart, bool>> expression);
        Cart GetById(int id);
        Cart NotPaidExist(int customerId);
    }
}