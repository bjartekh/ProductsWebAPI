using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProductsApplication.Models;
using System.Web;
using System.IO;
using System.Net.Http.Headers;

namespace ProductsApplication.Controllers
{
    public class ProductsController : ApiController
    {

        Product[] products = new Product[]
        {
            new Product { Id=1, Name="Tomato Soup", Category="Groceries",  Price= 1 },
            new Product { Id=2, Name="Yo-yo", Category="Toys", Price=2 },
            new Product { Id=3, Name="Hammer", Category="Hardware", Price=2.5M }
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if(product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }


        [Route("~/api/details/{name}")]
        [HttpGet, HttpPost]
        public HttpResponseMessage GetProductDetails(String name)
        {

            return Request.CreateResponse<string>(HttpStatusCode.OK, "hello");

            //var path = @"C:\Temp\musikk_cv_bjarte.pdf";
            //HttpResponseMessage result = new HttpResponseMessage(HttpStatusCode.OK);
            //var stream = new FileStream(path, FileMode.Open);
            //result.Content = new StreamContent(stream);
            //result.Content.Headers.ContentType =
            //    new MediaTypeHeaderValue("application/pdf");
            //return result;


            //HttpContext.Current.Server.MapPath("");

            //System.IO.File.ReadAllLines
            //var product = products.FirstOrDefault((p) => p.Id == id);
            //if (product == null)
            //{
            //    return NotFound();
            //}

            //return Ok(product);
        }



    }

}
