using BeyKarakoyXamarin.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.Net.Http.Headers;

namespace BeyKarakoyXamarin.Data
{
    public class RestAPI      
    {
        HttpClient client;
        HttpResponseMessage response;
        public List<Product> Products;
        public List<Category> Categories;
        public RestAPI()
        {
            client = new HttpClient()
            {
                BaseAddress = new Uri("http://192.168.1.38/BeyKarakoyRestAPI/")
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            GetData();
        }
        public List<Product> GetProduct()
        {
            HttpResponseMessage response = client.GetAsync("api/products").Result;
             if (response.IsSuccessStatusCode)
            {
                var items = response.Content.ReadAsAsync<IEnumerable<Product>>().Result;
                Products = items as List<Product>;
            }
            //else
            //{                
            //    Application.Current.MainPage.DisplayAlert("Hata", " Error Code:  " /*+ response.IsSuccessStatusCode+"  Message: "+ response.ReasonPhrase*/, "Tamam");
            //}
            return Products;
        }
        private void GetData()
        {
            GetProduct();
        }

















        //private string url = "http://192.168.1.37/BeyKarakoyRestAPI/api/";
        //public async Task<HttpClient> GetClient()
        //{
        //    HttpClient client = new HttpClient();
        //    client.DefaultRequestHeaders.Add("Accept", "application/json");
        //    return client;
        //}
        //public async Task<IEnumerable<Product>> GetImage()
        //{

        //    HttpClient client = await GetClient();
        //    var result = await client.GetStringAsync(url+"products");
        //    var mobileresult= JsonConvert.DeserializeObject<Product>(result);
        //    return JsonConvert.DeserializeObject<IEnumerable<Product>>(mobileresult.Image);
        //}






        //HttpClient client;

        //public List<Product> Item { get; private set; }
        //public RestAPI()
        //{
        //    client = new HttpClient();
        //}
        //public async Task<List<Product>> RefreshDataAsync()
        //{
        //    Item = new List<Product>();

        //    var uri = new Uri("https://localhost:44331/api/products");
        //    try
        //    {
        //        var response = await client.GetAsync(uri);
        //        if (response.IsSuccessStatusCode)
        //        {
        //            var content = await response.Content.ReadAsStringAsync();
        //            Item = JsonConvert.DeserializeObject<List<Product>>(content);
        //        }
        //    }
        //    catch (Exception)
        //    {             
        //    }

        //    return Item;
        //}
    }
}
