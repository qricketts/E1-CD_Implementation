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

        public uxBook(Book b)
        {
            InitializeComponent();

            book = b;
            updatePage();
        }

        private void uxPageForward_Click(object sender, EventArgs e)
        {
            book.NextPage();
            updatePage();
        }

        private void uxPageBackward_Click(object sender, EventArgs e)
        {
            book.PrevPage();
            updatePage();
        }

        private void uxAddBookMark_Click(object sender, EventArgs e)
        {
            book.SetBookMark(book.GetBookMarks().Count, book.CurrentPage);
            updatePage();
        }

        //WIP
        /*private void uxRemoveBookMark_Click(object sender, EventArgs e)
        {
            List<int> bookmarks = book.GetBookMarks();
            int i = 0;
            foreach(int bm in bookmarks)
            {
                if (bm == book.CurrentPage)
                    bookmarks.Remove(bm);
            }
            book.SetBookMark(bookmarks);
            updatePage();
        }*/

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
            uxPage.Text = book.Title + "\n" + book.CurrentPage + " / " + book.PageCount + temp;
        }
    }
}
