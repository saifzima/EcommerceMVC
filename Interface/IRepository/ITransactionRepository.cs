using System;
using System.Collections.Generic;
using EcommerceMVC.Models;

namespace EcommerceMVC.Interface.IRepository
{
    public interface ITransactionRepository
    {
        Transaction Create(Transaction transaction);
        IEnumerable<Transaction> GetAll();
        IEnumerable<Transaction> GetByDate(DateTime dateTime);
        Transaction GetById(int id);
         IEnumerable<Transaction> GetByCustomerId(int customerId);

    }
}