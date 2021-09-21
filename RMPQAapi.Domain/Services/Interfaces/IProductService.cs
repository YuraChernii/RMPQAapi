using RMPQAapi.Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMPQAapi.Domain.Services.Interfaces
{
    public interface IProductService
    {
        Task<object> GetProducts();
    }
}
