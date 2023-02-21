using EcommerceMVC.Enums;
using EcommerceMVC.Interface.IRepository;
using EcommerceMVC.Interface.Service;
using EcommerceMVC.Models;
using EcommerceMVC.Models.DTO;
using EcommerceMVC.Models.DTO.Admin;
using EcommerceMVC.Models.DTO.Customer;
using EcommerceMVC.Models.DTO.Transation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace EcommerceMVC.Implementation.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IUserRepository _usersRepository;
        private readonly ITransactionRepository _transaction;

        public CustomerService(ICustomerRepository customer, IUserRepository user, ITransactionRepository transaction)
        {
            _customerRepository = customer;
            _usersRepository = user;
            _transaction = transaction;
        }

        public CustomerResponseModel Create(CreateCustomerRequestModel createCustomerRequestModel)
        {
            var users = new User
            {
                FirstName = createCustomerRequestModel.FirstName,
                LastName = createCustomerRequestModel.LastName,
                Email = createCustomerRequestModel.Email,
                PhoneNumber = createCustomerRequestModel.PhoneNumber,
                Password = createCustomerRequestModel.Password,
                Created = DateTime.Now,
                Role = UserRoleType.Customer,
            };
            var addedUser = _usersRepository.Create(users);
            var customer = new Customers
            {
                Address = createCustomerRequestModel.Address,
                UserId = addedUser.Id,
            };
            var createCustomer = _customerRepository.Create(customer);
            if (createCustomer == null)
            {
                return new CustomerResponseModel
                {
                    Message = "failed to create",
                    Status = false,
                };
            }
            return new CustomerResponseModel
            {
                Data = new CustomerDTO
                {
                    FirstName = createCustomer.User.FirstName,
                    LastName = createCustomer.User.LastName,
                    Email = createCustomer.User.Email,
                    PhoneNumber = createCustomer.User.PhoneNumber,
                    Address = createCustomer.Address,
                },
                Message = "Successfully Created",
                Status = true,
            };

        }

        public BaseResponse Delete(int CustomerId)
        {
            var getCustomer = _customerRepository.Get(x => x.Id == CustomerId);
            if (getCustomer == null)
            {
                return new BaseResponse
                {
                    Message = "Customer does not exist",
                    Status = false,
                };
            }
            var deleteProduct = _customerRepository.Delete(getCustomer);
            return new BaseResponse
            {
                Message = "deleted",
                Status = true
            };
        }

        public CustomersResponseModel GetAll()
        {
            var get = _customerRepository.GetAllCustomer(x => true);
            if (get == null)
            {
                return new CustomersResponseModel
                {
                    Status = false,
                    Message = "Failed to fetch",
                };
            }
            return new CustomersResponseModel
            {
                Message = "Successfully fetch",
                Status = true,
                Data = get.Select(x => new CustomerDTO
                {
                    FirstName = x.User.FirstName,
                    LastName = x.User.LastName,
                    Email = x.User.Email,
                    PhoneNumber = x.User.PhoneNumber,
                    Address = x.Address,
                }).ToList(),

            };
        }

        public CustomerResponseModel GetById(int customerId)
        {
            var get = _customerRepository.Get(x => x.Id == customerId);
            if (get == null)
            {
                return new CustomerResponseModel
                {
                    Status = false,
                    Message = "Failed to fetch",
                };
            }
            return new CustomerResponseModel
            {
                Message = "Successfully fetch",
                Status = true
            };
        }
        public BaseResponse Update(CustomerUpdateRequestModel customer, int CustomerId)
        {
            var get = _customerRepository.Get(x => x.Id == CustomerId);

            if (get == null)
            {
                return new BaseResponse
                {
                    Message = "failed to Update",
                    Status = false,
                };
            }
            get.User.FirstName = customer.FirstName;
            get.User.LastName = customer.LastName;
            get.User.Email = customer.Email;
            get.Address = customer.Address;
            _customerRepository.Update(get);

            return new BaseResponse
            {
                Message = "successfully Updated",
                Status = true,
            };
        }

    }
}





