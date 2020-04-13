using BeyKarakoyRestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeyKarakoyRestAPI.Services
{
     public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}
