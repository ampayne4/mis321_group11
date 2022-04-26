namespace Api.Models
{
    public class Product
    {
        public int ProductId {get; set;}
        public string ProductName {get; set;}
        public string ProductCategory {get; set;}
        public double ProdPrice{get;set;}
        public string ProductImg{get;set;}
        public bool Deleted {get; set;}
    }
}