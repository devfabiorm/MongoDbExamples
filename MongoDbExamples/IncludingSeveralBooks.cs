using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MongoDbExamples
{
    partial class Program
    {
        static async Task IncludingBookList(string[] args)
        {
            var mongoConnection = new MongoDbConnection();

            List<Book> books = new List<Book>();
            books.Add(BookValues.InsertBookValues("A Dança com os Dragões", "George R R Martin", 2011, 934, "Fantasia, Ação"));
            books.Add(BookValues.InsertBookValues("A Tormenta das Espadas", "George R R Martin", 2006, 1276, "Fantasia, Ação"));
            books.Add(BookValues.InsertBookValues("Memórias Póstumas de Brás Cubas", "Machado de Assis", 1915, 267, "Literatura Brasileira"));
            books.Add(BookValues.InsertBookValues("Star Trek Portal do Tempo", "Crispin A C", 2002, 321, "Fantasia, Ação"));
            books.Add(BookValues.InsertBookValues("Star Trek Enigmas", "Dedopolus Tim", 2006, 195, "Ficção Científica, Ação"));
            books.Add(BookValues.InsertBookValues("Emília no Pais da Gramática", "Monteiro Lobato", 1936, 230, "Infantil, Literatura Brasileira, Didático"));
            books.Add(BookValues.InsertBookValues("Chapelzinho Amarelo", "Chico Buarque", 2008, 123, "Infantil, Literatura Brasileira"));
            books.Add(BookValues.InsertBookValues("20000 Léguas Submarinas", "Julio Verne", 1894, 256, "Ficção Científica, Ação"));
            books.Add(BookValues.InsertBookValues("Primeiros Passos na Matemática", "Mantin Ibanez", 2014, 190, "Didático, Infantil"));
            books.Add(BookValues.InsertBookValues("Saúde e Sabor", "Yeomans Matthew", 2012, 245, "Culinária, Didático"));
            books.Add(BookValues.InsertBookValues("Goldfinger", "Iam Fleming", 1956, 267, "Espionagem, Ação"));
            books.Add(BookValues.InsertBookValues("Da Rússia com Amor", "Iam Fleming", 1966, 245, "Espionagem, Ação"));
            books.Add(BookValues.InsertBookValues("O Senhor dos Aneis", "J R R Token", 1948, 1956, "Fantasia, Ação"));

            await mongoConnection.Collection.InsertManyAsync(books);

            Console.WriteLine("Docs inserted");
        }
    }
}
