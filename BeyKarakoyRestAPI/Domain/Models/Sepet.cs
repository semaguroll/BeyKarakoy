using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeyKarakoyRestAPI.Domain.Models
{
    public class Sepet
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
    }
}
