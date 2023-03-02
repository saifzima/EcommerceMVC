using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using EcommerceMVC.Models;
using EcommerceMVC.Models.DTO.Admin;
using EcommerceMVC.Models.DTO.Customer;
using EcommerceMVC.Models.DTO;

namespace EcommerceMVC.Interface.IRepository
{
    public interface ICustomerRepository
    {
        Customers Create(Customers customer);
        bool Delete(Customers customer);
        IList<Customers> GetAllCustomer(Expression<Func<Customers, bool>> expression);
        Customers Get(Expression<Func<Customers, bool>> expression);
        Customers GetCustomerById(int id);
        Customers Update(Customers customer);
        double GetBalance();
    }
}