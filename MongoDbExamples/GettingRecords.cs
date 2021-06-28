using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Threading.Tasks;

namespace MongoDbExamples
{
    partial class Program
    {
        static async Task GetAllFromDataBase(string[] args)
        {
            var mongoConnection = new MongoDbConnection();

            //var bookList = await mongoConnection.Collection.Find(new BsonDocument()).ToListAsync();
            var bookList = await mongoConnection.Collection.FindAsync(new BsonDocument());

            Console.WriteLine("Listing books:");

            foreach(var book in bookList.ToList())
            {
                Console.WriteLine(book.ToJson<Book>());
            }

            Console.WriteLine("Ending list");
        }
    }
}
