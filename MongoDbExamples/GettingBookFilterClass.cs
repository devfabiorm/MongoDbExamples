using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Threading.Tasks;

namespace MongoDbExamples
{
    partial class Program
    {
        static async Task FilteringClass(string[] asrgs)
        {
            var mongoConnection = new MongoDbConnection();
            Console.WriteLine("Listando Documentos Autor = Machado de Assis");

            var filter = new BsonDocument
            {
                {"Author", "Machado de Assis"}
            };

            var bookList = await mongoConnection.Collection.Find(filter).ToListAsync();

            Console.WriteLine("\n");

            foreach (var book in bookList)
            {
                Console.WriteLine(book.ToJson<Book>());
            }

            Console.WriteLine("Ending list\n\n");

            Console.WriteLine("Listando Documentos Autor = Machado de Assis - Classe");

            var constructor = Builders<Book>.Filter;
            var conditional = constructor.Eq(b => b.Author, "Machado de Assis");

            bookList = await mongoConnection.Collection.Find(conditional).ToListAsync();

            Console.WriteLine("\n");

            foreach (var book in bookList)
            {
                Console.WriteLine(book.ToJson<Book>());
            }

            Console.WriteLine("Ending list\n\n");

            Console.WriteLine("Listando Documentos Ano Maior ou Igual a 1999");

            constructor = Builders<Book>.Filter;
            conditional = constructor.Gte(b => b.Year, 1999);

            bookList = await mongoConnection.Collection.Find(conditional).ToListAsync();

            Console.WriteLine("\n");

            foreach (var book in bookList)
            {
                Console.WriteLine(book.ToJson<Book>());
            }

            Console.WriteLine("Ending list\n\n");

            Console.WriteLine("Listando Documentos Ano Maior ou Igual a 1999 e com MAIS de 300 páginas");

            constructor = Builders<Book>.Filter;
            conditional = constructor.Gte(b => b.Year, 1999) & constructor.Gt(b => b.Pages, 300);

            bookList = await mongoConnection.Collection.Find(conditional).ToListAsync();

            Console.WriteLine("\n");

            foreach (var book in bookList)
            {
                Console.WriteLine(book.ToJson<Book>());
            }

            Console.WriteLine("Ending list\n\n");

            Console.WriteLine("Listando Documentos cujo assunto possua Ficção Científica");

            constructor = Builders<Book>.Filter;
            conditional = constructor.AnyEq(b => b.About, "Ficção Científica");

            bookList = await mongoConnection.Collection.Find(conditional).ToListAsync();

            Console.WriteLine("\n");

            foreach (var book in bookList)
            {
                Console.WriteLine(book.ToJson<Book>());
            }
        }
    }
}
