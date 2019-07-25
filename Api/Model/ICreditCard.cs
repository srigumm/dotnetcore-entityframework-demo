namespace Api.Model
{
    using System;
    public interface ICreditCard : IEntity{
        string Name { get; set; }
        string BankName {get;set;}
    }
}