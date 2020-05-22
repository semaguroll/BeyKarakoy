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
    public class ProductTest
    {
        //ProductsController _controller;
        //BeyKarakoyContext context;
        //ProductServiceFake service;
        //public ProductTest()
        //{
        
        //    _controller = new ProductsController(context,service);
        //}
        ProductsController _controller;
        ProductServiceFake service;
        BeyKarakoyContext context;

        public ProductTest()
        {
            IProductService servicee = (IProductService)service;      
         
            //_service = new ProductServiceFake();
            _controller = new ProductsController(context);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.GetProducts();

            // Assert
            Assert.IsType<OkObjectResult>(okResult.Result);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsAllItems()
        {
            // Act
            var okResult = _controller.GetProducts().Result;

            // Assert
            var items = Assert.IsType<List<Product>>(okResult.ToString());
            Assert.Equal(3, items.Count);
        }
    }
}
