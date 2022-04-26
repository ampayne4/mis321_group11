using System.Collections.Generic;
using Api.Models;

namespace api.Interfaces.EmployeeInterfaces
{
    public interface IReadEmployee
    {
        public List<Employee> GetAll();
        // public Customer GetOne(int id);
    }
}