using Api.Models;
using api.Interfaces.CustomerInterfaces;
using MySql.Data.MySqlClient;

namespace Api.Database
{
    public class CustomerUtil : ICreateCustomer, IDeleteCustomer
    {
        public void Create(Customer customer)
        {
            connectionstring myConnection = new connectionstring();
            string cs = myConnection.cs;
            using var con = new MySqlConnection(cs);
            con.Open();  

            string stm = @"INSERT INTO customers(custId, custEmail, custFName, custLName, custPhone, password, deleted) VALUES(@custId, @custEmail, @custFName, @custLName, @custPhone, @password, @deleted)";

            using var cmd = new MySqlCommand(stm, con);
            cmd.Parameters.AddWithValue("@custId", customer.Id);
            cmd.Parameters.AddWithValue("@custEmail", customer.Email);
            cmd.Parameters.AddWithValue("@custFName", customer.FirstName);
            cmd.Parameters.AddWithValue("@custLName", customer.LastName);
            cmd.Parameters.AddWithValue("@custPhone", customer.Phone);
            cmd.Parameters.AddWithValue("@password", customer.Password);
            cmd.Parameters.AddWithValue("@deleted", customer.Deleted);

            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            connectionstring myConnection = new connectionstring();
            string cs = myConnection.cs;
            Customer customer = new Customer();

            using var con = new MySqlConnection(cs);
            con.Open();

            string stm = @"UPDATE songs set Deleted = true where CustId = @CustId";
            using var cmd = new MySqlCommand(stm, con);
            cmd.Parameters.AddWithValue("CustId", customer.Id);
            
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }
    }
}