using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1_CD_Implementation
{
    public class Library
    {
        private int bookLimit = 25;
        public int BookCount { get; set; }


        public List<Book> Books { get; set; } = new List<Book>();

        public Book SelectedBook { get; set; }

        public Library()
        {
        }

        public void SelectBook(Book book)
        {
            SelectedBook = book;
        }

        public void AddBook(Book b)
        {
            if (BookCount >= bookLimit) throw new Exception("Library Full");
            Books.Add(b);
        }

        public void AddBook(string title, int pageCount)
        {
            Book b = new Book(title, pageCount);
            AddBook(b);
        }

    }
}
