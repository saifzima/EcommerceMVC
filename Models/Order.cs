using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMVC.Models
{
    public class Order
    {
        public int Id {get;set;}
        public List<OrderedProduct> OderedProducts = new List<OrderedProduct>();
    }
}