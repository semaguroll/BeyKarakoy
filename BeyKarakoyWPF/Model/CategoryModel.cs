using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeyKarakoyWPF.Model
{
    public class CategoryModel
    {
        public int IdSrc { get; set; }
        public string NameSrc { get; set; }
        public override string ToString()
        {
            return NameSrc;
        }
    }
}
