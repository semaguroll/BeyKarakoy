using BeyKarakoyWPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BeyKarakoyWPF.Data
{
    public class SetProducts : BindableObject
    {
        
        RestAPI api;
        ObservableCollection<ProductModel> myProducts;
        ObservableCollection<SepetModel> mySepet;
        ObservableCollection<CategoryModel> myCategories;
        //ObservableCollection<SepetModel> mySepet;
        public SetProducts()
        {            
            api = new RestAPI();
        }


        public ObservableCollection<ProductModel> GetAllProducts()
        {
            myProducts = new ObservableCollection<ProductModel>();
            foreach (var item in api.GetProducts())
            {
                ProductModel products = new ProductModel()
                {
                    Id = item.Id,
                    ImageSrc = new Uri(item.Image),
                    NameSrc = item.Name,
                    Show = item.Name + " - " + item.Price.ToString(),
                    DescriptionSrc = item.Description,
                    InfoSrc = item.Info,
                    PriceSrc = item.Price
                };
                myProducts.Add(products);

            }
            return myProducts;
        }
        public ObservableCollection<ProductModel> GetFilterProducts(string name)
        {
            myProducts = new ObservableCollection<ProductModel>();
            int search;
            foreach (var item in api.GetProducts())
            {
               search= item.Name.IndexOf(name, 0, item.Name.Length);
                if (search==-1)
                {
                    
                }
                else
                {
                    ProductModel products = new ProductModel()
                    {
                        Id = item.Id,
                        ImageSrc = new Uri(item.Image),
                        NameSrc = item.Name,
                        Show = item.Name + " - " + item.Price.ToString(),
                        DescriptionSrc = item.Description,
                        InfoSrc = item.Info,
                        PriceSrc = item.Price
                    };
                    myProducts.Add(products);
                }
               

            }
            return myProducts;
        }
        public ObservableCollection<SepetModel> GetAllSepet()
        {
            mySepet = new ObservableCollection<SepetModel>();
            foreach (var item in api.GetSepet())
            {
                SepetModel sepet = new SepetModel()
                {
                    Id = item.Id,
                    Image = item.Image,
                    Name = item.Name,
                    Size = item.Size,
                    Count = item.Count,
                    Price = item.Price
                };
                mySepet.Add(sepet);

            }
            return mySepet;
        }

        public ObservableCollection<CategoryModel> GetAllCategories()
        {
            myCategories = new ObservableCollection<CategoryModel>();
            foreach (var item in api.GetCategories())
            {
                CategoryModel categories = new CategoryModel()
                {
                    IdSrc = item.Id,                   
                    NameSrc = item.Name                   
                };
                myCategories.Add(categories);

            }
            return myCategories;
        }
       
    }
}
