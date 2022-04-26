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
    public class EmployeesController : ControllerBase
    {
        // GET: api/Customers
        [EnableCors("OpenPolicy")]
        [HttpGet]
        public List<Employee> Get()
        {
            EmployeeUtil employeeUtil = new EmployeeUtil();
            return employeeUtil.GetAll();
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
        public void Post([FromBody] Employee employee)
        {
            EmployeeUtil employeeUtil = new EmployeeUtil();
            employeeUtil.Create(employee);
        }

        // PUT: api/Customers/5
        [EnableCors("OpenPolicy")]
        [HttpPut("{id}")]
        public void Put(int id)
        {
            EmployeeUtil employeeUtil = new EmployeeUtil();
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
