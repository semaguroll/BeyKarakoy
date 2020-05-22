using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BeyKarakoyXamarin.Models
{
    public class MyProducts
    {
        //private UriImageSource imagesrc;
        public Uri ImageSrc { get; set; }
        //public UriImageSource ImageSrc
        //{
        //    get { return imagesrc; }
        //    set { imagesrc = value; }
        //}
        private string namesrc;
        public string NameSrc
        {
            get { return namesrc; }
            set { namesrc = value; }
        }
    }
}
