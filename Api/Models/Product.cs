namespace Api.Models
{
    public class Product
    {
        public int ProductId {get; set;}
        public string ProductName {get; set;}
        public string ProductCategory {get; set;}
        public string ProductImage {get; set;}
        public double ProductPrice {get; set;} 
        public bool Deleted {get; set;}
    }
}