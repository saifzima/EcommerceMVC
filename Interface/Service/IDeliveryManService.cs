using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceMVC.Models.DTO.Admin;
using EcommerceMVC.Models.DTO;
using EcommerceMVC.Models.DTO.DeliveryManDTO;
using EcommerceMVC.Models.DTO.DeliveryMan;

namespace EcommerceMVC.Interface.Service
{
    public interface IDeliveryManService
    {
        DeliveryManResponseModel Create(CreateDeliveryManRequestModel createDeliveryManRequestModel);
        BaseResponse Update(DeliveryManUpdateRequestModel deliveryMan, int DeliveryManId);
        BaseResponse Delete(int DeliveryManId);
        DeliveryManResponseModel GetById(int DeliveryManId);
        DeliveryMansResponseModel GetAll();
    }
}