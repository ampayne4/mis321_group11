namespace Api.Models
{
    public class Customer
    {
        public int CustId {get; set;}
        public string CustFName{get;set;}
        public string CustLName{get;set;}
        public string CustEmail{get;set;}
        public string CustPassword{get;set;}
        public string CardName {get; set;}
        public string CardNo {get;set;}
        public string CvvNo {get;set;}
        public string CardMonth {get; set;}
        public string CardYear{get;set;}
    }
}