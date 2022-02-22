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
        Object view;
    }
}
