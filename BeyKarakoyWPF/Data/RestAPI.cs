using BeyKarakoyWPF.Model;
using DocumentFormat.OpenXml.Office.CustomUI;
using DocumentFormat.OpenXml.Spreadsheet;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BeyKarakoyWPF.Data
{
    public class RestAPI
    {
        private List<Products> Products;
        private List<Sepett> Sepet;
        private List<Categories> Categories;
        private List<User> Users;

        HttpClient client = new HttpClient();
        public RestAPI()
        {
            client = new HttpClient()
            {
                BaseAddress = new Uri("https://localhost:44366/")
            };
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            GetData();
        }
        public List<Categories> GetCategories()
        {  
            HttpResponseMessage response = client.GetAsync("api/categories").Result;
            if (response.IsSuccessStatusCode)
            {
                var items = response.Content.ReadAsAsync<IEnumerable<Categories>>().Result;
                Categories = items as List<Categories>;
            }
            return Categories;
        }
        public List<Products> GetProducts()
        {
            HttpResponseMessage response = client.GetAsync("api/products").Result;
            if (response.IsSuccessStatusCode)
            {
                var items = response.Content.ReadAsAsync<IEnumerable<Products>>().Result;
                Products = items as List<Products>;
            }
            return Products;
        }
        public List<User> GetUsers()
        {
            HttpResponseMessage response = client.GetAsync("api/users").Result;
            if (response.IsSuccessStatusCode)
            {
                var items = response.Content.ReadAsAsync<IEnumerable<User>>().Result;
                Users = items as List<User>;
            }
            return Users;
        }
        public List<Sepett> GetSepet()
        {
            HttpResponseMessage response = client.GetAsync("api/sepet").Result;
            if (response.IsSuccessStatusCode)
            {
                var items = response.Content.ReadAsAsync<IEnumerable<Sepett>>().Result;
                Sepet = items as List<Sepett>;
            }
            return Sepet;
        }
        public void PostSepet(Sepett sepet)
        {
            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri("https://localhost:44366/")
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = new HttpResponseMessage();
           
            string json = JsonConvert.SerializeObject(sepet, Formatting.Indented);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            var result = client.PostAsync("api/sepet", content).Result;
        }

        public void DeleteSepetItem(int id)
        {
            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri("https://localhost:44366/")
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = new HttpResponseMessage();
            string deleteUri = "api/sepet/" + id.ToString();
            var result = client.DeleteAsync(deleteUri).Result;
        }
        public void PutUser( UsersModel user,int id)
        {
            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri("https://localhost:44366/")
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            string json = JsonConvert.SerializeObject(user, Formatting.Indented);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            string putUri = "api/users/" + id.ToString();
            var result = client.PutAsync(putUri, content).Result;
        }
        public void PostUser(User user)
        {
            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri("https://localhost:44366/")
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = new HttpResponseMessage();

            string json = JsonConvert.SerializeObject(user, Formatting.Indented);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            var result = client.PostAsync("api/users", content).Result;
        }
        public void DeleteOneUser(int id)
        {
            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri("https://localhost:44366/")
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = new HttpResponseMessage();
            string deleteUri = "api/users/" + id.ToString();
            var result = client.DeleteAsync(deleteUri).Result;
        }
            

        private void GetData()
        {
            GetProducts();
            GetCategories();
        }

    }
}
