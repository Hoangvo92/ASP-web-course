using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace testProject2.Controllers
{
    [RoutePrefix("api/products")]
    public class ProductsController : ApiController
    {
        // GET: api/Products
        [HttpGet, Route("")]
        public IEnumerable<string> ReturnAllProducts()
        {
            return new string[] { "product1", "product2" };
        }

        // GET: api/Products/5/orders/cusid
        [HttpGet, Route("{id}/orders/{cusid}")]
        public string Get(int id, string cusid)
        {
            return "product-orders-" + cusid;
        }

        // POST: api/Products
        [HttpPost, Route("")]
        public void CreateProduct([FromBody]string value)
        {
        }

        // PUT: api/Products/5
        [HttpPut, Route("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Products/5
        [HttpDelete, Route("{id}")]
        public void Delete(int id)
        {
        }
    }
}
