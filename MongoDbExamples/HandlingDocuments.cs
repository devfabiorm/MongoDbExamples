using MongoDB.Bson;
using System;
using System.Threading.Tasks;

namespace MongoDbExamples
{
    partial class Program
    {
        private static async Task HandlingDocumentsAsync(string[] args)
        {
            var doc = new BsonDocument("Title", "Game of Thrones");
            doc.Add("Author", "George R R Martins");
            doc.Add("Year", 1999);
            doc.Add("Pages", 855);

            var aboutArray = new BsonArray();

            aboutArray.Add("Fantasy");
            aboutArray.Add("Action");

            doc.Add("About", aboutArray);

            Console.WriteLine(doc);
        }
    }
}
