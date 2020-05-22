
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeyKarakoyRestAPI.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        //public Nullable<byte> Size { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public string Info { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }

       
      
    }
}
