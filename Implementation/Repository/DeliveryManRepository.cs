using EcommerceMVC.Context;
using EcommerceMVC.Interface.IRepository;
using EcommerceMVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace EcommerceMVC.Implementation.Repository
{
    public class DeliveryManRepository : IDeliveryManRepository
    {
        private readonly ApplicationContext _context;
        public DeliveryManRepository(ApplicationContext context)
        {
            _context = context;
        }

        public DeliveryMan Create(DeliveryMan deliveryMan)
        {
            _context.DeliveryMan.Add(deliveryMan);
            _context.SaveChanges();
            return deliveryMan;
        }

        public bool Delete(DeliveryMan deliveryMan)
        {
            _context.DeliveryMan.Remove(deliveryMan);
            _context.SaveChanges();
            return true;
        }

        public DeliveryMan Get(Expression<Func<DeliveryMan, bool>> expression)
        {
            var get = _context.DeliveryMan.Include(x => x.User).FirstOrDefault(expression);
            return get;
        }

        public IList<DeliveryMan> GetAllDeliveryMan(Expression<Func<DeliveryMan, bool>> expression)
        {
            var getAllDeliveryMan = _context.DeliveryMan.Include(_ => _.User).Where(expression).ToList();
            return getAllDeliveryMan;
        }

        public DeliveryMan Update(DeliveryMan deliveryMan)
        {
            _context.DeliveryMan.Update(deliveryMan);
            _context.SaveChanges();
            return deliveryMan;
        }
    }
}
