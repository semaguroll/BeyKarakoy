﻿using BeyKarakoyWPF.Model;
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
        HttpClient client = new HttpClient();
        public RestAPI()
        {
            client = new HttpClient()
            {
                BaseAddress = new Uri("https://localhost:44309/")
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
                BaseAddress = new Uri("https://localhost:44309/")
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = new HttpResponseMessage();
           
            string json = JsonConvert.SerializeObject(sepet, Formatting.Indented);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            var result = client.PostAsync("api/sepet", content).Result;
        } 
        
        private void GetData()
        {
            GetProducts();
            GetCategories();
        }

    }
}