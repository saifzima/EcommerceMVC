using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using EcommerceMVC.Models;

namespace EcommerceMVC.Interface.IRepository
{
    public interface IOrderedProductRepository
    {
        OrderedProduct Create(OrderedProduct orderedProduct);
        bool Delete(OrderedProduct orderedProduct);
        OrderedProduct GetById(int orderedProductId);

        IEnumerable<OrderedProduct> GetAllOrderedProduct();
        OrderedProduct Update(OrderedProduct orderedProduct);
    }
}