using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceMVC.Context;
using EcommerceMVC.Interface.IRepository;
using EcommerceMVC.Models;

namespace EcommerceMVC.Implementation.Repository
{
    public class WalletRepository : IWalletRepository
    {
        private readonly ApplicationContext _context;
        public WalletRepository(ApplicationContext context)
        {
            _context = context;
        }

        public Wallet Create(Wallet wallet)
        {
           _context.Wallets.Add(wallet);
            _context.SaveChanges();
            return wallet;
        }

        public Wallet Credit(Wallet wallet)
        {
            _context.Wallets.Add(wallet);
            _context.SaveChanges();
            return wallet;        }

        public Wallet Debit(Wallet wallet)
        {
            _context.Wallets.Add(wallet);
            _context.SaveChanges();
            return wallet;        }

        public double GetBalance()
        {
            var balance = _context.Wallets.Sum(x => (x.Credit - x.Debit));
            return balance;        
        }

        public Wallet GetWallet(int customerId)
        {
            var wallet = _context.Wallets.FirstOrDefault(w => w.CustomerId == customerId);
            return wallet;
        }
    }
}