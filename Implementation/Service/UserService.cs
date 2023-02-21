using EcommerceMVC.Enums;
using EcommerceMVC.Implementation.Repository;
using EcommerceMVC.Interface.IRepository;
using EcommerceMVC.Interface.Service;
using EcommerceMVC.Models;
using EcommerceMVC.Models.DTO;
using EcommerceMVC.Models.DTO.Admin;
using EcommerceMVC.Models.DTO.User;
using Org.BouncyCastle.Bcpg.Sig;
using System;

namespace EcommerceMVC.Implementation.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository user)
        {
            _userRepository = user;
        }

        public CreateUserRequestModel Create(CreateUserRequestModel user)
        {
            var users = new User
            {
                Password = user.Password,
                Email = user.Email,
                Role = user.Role,
                Created = DateTime.Now,
            };
            _userRepository.Create(users);
            return user;
        }

        public BaseResponse Delete(string email)
        {
            var user = _userRepository.GetById(email);
            _userRepository.Delete(user);
            return new BaseResponse
            {
                Message = " deleted successfully",
                Status = true
            };
        }

        public UsersResponseModel GetById(string email)
        {
            var get = _userRepository.GetById(email);
            if (get == null)
            {
                return new UsersResponseModel
                {
                    Status = false,
                    Message = "Failed to fetch",
                };
            }
            return new UsersResponseModel
            {
                Message = "Successfully fetch",
                Status = true
            };
        }

        public UserResponseModel Login(UserLoginReqestModel userLoginReqestModel)
        {

            var user = _userRepository.Login(userLoginReqestModel.Email, userLoginReqestModel.Password);
            if(user != null)
            {
                return new UserResponseModel
                {
                    Status = true,
                    Data = new UserDTO
                    {
                        Id = user.Id,
                        Email= userLoginReqestModel.Email,
                        Role = user.Role
                    },
                    Message = "Successfully logged in"
                };
            }
            return new UserResponseModel
            {
                Status = false,
                Message = "Invalid credentials"
            };
        }

        public UpdateUserPasswordRequestModel UpdatePassword(UpdateUserPasswordRequestModel updateUserPasswordRequestModel)
        {
            throw new System.NotImplementedException();
        }

        public UserRoleUpdateRequestModel UpdateRole(UserRoleUpdateRequestModel updateUserPasswordRequestModel)
        {
            throw new System.NotImplementedException();
        }
    }
}
