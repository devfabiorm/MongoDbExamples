using System;
using System.Threading.Tasks;

namespace MongoDbExamples
{
    partial class Program
    {
        static async Task IncludeSeveralBooks(string[] args)
        {
            var mongoConnection = new MongoDbConnection();
                      
            var book = BookValues.InsertBookValues("Dom Casmurro", "Machado de Assis", 1923, 188, "Romance, Literatura  Brasileira");
            await mongoConnection.Collection.InsertOneAsync(book);

            var book2 = BookValues.InsertBookValues("A Arte da Ficção", "David Lodge", 2002, 230, "Didático, Auto Ajuda");
            await mongoConnection.Collection.InsertOneAsync(book2);

            Console.WriteLine("Docs inserted...");
        }
    }
}
