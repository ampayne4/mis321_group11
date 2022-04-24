using Api.Models;
using api.Interfaces.CustomerInterfaces;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Api.Database
{
    public class CustomerUtil : ICreateCustomer, IUpdateCustomer, IReadCustomer
    {
        public void Create(Customer customer)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();  

            string stm = @"INSERT INTO customers(custId, custEmail, custFName, custLName, custPhone, password, CardNo, CvvNo, Date) VALUES(@custId, @custEmail, @custFName, @custLName, @custPhone, @password, @deleted, @CardNo, @CvvNo, @Date)";

            using var cmd = new MySqlCommand(stm, con);
            cmd.Parameters.AddWithValue("@custId", customer.Id);
            cmd.Parameters.AddWithValue("@custEmail", customer.Email);
            cmd.Parameters.AddWithValue("@custFName", customer.FirstName);
            cmd.Parameters.AddWithValue("@custLName", customer.LastName);
            cmd.Parameters.AddWithValue("@custPhone", customer.Phone);
            cmd.Parameters.AddWithValue("@password", customer.Password);
            cmd.Parameters.AddWithValue("@CardNo", customer.CardNo);
            cmd.Parameters.AddWithValue("@CvvNo", customer.CvvNo);
            cmd.Parameters.AddWithValue("@Date", customer.Date);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }

        public List<Customer> GetAll()
        {
            List<Customer> myCustomer = new List<Customer>();
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();

            Customer customer = new Customer();

            string stm = @"SELECT * from customers";
            using var cmd = new MySqlCommand(stm, con);
            using MySqlDataReader read = cmd.ExecuteReader();
            while(read.Read())
            {
                myCustomer.Add(new Customer(){
                    Id = read.GetInt32(0),
                    FirstName = read.GetString(1),
                    LastName = read.GetString(2),
                    Email = read.GetString(3),
                    Phone = read.GetString(4),
                });
            }
            return myCustomer;
        }

        public Customer GetOne(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Customer customer)
        {
            ConnectionString myConnection = new ConnectionString();
            string cs = myConnection.cs;

            using var con = new MySqlConnection(cs);
            con.Open();
            
            string stm = @"UPDATE customer SET CardNo = @CardNo WHERE Id = @Id";
            stm = @"UPDATE customer SET CvvNo = @CvvNo WHERE Id = @Id";
            stm = @"UPDATE customer SET Date = @CardNo WHERE Date = @Date";
            using var cmd = new MySqlCommand(stm, con);
            cmd.Parameters.AddWithValue("@Id", customer.Id);
            cmd.Parameters.AddWithValue("@CvvNo", customer.CvvNo);
             cmd.Parameters.AddWithValue("@Date", customer.Date);

            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }
    }
}