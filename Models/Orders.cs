using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMVC.Models
{
    public class Orders
    {
        public int Id{get;set;}
        public List<OrderedProduct> orderedProducts =  new List<OrderedProduct>();
 
    }
}