using System.ComponentModel.DataAnnotations;

namespace EcommerceMVC.Models.DTO.OrderedProduct
{
    public class OrderedProductDTO
    {
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public string Quality { get; set; }
        [Required]
        public string OderedProductsId { get; set; }
    }
}
