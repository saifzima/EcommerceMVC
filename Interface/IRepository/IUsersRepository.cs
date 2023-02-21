using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceMVC.Models;

namespace EcommerceMVC.Interface.IRepository
{
    public interface IUserRepository
    {
        User Create(User users);
        User Login(string email, string password);
        void Delete(User users);
        User GetById(string email);
        User UpdatePassword(User users);
        User UpdateRole(User user);
    }
}