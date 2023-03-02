using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceMVC.Models;

namespace EcommerceMVC.Interface.IRepository
{
    public interface IProductRepository
    {
        Product Create(Product product);
        bool Delete(Product product);
        Product GetById(int productId);
        IEnumerable<Product> GetAllProduct();
        Product Update(Product product);
    }
}