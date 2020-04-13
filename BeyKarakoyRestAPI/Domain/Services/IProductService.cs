using BeyKarakoyRestAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeyKarakoyRestAPI.Domain.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> ListAsync();
    }
}
