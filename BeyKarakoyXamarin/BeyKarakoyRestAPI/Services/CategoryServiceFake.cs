using BeyKarakoyRestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeyKarakoyRestAPI.Services
{
    public class CategoryServiceFake
    {
        private readonly List<Category> _shoppingCart;

        public CategoryServiceFake()
        {
            _shoppingCart = new List<Category>()
            {
                new Category() { Id = 40, Name = "Orange Juice"},
                new Category() { Id =30 , Name = "Diary Milk"},
                new Category() { Id = 20 , Name = "Frozen Pizza"}
            };
        }

        public IEnumerable<Category> GetAllItems()
        {
            return _shoppingCart;
        }

        //public Category Add(Category newItem)
        //{
        //    newItem.Id = new int();
        //    _shoppingCart.Add(newItem);
        //    return newItem;
        //}

        //public Category GetById(int id)
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
