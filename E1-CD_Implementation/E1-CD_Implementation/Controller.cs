using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E1_CD_Implementation
{
    public enum State
    {
        START = 0,
        ADDBOOK,
        BOOKSELECTED,
        PAGEFORWARD,
        PAGEBACKWARD,
        ADDBOOKMARK,
        REMOVEBOOKMARK,
    }

    class Controller
    {
        /// <summary>
        /// The App's Database
        /// </summary>
        Library model;

        Observer observer;

        Observer bookObserver;

        /// <summary>
        /// Constructor for Controller
        /// </summary>
        /// <param name="m">Model Object</param>
        /// <param name="v">View Object</param>
        public Controller(Library m)
        {
            model = m;
        }

        public void SetObserver(Observer o)
        {
            observer = o;
        }

        public void SetBookObserver(Observer o)
        {
            bookObserver = o;
        }

        /// <summary>
        /// Method to handle called events
        /// </summary>
        /// <param name="state">State of the program</param>
        /// <param name="args"></param>
        public void handleEvents(State state, Book b, string args)
        {
            switch (state)
            {
                case State.START:
                    break;
                case State.ADDBOOK:
                    model.AddBook(b);
                    observer(State.ADDBOOK, b);
                    break;
                case State.BOOKSELECTED:
                    model.SelectBook(b);
                    observer(State.BOOKSELECTED, b);
                    break;
                case State.PAGEBACKWARD:
                    b.PrevPage();
                    break;
                case State.PAGEFORWARD:
                    b.NextPage();
                    break;
                case State.ADDBOOKMARK:
                    b.SetBookMark(b.GetBookMarks().Count, b.CurrentPage);
                    break;
                case State.REMOVEBOOKMARK:
                    model.SelectedBook.RemoveBookMark();
                    break;
                default:
                    break;
            }
        }
    }
}
