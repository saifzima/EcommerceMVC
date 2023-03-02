using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using EcommerceMVC.Interface.Service;
using EcommerceMVC.Models.DTO.Cart;
using EcommerceMVC.Models.DTO.Transation;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceMVC.Controllers
{
    public class CartController : Controller
    {
        private readonly ITransactionService _transactionService;
        private readonly ICartService _cartService;
        private readonly IProductService _productService;
        public CartController(ICartService cartService, IProductService productService,ITransactionService transactionService)
        {
           _cartService = cartService;
           _productService = productService;
           _transactionService = transactionService;
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
        public IActionResult GetAllTransactionInCart(int id)
        {
           var transactions= _cartService.GetAllTransactionInCart(id);
            return View(transactions);
        }
        public IActionResult Reciept(int id)
        {
           var transactions= _cartService.GetAllTransactionInCart(id);
            return View(transactions);
        }
        public IActionResult MakePayment(int id)
        {
           var transactions= _cartService.MakePayment(id);
            return RedirectToAction("GetCartByCustomer");
        }

      
        public IActionResult Edit(int id)
        {
            var get = _transactionService.GetById(id);
            return View(get);
        }

       
        public IActionResult EditTransactionInCart(TransactionUpdateRequestModel transaction)
        {
            var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            transaction.Id = int.Parse(user);
            _cartService.UpdateTransaction(transaction);
           return RedirectToAction("DisplayProducts", "Product");
        }
       
    }
}