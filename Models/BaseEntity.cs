using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMVC.Models
{
    public abstract class  BaseEntity
    {
        public bool IsDeleted { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}