using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Threading.Tasks;

namespace MongoDbExamples
{
    partial class Program
    {
        static async Task OrderedList(string[] args)
        {
            Console.WriteLine("Listando Documentos com número de página maiores que 300");
            var mongoConnection = new MongoDbConnection();
            var constructor = Builders<Book>.Filter;
            var conditional = constructor.Gte(b => b.Pages, 300);

            var bookList = await mongoConnection.Collection.Find(conditional).SortBy(b => b.Title).Limit(2).ToListAsync();

            Console.WriteLine("\n");

            foreach (var book in bookList)
            {
                Console.WriteLine(book.ToJson<Book>());
            }
        }
    }
}
