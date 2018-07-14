using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProductsApp.Models;

namespace ProductsApp.Controllers
{
    public class ProductController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product{Id=1,Name="Tomato Soup",Category="Groceries",Price=1 },
            new Product{Id=2,Name="Yo-yo",Category="Toys",Price=3.75M},
            new Product{Id=3,Name="Hammer",Category="Hardware",Price=16.99M}
        };
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Return the etire list of products as an Ienumearble<product>Type</returns>
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }
        /// <summary>
        /// Look up a single product by its id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Product</returns>
        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
