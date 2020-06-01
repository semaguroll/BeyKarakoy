using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyKarakoyWPF.Model
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public string Info { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public int StockCount { get; set; }
    }
}
