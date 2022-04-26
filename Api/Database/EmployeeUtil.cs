using Api.Models;
using api.Interfaces.CustomerInterfaces;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
namespace Api.Database
{
    public class EmployeeUtil
    {
        public List<Employee> GetAll()
        {
            List<Employee> myEmployee = new List<Employee>();
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"SELECT * from employees";
            using var cmd = new MySqlCommand(stm, con);
            using MySqlDataReader read = cmd.ExecuteReader();
            while(read.Read())
            {
                myEmployee.Add(new Employee(){
                    EmpId = read.GetInt32(0),
                    EmpEmail = read.GetString(1),
                    EmpFName = read.GetString(2),
                    EmpLName = read.GetString(3),
                    EmpPassword = read.GetString(4),
                });
            }
            return myEmployee;
        }
    }
}