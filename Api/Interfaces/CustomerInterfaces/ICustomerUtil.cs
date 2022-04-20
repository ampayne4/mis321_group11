using System.Collections.Generic;
using Api.Models;
namespace Api.Interfaces.CustomerInterfaces
{
    public interface ICustomerUtil
    {
         public List <Customer> custInfo {get;set;}

         public void AddCustomer();
         public void UpdateCustomer();

    }
}