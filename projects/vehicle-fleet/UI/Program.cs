using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vehicle_Fleet_factory.UI;

namespace Vehicle_Fleet_factory.UI
{
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
            Application.Run(new LoginForm());
            //Application.Run(new VehicleForm());
            //Application.Run(new TestForm());
            //Only one Application.Run() can be executed at a time, because the message loop for a form can only handle one active form at a time.
            // If you try to call Application.Run() multiple times, only the first one will work, and the others will be ignored.
        }
    }
}
