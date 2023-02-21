using EcommerceMVC.Interface.Service;
using EcommerceMVC.Models;
using EcommerceMVC.Models.DTO.Customer;
using EcommerceMVC.Models.DTO.OrderedProduct;
using EcommerceMVC.Models.DTO.Product;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceMVC.Controllers
{
    public class OrderedProductController : Controller
    {
       
        private readonly IOrderedProductService _orderedProduct;
        public OrderedProductController(IOrderedProductService orderedProduct)
        {
            _orderedProduct = orderedProduct;
        }

        public IActionResult Index()
        {
            var orderedProduct = _orderedProduct.GetAll();
            return View(orderedProduct);
        }

        public IActionResult Create()
        {
            return View();

        }

        [HttpPost]
        public IActionResult CreateOrderedProduct(CreateOrderedProductRequestModel createOrderedProduct)
        {
            var orderedProduct = _orderedProduct.Create(createOrderedProduct);
            if (orderedProduct.Status == false)
            {
                return View();
            }
            return RedirectToAction("Index");
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _orderedProduct.Delete(id);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var get = _orderedProduct.GetById(id);
            return View(get);
        }
        public IActionResult Edit(OrderedProductUpdateRequestModel orderedProductUpdateReqestModel, int id)
        {
            _orderedProduct.Update(orderedProductUpdateReqestModel, id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var get = _orderedProduct.GetById(id);
            return View(get);
        }
    }
}
