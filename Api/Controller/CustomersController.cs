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
    public class CustomersController : ControllerBase
    {
        // GET: api/Customers
        [EnableCors("OpenPolicy")]
        [HttpGet]
        public List<Customer> Get()
        {
            CustomerUtil customerUtil = new CustomerUtil();
            return customerUtil.GetAll();
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
        public void Post([FromBody] Customer customer)
        {
            CustomerUtil customerUtil = new CustomerUtil();
            customerUtil.Create(customer);
        }

        // PUT: api/Customers/5
        [EnableCors("OpenPolicy")]
        [HttpPut("{id}")]
        public void Put(int id)
        {
            CustomerUtil customerUtil = new CustomerUtil();
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
