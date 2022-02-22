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
    public partial class uxLibrary : Form
    {
        public BindingList<Book> books = new BindingList<Book>();

        private InputHandler handler;

        public uxLibrary(InputHandler h)
        {
            books.Add(new Book("hi", 10));
            handler = h;
            InitializeComponent();
            //this is a test- sean hurt

            uxBookList.DataSource = books;

            if (uxBookList.SelectedItem != null)
            {
                uxSelectBook.Enabled = true;
            }
        }

        private void uxBookList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxBookList.SelectedItem != null) uxSelectBook.Enabled = true;
            else uxSelectBook.Enabled = false;
        }

        private void uxSelectBook_Click(object sender, EventArgs e)
        {
            Book b = books[uxBookList.SelectedIndex];

            //I (Sean) added this, lmk if it causes issues
            handler(State.BOOKSELECTED, b, "");
        }

        public void DisplayBook(State s)
        {
            switch (s)
            {
                case State.START:
                    break;
                case State.ADDBOOK:
                    break;
                case State.BOOKSELECTED:
                    break;
                case State.RETRIEVEINFORMATION:
                    break;
                case State.UPDATEINFORMATION:
                    break;
                case State.CLOSE:
                    break;
                default:
                    break;
            }
        }
    }
}
