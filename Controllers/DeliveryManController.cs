using EcommerceMVC.Interface.Service;
using EcommerceMVC.Models.DTO.DeliveryMan;
using EcommerceMVC.Models.DTO.DeliveryManDTO;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceMVC.Controllers
{
    public class DeliveryManController : Controller
    {
        private readonly IDeliveryManService _deliveryManService;
        public DeliveryManController(IDeliveryManService deliveryManService)
        {
            _deliveryManService = deliveryManService;
        }
        public IActionResult Index()
        {
            var get = _deliveryManService.GetAll();

            return View(get);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult CreateDeliveryMan(CreateDeliveryManRequestModel deliveryManRequestModel)
        {
            _deliveryManService.Create(deliveryManRequestModel);
            return RedirectToAction("Index");
        }
        [HttpDelete]
        public IActionResult DeleteDeliveryMan(int id)
        {
            _deliveryManService.Delete(id);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var get = _deliveryManService.GetById(id);
            return View(get);
        }

        public IActionResult Edit(int id)
        {
            var get = _deliveryManService.GetById(id);
            return View(get);
        }
        public IActionResult Edit(DeliveryManUpdateRequestModel deliveryManUpdateReqestModel, int id)
        {
            _deliveryManService.Update(deliveryManUpdateReqestModel, id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var get = _deliveryManService.GetById(id);
            return View(get);
        }
        public IActionResult GetDeliveryMan()
        {
            var get = _deliveryManService.GetAll();
            return View(get);
        }
        public IActionResult GetAll()
        {
            var list = _deliveryManService.GetAll();
            return View(list);
        }
        /* public IActionResult Index()
         {
             var get = _deliveryMan.GetAll();

             return View(get);
         }
         public IActionResult Create()
         {
             return View();
         }
         public IActionResult CreateAdmin(CreateDeliveryManRequestModel deliveryManRequestModel)
         {
             _deliveryMan.Create(deliveryManRequestModel);
             return RedirectToAction("Index");
         }
         [HttpDelete]
         public IActionResult Delete(int id)
         {
             _deliveryMan.Delete(id);
             return RedirectToAction("Index");
         }
         public IActionResult Edit(int id)
         {
             var get = _deliveryMan.GetById(id);
             return View(get);
         }
         public IActionResult Edit(DeliveryManUpdateRequestModel deliveryManUpdateRequestModel, int id)
         {
             _deliveryMan.Update(deliveryManUpdateRequestModel, id);
             return RedirectToAction("Index");
         }
         [HttpGet]
         public IActionResult Details(int id)
         {
             var get = _deliveryMan.GetById(id);
             return View(get);
        }
         */

    }
}
