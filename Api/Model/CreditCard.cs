namespace Api.Model
{
    using System;
    public class CreditCard:ICreditCard{
        public int Id{get;set;}
        public string Name{get;set;}
        public string BankName{get;set;}
        public DateTime CreatedOn{get;set;}
        public DateTime ModifiedOn{get;set;}
    }
}