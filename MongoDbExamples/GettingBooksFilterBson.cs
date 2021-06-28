using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Threading.Tasks;

namespace MongoDbExamples
{
    partial class Program
    {
        static async Task FilterUsingBson(string[] args)
        {
            var mongoConnection = new MongoDbConnection();

            var filter = new BsonDocument();

            var bookList = await mongoConnection.Collection.Find(filter).ToListAsync();

            Console.WriteLine("Listing books:");

            foreach (var book in bookList)
            {
                Console.WriteLine(book.ToJson<Book>());
            }

            Console.WriteLine("Ending list...");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Listando Documentos Autor = Machado de Assis");

            filter = new BsonDocument
            {
                {"Author", "Machado de Assis"}
            };

            bookList = await mongoConnection.Collection.Find(filter).ToListAsync();

            Console.WriteLine("\n");

            foreach (var book in bookList)
            {
                Console.WriteLine(book.ToJson<Book>());
            }

            Console.WriteLine("Ending list");
        }
    }
}
