using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Threading.Tasks;

namespace MongoDbExamples
{
    partial class Program
    {
        private static async Task AccessingMongoDB(string[] args)
        {
            var doc = new BsonDocument("Title", "Game of Thrones");
            doc.Add("Author", "George R R Martins");
            doc.Add("Year", 1999);
            doc.Add("Pages", 855);

            var aboutArray = new BsonArray();

            aboutArray.Add("Fantasy");
            aboutArray.Add("Action");

            doc.Add("About", aboutArray);

            Console.WriteLine(doc);

            //Access a MongoDB Server
            string connectionString = "mongodb://localhost:27017";
            IMongoClient client = new MongoClient(connectionString);

            //Access a MongoDB database
            IMongoDatabase database = client.GetDatabase("Library");

            //Access a MongoDB collection
            IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>("Books");

            //Inserting a document in database
            await collection.InsertOneAsync(doc);

            Console.WriteLine("Doc inserted");
        }
    }
}
