using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E1_CD_Implementation
{
    public partial class uxBook : Form
    {
        public Book book;

        InputHandler handler;

        public uxBook(InputHandler h, Book b)
        {
            InitializeComponent();
            handler = h;
            book = b;
            updatePage();
        }

        private void uxPageBackward_Click_1(object sender, EventArgs e)
        {
            handler(State.PAGEBACKWARD, book, "");
            updatePage();
        }

        private void uxPageForward_Click_1(object sender, EventArgs e)
        {
            handler(State.PAGEFORWARD, book, "");

            //book.NextPage();
            updatePage();
        }

        private void uxAddBookmark_Click_1(object sender, EventArgs e)
        {
            handler(State.ADDBOOKMARK, book, "");

            //book.SetBookMark(book.GetBookMarks().Count, book.CurrentPage);
            updatePage();
        }

        private void uxRemoveBookmark_Click(object sender, EventArgs e)
        {
            handler(State.REMOVEBOOKMARK, book, "");

            updatePage();
        }

        private void updatePage()
        {
            List<int> bookmarks = book.GetBookMarks();
            string temp = "\t Bookmarks are at: ";
            bool first = true;
            foreach (int bm in bookmarks)
            {
                if (first)
                {
                    temp = String.Concat(temp, bm);
                    first = false;
                }
                else
                    temp = String.Concat(temp, ", " + bm);
            }
            uxPage.Text = book.Title + "\t\t" + book.CurrentPage + " / " + book.PageCount + temp;
        }
    }
}
