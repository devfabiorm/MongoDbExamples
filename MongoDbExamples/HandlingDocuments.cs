using MongoDB.Bson;
using System;
using System.Threading.Tasks;

namespace MongoDbExamples
{
    public class HandlingDocuments
    {
        static void Main(string[] args)
        {
            Task T = HandlingDocumentsAsync(args);
            Console.WriteLine("Press ENTER");
            Console.ReadLine();
        }

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
