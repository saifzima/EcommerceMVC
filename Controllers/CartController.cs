using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using EcommerceMVC.Interface.Service;
using EcommerceMVC.Models.DTO.Transation;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceMVC.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartService _cartService;
        private readonly IProductService _productService;
        public CartController(ICartService cartService, IProductService productService)
        {
           _cartService = cartService;
           _productService = productService;
        }
        public IActionResult AddCart(int productId)
        {
             var get = _productService.GetById(productId);
            return View(get);
        }
        public IActionResult AddToCart(CreateTransationRequestModel createTransationRequestModel)
        {
            var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            createTransationRequestModel.UserId = int.Parse(user);
            var cart = _cartService.Create(createTransationRequestModel);
            TempData["Message"] = cart.Message;
            return RedirectToAction("DisplayProducts", "Product");
        }
        public IActionResult GetCartByCustomer()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var get = _cartService.GetCartByCustomer(int.Parse(userId));
            return View(get);
        }
    }
}