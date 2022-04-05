using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Name = "7 ci mertebede qetl";
            book1.AuthorName = "Elxan Elatli";
            book1.Genre = (Genre)4;
            book1.Price = 8;

            Book book2 = new Book();
            book2.Name = "80/20 meneceri";
            book2.AuthorName = "Richard Koch";
            book2.Genre = (Genre)3;
            book2.Price = 10;

            Book book3 = new Book();
            book3.Name = "Cehennemden gelen ses";
            book3.AuthorName = "Elxan Elatli";
            book3.Genre = (Genre)4;
            book3.Price = 8;
            Librrary librrary = new Librrary();
            librrary.AddBook(book1);
            librrary.AddBook(book2);
            librrary.AddBook(book3);

            
            foreach (var item in librrary.FilterByPrice(7, 9))
            {
                Console.WriteLine(item.ShowInfo());
            }
            Console.WriteLine("\n===============FilterByNo==============\n");
            Console.WriteLine( librrary.FilterByNo(2).ShowInfo());
            Console.WriteLine("\n===============FilterByGenre=============\n");
            foreach(var item in librrary.FilterByGenre((Genre)4))
            {
                Console.WriteLine(item.ShowInfo());
            }
            
        }
    }
}
