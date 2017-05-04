using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

//for include "Product" object.
using TutorialPractice.Models;

namespace TutorialPractice.APIController
{
    public class RoleDefController : ApiController
    {
        List<Product> products = new List<Product>()
        {
            new Product { Id = 1, Name = "product_1", Price = 10, Category = "type_1"},
            new Product { Id = 2, Name = "product_2", Price = 20, Category = "type_1"},
            new Product { Id = 3, Name = "product_3", Price = 30, Category = "type_2"},
            new Product { Id = 4, Name = "product_4", Price = 40, Category = "type_2"}
        };

        [HttpGet]
        public IEnumerable<Product> getAllProducts()
        {
            return products;
        }
    }
}
