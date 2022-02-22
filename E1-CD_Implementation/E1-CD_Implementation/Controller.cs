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
        RETRIEVEINFORMATION,
        UPDATEINFORMATION,
        CLOSE
    }

    class Controller
    {
        /// <summary>
        /// The App's Database
        /// </summary>
        Library model;

        /// <summary>
        /// The App's User Interface
        /// </summary>
        //uxLibrary view;

        Observer observer;

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
                    observer(State.BOOKSELECTED, b);
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
