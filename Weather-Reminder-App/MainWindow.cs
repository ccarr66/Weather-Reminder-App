using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_Reminder_App
{
    public partial class MainWindow : Form
    {
        private static Program.Window nextWindow;
        public MainWindow()
        {
            nextWindow = Program.Window.Terminate;
            InitializeComponent();
        }

        public Program.Window NextWindow
        {
            get { return nextWindow; }
        }
    }
}
