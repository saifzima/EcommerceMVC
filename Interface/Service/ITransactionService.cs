using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceMVC.Models.DTO.Transation;

namespace EcommerceMVC.Interface.Service
{
    public interface ITransactionService
    {
        void Delete(int Id);
        IEnumerable<TransationResponseModel>GetAll();
        TransationResponseModel GetById(int Id);
        
    }
} 