using EcommerceMVC.Context;
using EcommerceMVC.Interface.IRepository;
using EcommerceMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace EcommerceMVC.Implementation.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationContext _context;
        public CustomerRepository(ApplicationContext context) 
        {
            _context = context;
        }

        public Customers Create(Customers customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return customer;
        }

        public bool Delete(Customers customer)
        {
            _context.Customers.Remove(customer);
            _context.SaveChanges();
            return true;
        }

        public Customers Get(Expression<Func<Customers, bool>> expression)
        {
            var get = _context.Customers.Include(x => x.User).FirstOrDefault(expression);
            return get;
        }

        public IList<Customers> GetAllCustomer(Expression<Func<Customers, bool>> expression)
        {
            var getAllCustomer = _context.Customers.Include(_ => _.User).Where(expression).ToList();
            return getAllCustomer;
        }

        public double GetBalance()
        {
             var balance = _context.Wallets.Sum(x => (x.Credit - x.Debit));
            return balance;     
        }
        public Customers GetCustomerById(int id)
        {
            var get = _context.Customers.Include(a=>a.User).SingleOrDefault(e=>e.Id==id);
            return get;
        }

        public Customers Update(Customers customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
            return customer;
        }

        public Customers UpdatePassword(Customers customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
            return customer;
        }
    }
}
