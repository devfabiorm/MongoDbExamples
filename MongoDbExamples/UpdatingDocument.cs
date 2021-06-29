using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Threading.Tasks;

namespace MongoDbExamples
{
    partial class Program
    {
        static async Task UpdateDocument(string[] args)
        {
            var mongoConnection = new MongoDbConnection();

            var constructor = Builders<Book>.Filter;
            var condition = constructor.Eq(x => x.Title, "Game of Thrones");

            var book = await mongoConnection.Collection.Find(condition).FirstOrDefaultAsync();

            Console.WriteLine(book.ToJson());

            book.Year = 2000;
            book.Pages = 900;

            constructor = Builders<Book>.Filter;
            condition = constructor.Eq(x => x.Title, "Game of Thrones");

            await mongoConnection.Collection.ReplaceOneAsync(condition, book);

            Console.WriteLine(book.ToJson());
        }
    }
}
