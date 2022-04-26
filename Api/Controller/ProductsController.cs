using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Database;
using Api.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // GET: api/Customers
        [EnableCors("OpenPolicy")]
        [HttpGet]
        public List<Product> Get()
        {
            ProductUtil productUtil = new ProductUtil();
            return productUtil.GetAll();
        }

        // GET: api/Customers/5
        // [EnableCors("OpenPolicy")]
        // [HttpGet("{id}", Name = "Get")]
        // // public string Get(int id)
        // // {
        // //     CustomerUtil customerUtil = new CustomerUtil();
        // //     // return customerUtil.GetOne();
        // // }

        // POST: api/Customers
        [EnableCors("OpenPolicy")]
        [HttpPost]
        public void Post([FromBody] Product product)
        {
            ProductUtil productUtil = new ProductUtil();
            productUtil.Create(product);
        }

        // PUT: api/Customers/5
        [EnableCors("OpenPolicy")]
        [HttpPut("{id}")]
        public void Put(int id)
        {
            ProductUtil productUtil = new ProductUtil();
            // customerUtil.Update();
        }

        // DELETE: api/Customers/5
        [EnableCors("OpenPolicy")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
