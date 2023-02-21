using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceMVC.Models;
using EcommerceMVC.Models.DTO;
using EcommerceMVC.Models.DTO.Admin;

namespace EcommerceMVC.Interface.Service
{
    //public interface IAdminService
    //{
    //    AdminResponseModel Create(CreateAdminRequestModel admin);
    //    BaseResponse Update(AdminUpdateRequestModel admin,int AdminId);
    //    BaseResponse Delete(int AdminId);
    //    AdminResponseModel GetById(int AdminId);
    //    AdminsResponseModel GetAll();
    //}

    public interface IAdminService
    {
        AdminResponseModel Create(CreateAdminRequestModel admin);
        BaseResponse Update(AdminUpdateRequestModel admin, int AdminId);
        BaseResponse Delete(int AdminId);
        AdminsResponseModel GetAllAdmin();
    }
   

}