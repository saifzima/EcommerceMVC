using EcommerceMVC.Interface.Service;
using EcommerceMVC.Models;
using EcommerceMVC.Models.DTO.Admin;
using EcommerceMVC.Models.DTO.Customer;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceMVC.Controllers
{
    public class CustomerController : Controller
    {

        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public IActionResult Index()
        {
            var get = _customerService.GetAll();

            return View(get);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult CreateCustomer(CreateCustomerRequestModel customerRequestModel)
        {
            _customerService.Create(customerRequestModel);
            return RedirectToAction("Login", "User");

        }
        [HttpDelete]
        public IActionResult DeleteCustomer(int id)
        {
            _customerService.Delete(id);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var get = _customerService.GetById(id);
            return View(get);
        }

        public IActionResult Edit(int id)
        {
            var get = _customerService.GetById(id);
            return View(get);
        }
        public IActionResult Edit(CustomerUpdateRequestModel customerUpdateReqestModel, int id)
        {
            _customerService.Update(customerUpdateReqestModel, id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var get = _customerService.GetById(id);
            return View(get);
        }
        public IActionResult GetAllCustomer()
        {
            var get = _customerService.GetAll();
            return View(get);
        }

        // public IActionResult GetAllTransactionByCustomerId(int customerId)
        // {
        //     var get = _customerService.GetAllTransactionByCustomerId(customerId);
        //     return View(get);
        // }
        
        public IActionResult GetAll()
        {
            var list = _customerService.GetAll();
            return View(list);
        }


    }
}
