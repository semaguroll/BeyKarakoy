using BeyKarakoyXamarin.Data;
using BeyKarakoyXamarin.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace BeyKarakoyXamarin.ViewModels
{
    public class ItemModel : BindableObject
    {
        private Page mainPage;
        RestAPI api;
        public ItemModel(Page mainPage)
        {
            this.mainPage = mainPage;
            api = new RestAPI();

        }

        //private void AddItems()
        //{
        //    for (int i = 1; i < 5; i++)
        //    {
        //        MyProducts products = new MyProducts()
        //        {
        //            ImageSrc = "https://cdn.shopify.com/s/files/1/1432/5782/products/P4170481_grande.jpg?v=1587402041",
        //            NameSrc = "Deneme"                   
        //        };
        //        Items.Add(products);
        //    }
        //        //Items.Add(string.Format("List Item at {0}", i));
        //}

        public ObservableCollection<MyProducts> GetNumberofItems(int numberofItem)
        {
            ObservableCollection<MyProducts> items = new ObservableCollection<MyProducts>();
            foreach (var item in api.GetProduct())
            {
                MyProducts products = new MyProducts()
                {
                    ImageSrc = new Uri(item.Image),
                    NameSrc = item.Name
                };
                items.Add(products);
                if(items.Count==numberofItem){
                    break;
                }
            }
            return items;
        }
        public ObservableCollection<MyProducts> GetAllItems()
        {
            ObservableCollection<MyProducts> items = new ObservableCollection<MyProducts>();
            foreach (var item in api.GetProduct())
            {
                MyProducts products = new MyProducts()
                {
                    ImageSrc = new Uri(item.Image),                   
                NameSrc = item.Name
                };
                items.Add(products);
            }
            return items;
        }


    }
}
