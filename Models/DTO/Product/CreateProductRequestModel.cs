

using Microsoft.AspNetCore.Http;

namespace EcommerceMVC.Models.DTO.Product
{
    public class CreateProductRequestModel
    {
        public string ProductName {get;set;}
        public double Price {get;set;}
        public int Quantity{get;set;}
        public string Quality{get;set;}
        public IFormFile Image{get;set;}
        //public Guid RefNo {get;set;} = Guid.NewGuid();
        //public bool IsAvailable { get; set; }
    }
}