using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BeyKarakoyWPF.Model
{
    public class ProductModel
    {
        public int Id { get; set; }
        //public ItemTappedEventArgs e { get; set; }
        public Uri ImageSrc { get; set; }
        public string NameSrc { get; set; }
        public string Show { get; set; }
        public string DescriptionSrc { get; set; }
        public string InfoSrc { get; set; }
        public int PriceSrc { get; set; }
        //private int SelectedItem { get; set; }
        //public int SelectedItemSrc {
        //    get { return SelectedItem; }
        //    set
        //    {
        //        if (SelectedItem!=value)
        //        {
        //            SelectedItem = value;
        //        }
        //    } 
        //}
    }
}
