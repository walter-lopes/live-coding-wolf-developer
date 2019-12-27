using MongoDB.Driver;

namespace LiveDotNet.Rest.Context
{
    public interface IDbContext
    {
        IMongoDatabase Context { get;  }
    }
}
