using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Threading.Tasks;

namespace MongoDbExamples
{
    partial class Program
    {
        static async Task UpdateProperty(string[] args)
        {
            var mongoConnection = new MongoDbConnection();

            var filter = Builders<Book>.Filter.Eq(x => x.Year, 2000);
            var constructorUpdate = Builders<Book>.Update;
            var updateCondition = constructorUpdate.Set(x => x.Year, 2001);

            var result = await mongoConnection.Collection.UpdateOneAsync(filter, updateCondition);

            Console.WriteLine("Record changed", result);

            Console.WriteLine("Listing Machado de Assis books");

            filter = Builders<Book>.Filter.Eq(x => x.Author, "Machado de Assis");
            var books = await mongoConnection.Collection.Find(filter).ToListAsync();

            foreach (var book in books)
            {
                Console.WriteLine(book.ToJson());
            }

            updateCondition = constructorUpdate.Set(i => i.Author, "M. Assis");

            await mongoConnection.Collection.UpdateManyAsync(filter, updateCondition);

            Console.WriteLine("Records changed");
        }
    }
}
