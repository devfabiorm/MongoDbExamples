using System;
using System.Threading.Tasks;

namespace MongoDbExamples
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //Task T = HandlingDocumentsAsync(args);
            //Task T = AccessingMongoDB(args);
            //Task T = AccessingDatabaseWithClasses(args);
            //Task T = HandlingAccessWithExternalClass(args);
            //Task T = IncludeSeveralBooks(args);
            //Task T = IncludingBookList(args);
            //Task T = GetAllFromDataBase(args);
            //Task T = FilterUsingBson(args);
            //Task T = FilteringClass(args);
            //Task T = OrderedList(args);
            //Task T = UpdateDocument(args);
            //Task T = UpdateProperty(args);
            Task T = DeleteDocuments(args);
            Console.WriteLine("Press ENTER");
            Console.ReadLine();
        }
    }
}
