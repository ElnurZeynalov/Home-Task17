using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Book
    {
        private static int _no;
        public int No { get;}
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public Genre Genre { get; set; }
        public double Price { get; set; }
        public Book()
        {
            _no++;
            No = _no;
        }
        public string ShowInfo()
        {
            return $"No: {this.No} - Name: {this.Name} - AuthorName: {this.AuthorName} - Genre: {this.Genre} - Price: {this.Price}";
        }
    }
}
