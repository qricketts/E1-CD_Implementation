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
        //public BindingList<Book> books = new BindingList<Book>();
        private BindingSource bs = new BindingSource();

        private InputHandler handler;
        private Library model;

        public uxLibrary(InputHandler h, Library m)
        {
            model = m;
            handler = h;
            InitializeComponent();
            //this is a test- sean hurt

            bs.DataSource = m.Books;
            uxBookList.DataSource = bs;

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
            Book b = model.Books[uxBookList.SelectedIndex];

            //I (Sean) added this, lmk if it causes issues
            handler(State.BOOKSELECTED, b, "");
        }

        public void DisplayBook(State s, Book b)
        {
            switch (s)
            {
                case State.START:
                    break;
                case State.ADDBOOK:
                    bs.ResetBindings(false);
                    break;
                case State.BOOKSELECTED:
                    uxBook newBook = new uxBook(handler, b);
                    newBook.Show();
                    break;
                default:
                    break;
            }
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            Book b = new Book(textBox2.Text, Int32.Parse(textBox1.Text));
            handler(State.ADDBOOK, b, "");
        }
    }
}
