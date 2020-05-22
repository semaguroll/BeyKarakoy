using BeyKarakoyXamarin.Data;
using BeyKarakoyXamarin.Models;
using BeyKarakoyXamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BeyKarakoyXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Anasayfa : ContentPage
    {
        //RestAPI api = new RestAPI();
        ItemModel model;

        public Anasayfa()
        {
            InitializeComponent();

            List<string> SliderItems = new List<string>()
            {
                "main1.png",
                "main2.png"
            };

            MainSlider.ItemsSource = SliderItems;
           model = new ItemModel(this);
            listdata.FlowItemsSource = new ItemModel(this).GetNumberofItems(4);

        }
    }
}