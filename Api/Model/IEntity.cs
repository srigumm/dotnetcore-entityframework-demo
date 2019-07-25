namespace Api.Model
{
    using System;
    public interface IEntity
{
    int Id { get; }
    DateTime CreatedOn { get; set; }
    DateTime ModifiedOn { get; set; }
}
}