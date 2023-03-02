using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EcommerceMVC.Models;

namespace EcommerceMVC.Interface.IRepository
{
    public interface ITransactionRepository
    {
        Transaction Create(Transaction transaction);
        IEnumerable<Transaction> GetAll();
        IEnumerable<Transaction> GetByDate(DateTime dateTime);
        IList<Transaction>GetAllTransaction(Expression<Func<Transaction, bool>> expression);
        Transaction GetById(int id);
        IEnumerable<Transaction> GetByCustomerId(int customerId);
        Transaction Update(Transaction transaction);
    }
}