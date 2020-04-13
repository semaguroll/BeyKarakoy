using BeyKarakoyRestAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeyKarakoyRestAPI.Persistance.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly BeyKarakoyContext _context;

        public BaseRepository(BeyKarakoyContext context)
        {
            _context = context;
        }
    }
}
