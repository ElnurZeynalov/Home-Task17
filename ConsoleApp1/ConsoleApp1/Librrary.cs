using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Librrary
    {
        private List<Book> _books = new List<Book>();
        public bool IsExistsBook(Predicate<Book> predicate)
        {
            var wanted = _books.Find(predicate);
                if (wanted == null)
                    return false;
                return true;
        }
        public void AddBook(Book book)
        {
            if (IsExistsBook(bk => bk.Name == book.Name))
                throw new Exception("Bu adda Kitab sistemde movcuddur");
            _books.Add(book);
        }
        public List<Book> FilterByPrice(double min,double max)
        {
           return _books.FindAll(book => book.Price >= min && book.Price <= max);
        }
        public List<Book> FilterByGenre(Genre genre)
        {
            return _books.FindAll(book =>book.Genre == genre);
        }
        public Book FilterByNo(int? no)
        {
            if (no == null)
                throw new NullReferenceException();
            var filteredbook = _books.Find(book => book.No == no);
            if (filteredbook == null)
                throw new NotFoundException("404 not found error");
            return filteredbook;
        }
    }
}
