using EcommerceMVC.Enums;
using EcommerceMVC.Interface.IRepository;
using EcommerceMVC.Interface.Service;
using EcommerceMVC.Models;
using EcommerceMVC.Models.DTO;
using EcommerceMVC.Models.DTO.Admin;
using EcommerceMVC.Models.DTO.DeliveryMan;
using EcommerceMVC.Models.DTO.DeliveryManDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMVC.Implementation.services
{
    public class DeliveryManService : IDeliveryManService
    {
        private readonly IDeliveryManRepository _deliveryManRepository;
        private readonly IUserRepository _usersRepository;
        public DeliveryManService(IDeliveryManRepository deliveryManRepository, IUserRepository usersRepository)
        {
            _deliveryManRepository = deliveryManRepository;
            _usersRepository = usersRepository;
        }

        public DeliveryManResponseModel Create(CreateDeliveryManRequestModel createDeliveryManRequestModel)
        {
            var users = new User
            {
                Password = createDeliveryManRequestModel.PassWord,
                Created = DateTime.Now,
                Role = UserRoleType.Admin,
            };
            _usersRepository.Create(users);
            var deliveryMan = new DeliveryMan
            {

               
                PlateNumber = createDeliveryManRequestModel.PlateNumber,
                CustomerAddress =   createDeliveryManRequestModel.CustomerAddress,

                UserId = users.Id,
            };
            var createDeliveryMan = _deliveryManRepository.Create(deliveryMan);
            if (createDeliveryMan == null)
            {
                return new DeliveryManResponseModel
                {
                    Message = "failed to create",
                    Status = false,
                };
            }
            return new DeliveryManResponseModel
            {
                Data = new DeliveryManDTO
                {
                    FirstName = createDeliveryMan.User.FirstName,
                    LastName = createDeliveryMan.User.LastName,
                    Email = createDeliveryMan.User.Email,
                    PhoneNumber = createDeliveryMan.User.PhoneNumber,
                    PlateNumber= createDeliveryMan.PlateNumber,
                    CustomerAddress = createDeliveryMan.CustomerAddress,
                },
                Message = "Successfully Created",
                Status = true,
            };
        }

        public BaseResponse Delete(int DeliveryManId)
        {
            var getDeliveryMan = _deliveryManRepository.Get(x => x.Id == DeliveryManId);
            if (getDeliveryMan == null)
            {
                return new BaseResponse
                {
                    Message = "DeliveryMan does not exist",
                    Status = false,
                };
            }
            var deleteDeliveryMan = _deliveryManRepository.Delete(getDeliveryMan);
            return new BaseResponse
            {
                Message = "deleted",
                Status = true
            };
        }

        public DeliveryMansResponseModel GetAll()
        {
            var getAll = _deliveryManRepository.GetAllDeliveryMan(x => true);
            if (getAll == null)
            {
                return new DeliveryMansResponseModel
                {
                    Message = "failed to fetch",
                    Status = false,
                };
            }
            return new DeliveryMansResponseModel
            {
                Message = "successfully fetched",
                Status = true,
                Data = getAll.Select(x => new DeliveryManDTO
                {
                    FirstName = x.User.FirstName,
                    LastName = x.User.LastName,
                    PhoneNumber = x.User.PhoneNumber,
                    Email = x.User.Email,
                    CustomerAddress = x.CustomerAddress,
                }).ToList()
            };
        }

        public DeliveryManResponseModel GetById(int DeliveryManId)
        {
            var get = _deliveryManRepository.Get(x => x.Id == DeliveryManId);
            if (get == null)
            {
                return new DeliveryManResponseModel
                {
                    Status = false,
                    Message = "Failed to fetch",
                };
            }
            return new DeliveryManResponseModel
            {
                Message = "Successfully fetch",
                Status = true
            };
        }

        public BaseResponse Update(DeliveryManUpdateRequestModel deliveryMan, int DeliveryManId)
        {
            var get = _deliveryManRepository.Get(x => x.Id == DeliveryManId);

            if (get == null)
            {
                return new BaseResponse
                {
                    Message = "failed to Update",
                    Status = false,
                };
            }
            get.User.FirstName = deliveryMan.FirstName;
            get.User.LastName = deliveryMan.LastName;
            get.User.Email = deliveryMan.Email;
            get.CustomerAddress = deliveryMan.CustomerAddress;
            get.PassWord = deliveryMan.PassWord;
            get.User.PhoneNumber= deliveryMan.PhoneNumber;
            _deliveryManRepository.Update(get);

            return new BaseResponse
            {
                Message = "successfully Updated",
                Status = true,
            };
        }
    }
}