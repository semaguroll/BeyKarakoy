using BeyKarakoyRestAPI.Domain.Models;
using BeyKarakoyRestAPI.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeyKarakoyRestAPI.Services
{
    public class ProductServiceFake 
    {
        private readonly List<Product> _shoppingCart;

        public ProductServiceFake()
        {
            _shoppingCart = new List<Product>()
            {
                new Product() { Id = 40,
                    Name = "Orange Juice",  Price = 9 },
                new Product() { Id =30 ,
                    Name = "Diary Milk", Price = 7},
                new Product() { Id = 20 ,
                    Name = "Frozen Pizza", Price = 5}
            };
        }

        public IEnumerable<Product> GetAllItems()
        {
            return _shoppingCart;
        }

        //public Product Add(Product newItem)
        //{
        //    newItem.Id = new int();
        //    _shoppingCart.Add(newItem);
        //    return newItem;
        //}

        //public Product GetById(int id)
        //{
        //    return _shoppingCart.Where(a => a.Id == id)
        //        .FirstOrDefault();
        //}

        //public void Remove(int id)
        //{
        //    var existing = _shoppingCart.First(a => a.Id == id);
        //    _shoppingCart.Remove(existing);
        //}
    }
}
