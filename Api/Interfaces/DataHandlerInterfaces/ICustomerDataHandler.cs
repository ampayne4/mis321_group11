using Api.Models;
using System.Collections.Generic;

namespace Api.Interfaces.DataHandlerInterfaces
{
    public interface ICustomerDataHandler
    {
        List<Customer> GetAllCustomers();
        public Customer GetCustomer(int id);
        public void UpdateCustomer(Customer value);
        public void CreateCustomer(Customer value);
        public void DeleteCustomer(int id);

    }
}