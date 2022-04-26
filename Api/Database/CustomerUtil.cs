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

            string stm = @"INSERT INTO customers(custId, custFName, custLName, custEmail, custPassword, cardName, cardNo, cardMonth, cardYear, cvvNo) VALUES(@custId, @custFName, @custLName, @custEmail, @custPassword, @cardName, @cardNo, @cardMonth, @cardYear, @cvvNo)";

            using var cmd = new MySqlCommand(stm, con);
            cmd.Parameters.AddWithValue("@custId", customer.CustId);
            cmd.Parameters.AddWithValue("@custFName", customer.CustFName);
            cmd.Parameters.AddWithValue("@custLName", customer.CustLName);
            cmd.Parameters.AddWithValue("@custEmail", customer.CustEmail);
            cmd.Parameters.AddWithValue("@custPassword", customer.CustPassword);
            cmd.Parameters.AddWithValue("@cardName", customer.CardName);
            cmd.Parameters.AddWithValue("@cardNo", customer.CardNo);
            cmd.Parameters.AddWithValue("@cardMonth", customer.CardMonth);
            cmd.Parameters.AddWithValue("@cardYear", customer.CardYear);
            cmd.Parameters.AddWithValue("@cvvNo", customer.CvvNo);
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

            string stm = @"SELECT * from customers";
            using var cmd = new MySqlCommand(stm, con);
            using MySqlDataReader read = cmd.ExecuteReader();
            while(read.Read())
            {
                myCustomer.Add(new Customer(){
                    CustId = read.GetInt32(0),
                    CustFName = read.GetString(1),
                    CustLName = read.GetString(2),
                    CustEmail = read.GetString(3),
                    CustPassword = read.GetString(4),
                    CardName = read.GetString(5),
                    CardNo = read.GetString(6),
                    CardMonth = read.GetString(7),
                    CardYear = read.GetString(8),
                    CvvNo = read.GetString(9),

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
            
            string stm = @"UPDATE customer SET CardNo = @CardNo WHERE Id = @Id"; ///////////fix BB
            stm = @"UPDATE customer SET CvvNo = @CvvNo WHERE Id = @Id";
            stm = @"UPDATE customer SET Date = @CardNo WHERE Date = @Date";
            using var cmd = new MySqlCommand(stm, con);
            cmd.Parameters.AddWithValue("@custId", customer.CustId);
            cmd.Parameters.AddWithValue("@cvvNo", customer.CvvNo);
            cmd.Parameters.AddWithValue("@cardMonth", customer.CardMonth);
            cmd.Parameters.AddWithValue("@cardYear", customer.CardYear);

            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }
    }
}