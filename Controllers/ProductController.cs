using System.Security.Claims;
using EcommerceMVC.Implementation.Service;
using EcommerceMVC.Interface.Service;
using EcommerceMVC.Models.DTO.Admin;
using EcommerceMVC.Models.DTO.Product;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var product = _productService.GetAll();
            return View(product);
        }
        public IActionResult DisplayProducts()
        {
            var product = _productService.GetAll();
            return View(product);
        }
        public IActionResult Create()
        {
            return View();

        }

        [HttpPost]
        public IActionResult CreateProduct(CreateProductRequestModel createProduct)
        {
            var createproducts = _productService.Create(createProduct);
            if (createproducts.Status == false)
            {
                return View();
            }
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            _productService.Delete(id);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var get = _productService.GetById(id);
            return View(get);
        }
        public IActionResult EditProduct(ProductUpdateRequestModel productUpdateReqestModel)
        {
            _productService.Update(productUpdateReqestModel);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Detail(int id)
        {
            var get = _productService.GetById(id);
            return View(get);
        }
        public IActionResult Buy(int productId)
        {
            var get = _productService.GetById(productId);
            return View(get);
        }
        
        [HttpPost]
        public IActionResult BuyProduct(BuyRequestModel buyRequest)
        {
            var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var buyProducts = _productService.BuyProduct(buyRequest, int.Parse(user));
            TempData["Message"] = buyProducts.Message;
            return RedirectToAction("DisplayProducts");
        }
        public IActionResult ViewCartByCustomer(ViewRecipt viewRecipt)
        {
            var user = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var viewRecipts = _productService.ViewCartByCustomer(viewRecipt,int.Parse(user));
            TempData["Message"] = viewRecipts.Message;
           // return RedirectToAction("DisplayProducts");
            return View(user);
        }
      
    }
}
