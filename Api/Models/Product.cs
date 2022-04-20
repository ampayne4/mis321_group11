namespace Api.Models
{
    public class Product
    {
        public int ProductId {get; set;}
        public string ProductName {get; set;}
        public string ProductCategory {get; set;}
        public string ProductBrand {get; set;}
        public bool Deleted {get; set;}
    }
}