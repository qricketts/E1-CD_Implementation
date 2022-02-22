using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1_CD_Implementation
{
    public class Library
    {
        public int BookCount { get; set; }


        public List<Book> Books { get; set; } = new List<Book>();

        public Book SelectedBook { get; set; }

        public void SelectBook(Book book)
        {
            SelectedBook = book;
        }
    }
}
