using System.ComponentModel.DataAnnotations;

namespace EcommerceMVC.Models.DTO.OrderedProduct
{
    public class OrderedProductUpdateRequestModel
    {
        [Required]
        public string ProductName { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public string Quality { get; set; }
    }
}
