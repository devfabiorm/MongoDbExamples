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
            Task T = IncludeSeveralBooks(args);
            Console.WriteLine("Press ENTER");
            Console.ReadLine();
        }
    }
}
