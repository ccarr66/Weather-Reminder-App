using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Http;
using System.Drawing.Imaging;

namespace Weather_Reminder_App
{
    public partial class MainWindow : Form
    {
        private static Program.WindowMode nextMode;
        private static bool settingsOpen;
        private const int normalWindowWidth = 500;
        private const int settingsWindowWidth = 700;
        private const string imgURL = "http://openweathermap.org/img/wn/";
        private static Image dispImage;

        public MainWindow()
        {
            nextMode = Program.WindowMode.Terminate;
            settingsOpen = false;
            InitializeComponent();

            this.pnl_Settings.Enabled = false;
            this.pnl_Settings.Visible = false;
            this.Width = normalWindowWidth;
            this.Invalidate();

            if (WeatherLookup.update())
                updateDisplay();
            else
                openSettingsPane();

        }

        public Program.WindowMode NextMode
        {
            get { return nextMode; }
        }

        public void updateDisplay()
        {
            lbl_DispLoc.Text = WeatherLookup.weatherInfo.Name;
            lbl_DispTemp.Text = Math.Round(WeatherLookup.weatherInfo.Main.Temperature.FahrenheitCurrent, 2).ToString() + "°F";
            if (WeatherLookup.weatherInfo.Weathers.Count > 0)
            {
                lbl_DispGenWeather.Text = WeatherLookup.weatherInfo.Weathers[0].Description;

                if (getImage(WeatherLookup.weatherInfo.Weathers[0].Icon + "@2x.png"))
                    pctbx_WeatherIcon.Image = dispImage;
            }
            lbl_DispMaxTemp.Text = Math.Round(WeatherLookup.weatherInfo.Main.Temperature.FahrenheitMaximum, 2).ToString() + "°F";
            lbl_DispMinTemp.Text = Math.Round(WeatherLookup.weatherInfo.Main.Temperature.FahrenheitMinimum, 2).ToString() + "°F";


            decimal deg, min, sec;
            char dir;

            decimal latitude = (decimal)WeatherLookup.weatherInfo.Coord.Latitude;
            if (latitude < 0)
            {
                dir = 'S';
                latitude = -1 * latitude;
            }
            else
                dir = 'N';
            convertDoubleArc(latitude, out deg, out min, out sec);
            lbl_DispCoords.Text = deg + "° " + min + "' " + sec + "\"" + dir + "   ";

            decimal longitude = (decimal)WeatherLookup.weatherInfo.Coord.Longitude;
            if (longitude < 0)
            {
                dir = 'W';
                longitude = -1 * longitude;
            }
            else
                dir = 'E';
            convertDoubleArc(longitude, out deg, out min, out sec);
            lbl_DispCoords.Text += deg + "° " + min + "' " + sec + "\"" + dir + "   ";

            lbl_DispHumidity.Text = WeatherLookup.weatherInfo.Main.Humdity.ToString() + '%';
            lbl_DispWindSp.Text = WeatherLookup.weatherInfo.Wind.SpeedMetersPerSecond + "m/s";
            lbl_DispWindDir.Text = WeatherLookup.weatherInfo.Wind.Direction.ToString();
            lbl_DispClouds.Text = WeatherLookup.weatherInfo.Clouds.All.ToString() + '%';


            this.Invalidate();
        }

        public void convertDoubleArc(decimal val, out decimal degrees, out decimal min, out decimal sec)
        {
            degrees = Math.Floor(val);
            min = (val - Math.Floor(val)) * 60;
            sec = (min - Math.Floor(min)) * 60;
            // get rid of fractional part
            min = Math.Floor(min);
            sec = Math.Floor(sec);
        }

