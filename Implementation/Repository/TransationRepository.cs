using System;
using System.Collections.Generic;
using System.Linq;
using EcommerceMVC.Context;
using EcommerceMVC.Interface.IRepository;
using EcommerceMVC.Models;

namespace EcommerceMVC.Implementation.Repository
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly ApplicationContext _context;
        public TransactionRepository(ApplicationContext context)
        {
            _context = context;
        }
        public Transaction Create(Transaction transaction)
        {
            _context.Transactions.Add(transaction);
            _context.SaveChanges();
            return transaction;
        }
        public IEnumerable<Transaction> GetAll()
        {
            var transactions = _context.Transactions.Where(a => a.IsDeleted == false);
            return transactions;
        }

        public IEnumerable<Transaction> GetByCustomerId(int customerId)
        {
            
            var transactions = _context.Transactions.Where(a => a.IsDeleted == false && a.CartId == customerId);
            return transactions;
        }

        public IEnumerable<Transaction> GetByDate(DateTime dateTime)
        {
            var transactions = _context.Transactions.Where(a => a.IsDeleted == false && a.Created.Day == dateTime.Day);
            return transactions;
        }

        public Transaction GetById(int id)
        {
            var transaction = _context.Transactions.SingleOrDefault(a => a.Id == id);
            return transaction;
        }


    }
}