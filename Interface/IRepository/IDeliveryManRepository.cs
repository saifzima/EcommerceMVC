using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using EcommerceMVC.Models;

namespace EcommerceMVC.Interface.IRepository
{
    public interface IDeliveryManRepository
    {
        DeliveryMan Create(DeliveryMan deliveryMan);
        bool Delete(DeliveryMan deliveryMan);
        IList<DeliveryMan> GetAllDeliveryMan(Expression<Func<DeliveryMan, bool>> expression);
        DeliveryMan Get(Expression<Func<DeliveryMan, bool>> expression);
        DeliveryMan Update(DeliveryMan deliveryMan);
    }
}