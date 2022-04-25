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
        public int CardNo {get;set;}
        public int CvvNo {get;set;}
        public string CdDate{get;set;}
    }
}