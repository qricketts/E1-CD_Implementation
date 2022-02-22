﻿using System;
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
        uxLibrary view;

        /// <summary>
        /// Constructor for Controller
        /// </summary>
        /// <param name="m">Model Object</param>
        /// <param name="v">View Object</param>
        public Controller(Library m, uxLibrary v)
        {
            model = m;
            view = v;
        }

        /// <summary>
        /// Method to handle called events
        /// </summary>
        /// <param name="state">State of the program</param>
        /// <param name="args"></param>
        public void handleEvents(State state, String args)
        {
            switch (state)
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
