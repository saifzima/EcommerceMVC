using EcommerceMVC.Models.DTO;
using EcommerceMVC.Models.DTO.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMVC.Interface.Service
{
    public interface IUserService
    {
        CreateUserRequestModel Create(CreateUserRequestModel user);
        UserResponseModel Login(UserLoginReqestModel user);
        BaseResponse Delete(string email);
        UsersResponseModel GetById(string email);
        UpdateUserPasswordRequestModel UpdatePassword(UpdateUserPasswordRequestModel updateUserPasswordRequestModel);
        UserRoleUpdateRequestModel UpdateRole(UserRoleUpdateRequestModel updateUserPasswordRequestModel);
    }
}