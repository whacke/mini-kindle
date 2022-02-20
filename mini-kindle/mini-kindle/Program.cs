using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mini_kindle
{
    public delegate void FlipPageHandler(bool dir);
    public delegate void BookMkHandler(bool a);
    public delegate void UpdateDisplayDel(String page);
    public delegate void SelectBookDel(Book b);

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
            Controller c = new Controller();
            View view = new View(c.FlipPage, c.HandleBkMk, c.HandleSelectBook);
            c.AssignDisplay(view.UpdateDisplay);
            Application.Run(view);
        }
    }
}
