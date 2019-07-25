namespace Api.Model
{
    using System;
    public interface IEntity
{
    int Id { get; }
    DateTime CreatedOn { get;  }
    DateTime ModifiedOn { get;  }
}
}