using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace ProductsApplication.Controllers
{
    public class DocumentController : ApiController
    {
        // GET: api/Document
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Document/5
        public HttpResponseMessage Get(int id)
        {

            var path = @"E:\temp\musikk_cv_bjarte.pdf";
            HttpResponseMessage result = new HttpResponseMessage(HttpStatusCode.OK);

            bool exists = File.Exists(path);
            
            Debug.WriteLine(path + " exists="+exists);
            var stream = new FileStream(path, FileMode.Open);
            
            result.Content = new StreamContent(stream);
            result.Content.Headers.ContentType =
                new MediaTypeHeaderValue("application/pdf");
            return result;
        }

        // POST: api/Document
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Document/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Document/5
        public void Delete(int id)
        {
        }
    }
}
