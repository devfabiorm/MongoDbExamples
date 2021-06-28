using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace MongoDbExamples
{
    public class Book
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public int Pages { get; set; }
        public List<string> About { get; set; }
    }

    public class BookValues
    {

        public static Book InsertBookValues(string title, string author, int year, int pages, string about)
        {
            Book book = new Book();
            book.Title = title;
            book.Author = author;
            book.Year = year;
            book.Pages = pages;
            string[] aboutArray = about.Split(',');
            List<string> aboutArray2 = new List<string>();
            for (int i = 0; i <= aboutArray.Length - 1; i++)
            {
                aboutArray2.Add(aboutArray[i].Trim());
            }
            book.About = aboutArray2;
            return book;
        }
    }
}
