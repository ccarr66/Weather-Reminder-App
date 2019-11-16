using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_Reminder_App
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            User.determineAvailableUsers();
            WindowMode mode;

            if (User.NumOfUsers == 0)
            {
                mode = WindowMode.Create;
            }
            else if (User.NumOfUsers >= 1)
            {
                mode = WindowMode.Select;
            }
            else
                mode = WindowMode.Terminate;
            
            do
            {
                if (mode == WindowMode.Main)
                {
                    MainWindow MW = new MainWindow();
                    Application.Run(MW);
                    mode = MW.NextMode;
                }
                else if(mode == WindowMode.Create || mode == WindowMode.Select)
                {
                    UserWindow UW = new UserWindow(mode);
                    Application.Run(UW);
                    mode = UW.NextMode;
                }
                else
                    mode = WindowMode.Terminate;

            } while (mode != WindowMode.Terminate);
            
        }

        public enum WindowMode { Terminate = -1, Main, Create, Select };

    }
}
