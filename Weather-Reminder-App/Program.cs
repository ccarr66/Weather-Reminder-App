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
            Window currentWindow;

            if (User.NumOfUsers == 0)
            {
                currentWindow = Window.UserCreate;
            }
            else if (User.NumOfUsers > 1)
            {
                currentWindow = Window.UserSwitch;
            }
            else if (User.NumOfUsers == 1)
            {
                currentWindow = Window.MainWindow;
            }
            else
                return; //Consider adding error message here

            do
            {
                if (currentWindow == Window.MainWindow)
                {
                    MainWindow MW = new MainWindow();
                    Application.Run(MW);
                    currentWindow = MW.NextWindow;
                }
                else if (currentWindow == Window.UserCreate)
                {
                    UserCreateWindow UCW = new UserCreateWindow();
                    Application.Run(UCW);
                    currentWindow = UCW.NextWindow;
                }
                else if (currentWindow == Window.UserSwitch)
                {
                    UserCreateWindow UCW = new UserCreateWindow();
                    Application.Run(UCW);
                    currentWindow = UCW.NextWindow;
                }
                else
                    currentWindow = Window.Terminate;

            } while (currentWindow != Window.Terminate);
        }

        public enum Window { Terminate = -1, MainWindow, UserCreate, UserSwitch };

    }
}
