using MongoDB.Driver;

namespace thirdcomponent.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
