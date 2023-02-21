using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMVC.Models
{
    public class DeliveryMan
    {   
        public int Id { get; set; }
        
        public string PlateNumber{get;set;}
        public string DeliveryManId{get;set;}
        public string PassWord{get;set;}
        public string CustomerAddress{get;set;}
        public int UserId{get; set;}
        public User User{get; set;}
    }

}