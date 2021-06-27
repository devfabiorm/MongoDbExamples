using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MongoDbExamples
{
    partial class Program
    {
        static async Task HandlingAccessWithExternalClass(string[] args)
        {

            //Initialize object
            Book book = new Book
            {
                Title = "Star Wars Legends",
                Author = "Timothy Zahn",
                Year = 2010,
                Pages = 245,
                About = new List<string>
                {
                    "Science Fiction",
                    "Action"
                }
            };

            //Access DataBase
            var dbConnection = new MongoDbConnection();

            //Insert a document in database
            await dbConnection.Collection.InsertOneAsync(book);

            Console.WriteLine("Doc inserted");
        }
    }
}
