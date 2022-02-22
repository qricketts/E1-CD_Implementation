using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E1_CD_Implementation
{
    public delegate void Observer(State s);
    public delegate void InputHandler(State s, Book b, string args);
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Library lib = new Library();
            
            Controller controller = new Controller(lib);
            uxLibrary view = new uxLibrary(controller.handleEvents);
            controller.SetObserver(view.DisplayBook);
            Application.Run(view);
        }
    }
}
