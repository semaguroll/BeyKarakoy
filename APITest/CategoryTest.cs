using BeyKarakoyRestAPI.Controllers;
using BeyKarakoyRestAPI.Data;
using BeyKarakoyRestAPI.Domain.Models;
using BeyKarakoyRestAPI.Domain.Services;
using BeyKarakoyRestAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Xunit;

namespace APITest
{
    public class CategoryTest
    {
        //CategoryController _controller;
        //BeyKarakoyContext context;
        //CategoryServiceFake service;
        //public CategoryTest()
        //{

        //    _controller = new CategoriesController(context,service);
        //}
        CategoriesController _controller;
        ProductServiceFake service;
        BeyKarakoyContext context;

        public CategoryTest()
        {
            ICategoryService servicee = (ICategoryService)service;

            //_service = new ProductServiceFake();
            _controller = new CategoriesController(context);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.GetCategory();

            // Assert
            Assert.IsType<OkObjectResult>(okResult.Result);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsAllItems()
        {
            // Act
            var okResult = _controller.GetCategory().Result;

            // Assert
            var items = Assert.IsType<List<Product>>(okResult.ToString());
            Assert.Equal(3, items.Count);
        }
    }
}
