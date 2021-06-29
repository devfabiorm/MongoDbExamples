using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Threading.Tasks;

namespace MongoDbExamples
{
    partial class Program
    {
        static async Task DeleteDocuments(string[] args)
        {
            var mongoConnection = new MongoDbConnection();

            Console.WriteLine("Listing M. Assis books");

            var filter = Builders<Book>.Filter.Eq(x => x.Author, "M. Assis");
            var books = await mongoConnection.Collection.FindAsync(filter);

            foreach(var book in books.ToList())
            {
                Console.WriteLine(book.ToJson());
            }

            await mongoConnection.Collection.DeleteManyAsync(filter);

            Console.WriteLine("Trying to list M. Assis books");

            books = await mongoConnection.Collection.FindAsync(filter);

            foreach (var book in books.ToList())
            {
                Console.WriteLine(book.ToJson());
            }
        }
    }
}
