using EcommerceMVC.Context;
using EcommerceMVC.Enums;
using EcommerceMVC.Interface.IRepository;
using EcommerceMVC.Models;
using System.Linq;

namespace EcommerceMVC.Implementation.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationContext _context;
        public UserRepository(ApplicationContext context)
        {
            _context = context;
        }

        public User Create(User users)
        {
            _context.Users.Add(users);
            _context.SaveChanges();
            return users;
        }

        public void Delete(User users)
        {
            _context.Users.Remove(users);
            _context.SaveChanges();
        }

        public User GetById(string email)
        {
            var user = _context.Users.SingleOrDefault(x => x.Email == email);
            return user;
        }

        public User Login(string email, string password)
        {
            var userr = _context.Users.FirstOrDefault(a => a.Email == email && a.Password == password);
            return userr;
        }

        public User UpdatePassword(User users)
        {
            _context.Users.Update(users);
            _context.SaveChanges();
            return users;
        }

        public User UpdateRole(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
            return user;
        }
    }
}