        public static bool getImage(string fileName)
        {
            try
            {
                System.Net.HttpWebRequest webRequest = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(imgURL+fileName);
                webRequest.AllowWriteStreamBuffering = true;
                webRequest.Timeout = 30000;

                System.Net.WebResponse webResponse = webRequest.GetResponse();

                System.IO.Stream stream = webResponse.GetResponseStream();

                dispImage = System.Drawing.Image.FromStream(stream);

                webResponse.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            if (settingsOpen)
            {
                saveSettings();
                closeSettingsPane();
            }
            else
                openSettingsPane();
        }

        private void openSettingsPane()
        {
            settingsOpen = true;

            updateSettingsPane();
            this.pnl_Settings.Enabled = true;
            this.pnl_Settings.Visible = true;
            this.pnl_Settings.Invalidate();
            this.Width = settingsWindowWidth;

        }

        private void closeSettingsPane()
        {
            if (saveSettings())
            {
                settingsOpen = false;

                this.pnl_Settings.Enabled = false;
                this.pnl_Settings.Visible = false;
                this.Width = normalWindowWidth;
                updateDisplay();
            }
        }

        private bool saveSettings()
        {
            bool saveSettings = true;
            txtbx_SettUser.BackColor = Color.White;
            if (txtbx_SettUser.Text != User.CurrentUser) 
            {
                if (User.validateUsername(txtbx_SettUser.Text))
                {
                    if (User.userIsNew(txtbx_SettUser.Text))
                    {
                        DialogResult confirm = MessageBox.Show("Usernames are different, create new user?", "Message", MessageBoxButtons.YesNo);
                        if (confirm == DialogResult.Yes)
                        {
                            DialogResult delete = MessageBox.Show("Do you want to permanently delete old user?", "Message", MessageBoxButtons.YesNo);
                            if (delete == DialogResult.Yes)
                                User.deleteUser(User.CurrentUser);

                            User.CurrentUser = txtbx_SettUser.Text;
                        }
                        else
                        {
                            txtbx_SettUser.BackColor = Color.Goldenrod;
                            saveSettings = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usernames Already Exists.", "Message", MessageBoxButtons.OK);
                        txtbx_SettUser.BackColor = Color.Goldenrod;
                        saveSettings = false;
                    }
                }
                else
                {
                    txtbx_SettUser.BackColor = Color.Goldenrod;
                    saveSettings = false;
                }
            }

            txtbx_SettLoc.BackColor = Color.White;
            if (!User.validateLocation(txtbx_SettLoc.Text))
            {
                txtbx_SettLoc.BackColor = Color.Goldenrod;
                saveSettings = false;
            }
            else
                User.UserLocation = txtbx_SettLoc.Text;

            if (chbx_Both.Checked)
                User.AlertPreference = UserPreference.Both;
            else if (chbx_Email.Checked)
                User.AlertPreference = UserPreference.Email;
            else
                User.AlertPreference = UserPreference.Desktop;

            txtbx_SettEmail.BackColor = Color.White;
            if (txtbx_SettEmail.Text != "" && !User.validateEmailAddr(txtbx_SettEmail.Text))
            {
                txtbx_SettEmail.BackColor = Color.Goldenrod;
                saveSettings = false;
            }
            else if ((User.AlertPreference == UserPreference.Both || User.AlertPreference == UserPreference.Email) && txtbx_SettEmail.Text == "")
            {
                txtbx_SettEmail.BackColor = Color.Goldenrod;
                saveSettings = false;
            }
            else
                User.UserEmailAddr = txtbx_SettEmail.Text;

            if (saveSettings)
            {
                updateSettingsPane();
                updateDisplay();
                return User.saveUser();
            }
            else
                return false;
        }

        private void updateSettingsPane()
        {
            this.txtbx_SettUser.Text = User.CurrentUser;
            this.txtbx_SettLoc.Text = User.UserLocation;
            this.txtbx_SettEmail.Text = User.UserEmailAddr;

            if (User.AlertPreference == UserPreference.Email)
                checkEmailBox();
            else if (User.AlertPreference == UserPreference.Both)
                checkBothBox();
            else
                checkDesktopBox();
        }

        private void watchForAlerts()
        {

        }

        private void chbx_Email_Click(object sender, EventArgs e)
        {
            checkEmailBox();
        }

        private void checkEmailBox()
        {
            chbx_Email.Checked = true;
            chbx_Desktop.Checked = false;
            chbx_Both.Checked = false;
        }

        private void chbx_Desktop_Click(object sender, EventArgs e)
        {
            checkDesktopBox();
        }

        private void checkDesktopBox()
        {
            chbx_Email.Checked = false;
            chbx_Desktop.Checked = true;
            chbx_Both.Checked = false;
        }

        private void chbx_Both_Click(object sender, EventArgs e)
        {
            checkBothBox();
        }

        private void checkBothBox()
        {
            chbx_Email.Checked = false;
            chbx_Desktop.Checked = false;
            chbx_Both.Checked = true;
        }

        private void btn_SaveSett_Click(object sender, EventArgs e)
        {
            saveSettings();
            updateDisplay();
        }

        private void btn_SwitchUsers_Click(object sender, EventArgs e)
        {
            nextMode = Program.WindowMode.Select;
            this.Close();
        }
    }
}
