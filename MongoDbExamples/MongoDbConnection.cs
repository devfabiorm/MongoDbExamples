using MongoDB.Driver;

namespace MongoDbExamples
{
    public class MongoDbConnection
    {
        public const string CONNECTION_STRING = "mongodb://localhost:27017";
        public const string DATABASE_NAME = "Library";
        public const string COLLECTION_NAME = "Books";

        private readonly IMongoClient _client;
        private readonly IMongoDatabase _database;

        public MongoDbConnection()
        {
            _client = new MongoClient(CONNECTION_STRING);
            _database = _client.GetDatabase(DATABASE_NAME);
        }

        public IMongoClient Client 
        {
            get
            {
                return _client;
            } 
        }

        public IMongoCollection<Book> Collection 
        {
            get
            {
                return _database.GetCollection<Book>(COLLECTION_NAME);
            } 
        }
    }
}
