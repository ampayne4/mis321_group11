namespace Api
{
    public class ConnectionString
    {
        public string cs {get;set;}

        public ConnectionString()
        {
            string server = "w3epjhex7h2ccjxx.cbetxkdyhwsb.us-east-1.rds.amazonaws.com";
            string database = "ggufxyz547q4nwo0";
            string port = "3306";
            string username = "vut7hg87owhj0qg9";
            string password = "pezr9x42bzm4ra5p";

            cs = $@"server = {server}; user = {username}; database = {database}; port = {port}; password={password}; convert zero datetime =True";
        }
    }
}