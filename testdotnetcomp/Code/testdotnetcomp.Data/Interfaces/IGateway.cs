using MongoDB.Driver;

namespace testdotnetcomp.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
