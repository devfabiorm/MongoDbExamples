using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MongoDbExamples
{
    partial class Program
    {
        static async Task AccessingDatabaseWithClasses(string[] args)
        {
            //Initialize object
            Book book = new Book
            {
                Title = "Under the Dome",
                Author = "Stephen King",
                Year = 2012,
                Pages = 679,
                About = new List<string>
                {
                    "Science Fiction",
                    "Thriller",
                    "Action"
                }
            };

            //Access MongoDD Database Server
            string connectionString = "mongodb://localhost:27017";
            IMongoClient client = new MongoClient(connectionString);

            //Access MongoDB database
            IMongoDatabase database = client.GetDatabase("Library");

            //Access MongoDB collection
            IMongoCollection<Book> collection = database.GetCollection<Book>("Books");

            //Insert a document in database
            await collection.InsertOneAsync(book);

            Console.WriteLine("Doc inserted");
        }
    }
}
