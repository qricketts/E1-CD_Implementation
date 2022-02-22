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
            uxPage.Text = book.Title + "\n\n\n\n" + book.CurrentPage + " / " + book.PageCount;
        }

        private void uxPageForward_Click(object sender, EventArgs e)
        {
            book.NextPage();
            uxPage.Text = book.Title + "\n\n\n\n" + book.CurrentPage + " / " + book.PageCount;
        }

        private void uxPageBackward_Click(object sender, EventArgs e)
        {
            book.PrevPage();
            uxPage.Text = book.Title + "\n\n\n\n" + book.CurrentPage + " / " + book.PageCount;
        }

        private void uxAddBookMark_Click(object sender, EventArgs e)
        {
            book.SetBookMark(book.GetBookMarks().Length, book.CurrentPage);
            uxPage.Text = book.Title + "\n\n\n\n" + book.CurrentPage + " / " + book.PageCount;
        }
    }
}
