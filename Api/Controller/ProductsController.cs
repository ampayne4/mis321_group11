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
        [EnableCors("OpenPolicy")]
        [HttpGet]
        public List<Product> Get()
        {
            ProductUtil productUtil = new ProductUtil();
            return productUtil.GetAll();
        }

        [EnableCors("OpenPolicy")]
        [HttpPost]
        public void Post([FromBody] Product product)
        {
            ProductUtil productUtil = new ProductUtil();
            productUtil.Create(product);
        }

        [EnableCors("OpenPolicy")]
        [HttpPut("{id}")]
        public void Put(int id)
        {
            ProductUtil productUtil = new ProductUtil();
        }

        [EnableCors("OpenPolicy")]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
