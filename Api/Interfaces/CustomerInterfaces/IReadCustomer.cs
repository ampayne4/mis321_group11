using System.Collections.Generic;
using Api.Models;

namespace api.Interfaces.CustomerInterfaces
{
    public interface IReadCustomer
    {
        //Have to code GetAll() and GetOne()
        public List<Customer> GetAll();
        public Customer GetOne(int id);
    }
}