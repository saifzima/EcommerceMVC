using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceMVC.Models;

namespace EcommerceMVC.Interface.IRepository
{
    public interface IWalletRepository
    {
        Wallet Create(Wallet wallet);
        double GetBalance();
        Wallet Credit (Wallet wallet);
        Wallet Debit (Wallet wallet);
        Wallet GetWallet(int customerId);
    }
}