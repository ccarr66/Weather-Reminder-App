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
using System.Text.RegularExpressions;
using System.Globalization;

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

        private static List<Label> alertDisplay;
        private static List<int> columnXCoords = new List<int>() { 12, 140, 205 };
        private const int startingYCoord = 445;
        private const int rowSeparation = 25;

        private const int removeChbxXCoord = 460;
        private const int removeChbxSeparation = 25;
        private static bool alertDeletingMode = false;
        private static bool alertAddingMode = false;
        private static List<CheckBox> removeAlertCheckBxs;

        private static UserAlert nextAlert;
        private static System.Windows.Forms.Timer alertTimer;

        public MainWindow()
        {
            nextMode = Program.WindowMode.Terminate;
            settingsOpen = false;
            InitializeComponent();

            this.pnl_Settings.Enabled = false;
            this.pnl_Settings.Visible = false;
            this.Width = normalWindowWidth;
            this.Invalidate();

            alertDisplay = new List<Label>();
            removeAlertCheckBxs = new List<CheckBox>();

            removeSaveButton();
            removeAlertAddControls();
            if (WeatherLookup.update())
            {
                updateDisplay();
            }
            else
                openSettingsPane();

        }

        public Program.WindowMode NextMode
        {
            get { return nextMode; }
        }

        public void updateDisplay()
        {
            endAlertEditing();
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

            displayAlerts();
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
            endAlertEditing();
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
            alertTimer = new System.Windows.Forms.Timer();
            User.determineAvailableUsers();
            this.Close();
        }

        private void displayAlerts()
        {
            eraseAlertDisplay();

            int index = 0; 
            int row = 0;
            foreach (UserAlert al in User.UserAlerts)
            {
                int col = 0;
                alertDisplay.Add(new Label());
                alertDisplay[index].TabIndex = 0;
                alertDisplay[index].Name = index.ToString();
                alertDisplay[index].Text = al.name;
                alertDisplay[index].AutoSize = true;
                alertDisplay[index++].Location = new Point(columnXCoords[col++], startingYCoord + rowSeparation * row);

                alertDisplay.Add(new Label());
                alertDisplay[index].TabIndex = 0;
                alertDisplay[index].Name = index.ToString();
                string time = ((al.hour == 0) ? "12" : ((al.hour > 12) ? (al.hour - 12).ToString() : al.hour.ToString())) + ':' + (al.minute.ToString().Length == 1 ? "0" : "") + (al.minute).ToString() + ((al.hour >= 12) ? " pm" : " am");
                alertDisplay[index].Text = time;
                alertDisplay[index].AutoSize = true;
                alertDisplay[index++].Location = new Point(columnXCoords[col++], startingYCoord + rowSeparation * row);

                alertDisplay.Add(new Label());
                alertDisplay[index].TabIndex = 0;
                alertDisplay[index].Name = index.ToString();
                string conditions = "";
                for (int i = 0; i < al.conditions.Length; i++)
                {
                    conditions += al.conditions[i];
                    if (i < al.conditions.Length - 1)
                        conditions += ", ";
                }
                alertDisplay[index].Text = conditions;
                alertDisplay[index].AutoSize = true;
                alertDisplay[index++].Location = new Point(columnXCoords[col], startingYCoord + rowSeparation * row++);
            }

            foreach(Label l in alertDisplay)
            {
                this.Controls.Add(l);
            }
            setNextAlert();
        }

        private void eraseAlertDisplay()
        {
            foreach (Label l in alertDisplay)
                this.Controls.Remove(l);
            alertDisplay.Clear();
            this.Invalidate();
        }

        private void removeSaveButton()
        {
            saveAlerts.Enabled = false;
            saveAlerts.Visible = false;
        }

        private void addSaveButton()
        {
            saveAlerts.Enabled = true;
            saveAlerts.Visible = true;
        }

        private void removeAlertAddControls()
        {
            chbx_NAL_All.Enabled = false;
            chbx_NAL_All.Visible = false;
            chbx_NAL_All.Checked = false;

            chbx_NAL_Atmosphere.Enabled = false;
            chbx_NAL_Atmosphere.Visible = false;
            chbx_NAL_Atmosphere.Checked = false;

            chbx_NAL_Cold.Enabled = false;
            chbx_NAL_Cold.Visible = false;
            chbx_NAL_Cold.Checked = false;

            chbx_NAL_Hot.Enabled = false;
            chbx_NAL_Hot.Visible = false;
            chbx_NAL_Hot.Checked = false;

            chbx_NAL_Rain.Enabled = false;
            chbx_NAL_Rain.Visible = false;
            chbx_NAL_Rain.Checked = false;

            chbx_NAL_Snow.Enabled = false;
            chbx_NAL_Snow.Visible = false;
            chbx_NAL_Snow.Checked = false;

            chbx_NAL_Thunder.Enabled = false;
            chbx_NAL_Thunder.Visible = false;
            chbx_NAL_Thunder.Checked = false;

            cmbx_NAL_Time.Enabled = false;
            cmbx_NAL_Time.Visible = false;
            cmbx_NAL_Time.SelectedIndex = 0;

            txtbx_NAL_Cold.Enabled = false;
            txtbx_NAL_Cold.Visible = false;
            txtbx_NAL_Cold.Text = "";

            txtbx_NAL_Hot.Enabled = false;
            txtbx_NAL_Hot.Visible = false;
            txtbx_NAL_Hot.Text = "";

            txtbx_NAL_Name.Enabled = false;
            txtbx_NAL_Name.Visible = false;
            txtbx_NAL_Name.Text = "";

            txtbx_NAL_Time.Enabled = false;
            txtbx_NAL_Time.Visible = false;
            txtbx_NAL_Time.Text = "";
        }

        private void addAlertAddControls()
        {
            eraseAlertDisplay();
            chbx_NAL_All.Enabled = true;
            chbx_NAL_All.Visible = true;
            chbx_NAL_All.Checked = false;

            chbx_NAL_Atmosphere.Enabled = true;
            chbx_NAL_Atmosphere.Visible = true;
            chbx_NAL_Atmosphere.Checked = false;

            chbx_NAL_Cold.Enabled = true;
            chbx_NAL_Cold.Visible = true;
            chbx_NAL_Cold.Checked = false;

            chbx_NAL_Hot.Enabled = true;
            chbx_NAL_Hot.Visible = true;
            chbx_NAL_Hot.Checked = false;

            chbx_NAL_Rain.Enabled = true;
            chbx_NAL_Rain.Visible = true;
            chbx_NAL_Rain.Checked = false;

            chbx_NAL_Snow.Enabled = true;
            chbx_NAL_Snow.Visible = true;
            chbx_NAL_Snow.Checked = false;

            chbx_NAL_Thunder.Enabled = true;
            chbx_NAL_Thunder.Visible = true;
            chbx_NAL_Thunder.Checked = false;

            cmbx_NAL_Time.Enabled = true;
            cmbx_NAL_Time.Visible = true;
            cmbx_NAL_Time.SelectedIndex = 0;

            txtbx_NAL_Cold.Enabled = true;
            txtbx_NAL_Cold.Visible = true;
            txtbx_NAL_Cold.Text = "";

            txtbx_NAL_Hot.Enabled = true;
            txtbx_NAL_Hot.Visible = true;
            txtbx_NAL_Hot.Text = "";

            txtbx_NAL_Name.Enabled = true;
            txtbx_NAL_Name.Visible = true;
            txtbx_NAL_Name.Text = "";

            txtbx_NAL_Time.Enabled = true;
            txtbx_NAL_Time.Visible = true;
            txtbx_NAL_Time.Text = "";

            this.Invalidate();
        }

        private void removeAlertDeleteControls()
        {
            foreach (CheckBox cb in removeAlertCheckBxs)
                this.Controls.Remove(cb);
            removeAlertCheckBxs.Clear();
            this.Invalidate();
        }

        private void addAlertDeleteControls()
        {
            int index = 0;
            foreach(UserAlert al in User.UserAlerts)
            {
                removeAlertCheckBxs.Add(new CheckBox());
                removeAlertCheckBxs[index].TabIndex = 0;
                removeAlertCheckBxs[index].Name = index.ToString();
                removeAlertCheckBxs[index].Text = "";
                removeAlertCheckBxs[index].Location = new Point(removeChbxXCoord, startingYCoord + rowSeparation * index);
                this.Controls.Add(removeAlertCheckBxs[index++]);
            }
        }

        private void btn_RemoveAlerts_Click(object sender, EventArgs e)
        {
            if (!settingsOpen && User.UserAlerts.Count > 0)
            {
                if (alertAddingMode)
                {
                    alertAddingMode = false;
                    removeAlertAddControls();
                    removeSaveButton();
                    displayAlerts();
                }
                
                if (alertDeletingMode)
                {
                    alertDeletingMode = false;
                    removeAlertDeleteControls();
                    removeSaveButton();
                }
                else
                {
                    alertDeletingMode = true;
                    addAlertDeleteControls();
                    addSaveButton();
                }

            }
        }

        private void btn_AddAlerts_Click(object sender, EventArgs e)
        {
            if (!settingsOpen && User.UserAlerts.Count <= User.maxNumAlerts)
            {
                if (alertDeletingMode)
                {
                    alertDeletingMode = false;
                    removeAlertDeleteControls();
                    removeSaveButton();
                    displayAlerts();
                }

                if (alertAddingMode)
                {
                    alertAddingMode = false;
                    removeAlertAddControls();
                    removeSaveButton();
                    displayAlerts();
                }
                else
                {
                    alertAddingMode = true;
                    addAlertAddControls();
                    addSaveButton();
                }

            }
        }

        private void saveAlerts_Click(object sender, EventArgs e)
        {
            if (!settingsOpen)
            {
                if (alertAddingMode)
                {
                    addAlert();
                }
                else if (alertDeletingMode)
                {
                    removeAlerts();
                }
            }
        }

        private void addAlert()
        {
            bool addAlert = true;
            if (User.UserAlerts.Count <= User.maxNumAlerts)
            {
                string name;
                if (txtbx_NAL_Name.Text.Length > 10)
                    name = txtbx_NAL_Name.Text.Substring(0, 10);
                else
                    name = txtbx_NAL_Name.Text;

                string[] time;
                int hr = 0, min = 0;
                time = txtbx_NAL_Time.Text.Split(':');
                if (time.Length != 2)
                    addAlert = false;
                else
                {
                    if (Int32.TryParse(time[0], out hr) && Int32.TryParse(time[1], out min))
                    {
                        if (!(hr >= 0 && hr <= 12 && min >= 0 && min <= 59))
                            addAlert = false;
                        else
                        {
                            if (cmbx_NAL_Time.SelectedItem.ToString() == "pm" && hr != 12)
                                hr += 12;
                            else if (cmbx_NAL_Time.SelectedItem.ToString() == "am" && hr == 12)
                                hr = 0;
                        }

                    }

                }

                string conditions = "";
                if (chbx_NAL_All.Checked)
                    conditions = "All,";
                else
                {
                    if (chbx_NAL_Atmosphere.Checked)
                        conditions += "Atmos,";
                    if (chbx_NAL_Rain.Checked)
                        conditions += "Rain,";
                    if (chbx_NAL_Snow.Checked)
                        conditions += "Snow,";
                    if (chbx_NAL_Thunder.Checked)
                        conditions += "Thund,";
                }

                if (chbx_NAL_Cold.Checked)
                {
                    int coldThreshold = 0;
                    if (Int32.TryParse(txtbx_NAL_Cold.Text, out coldThreshold) && coldThreshold >= -100 && coldThreshold <= 330)
                        conditions += "Cold(" + coldThreshold.ToString() + "),";
                    else
                        addAlert = false;
                }
                if (chbx_NAL_Hot.Checked)
                {
                    int hotThreshold = 0;
                    if (Int32.TryParse(txtbx_NAL_Hot.Text, out hotThreshold) && hotThreshold >= -100 && hotThreshold <= 330)
                        conditions += "Hot(" + hotThreshold.ToString() + "),";
                    else
                        addAlert = false;
                }

                if (addAlert)
                {
                    conditions = conditions.Remove(conditions.Length - 1, 1);
                    bool valid;
                    UserAlert NUR = new UserAlert(name, hr.ToString(), min.ToString(), conditions, out valid);
                    if (valid)
                        User.UserAlerts.Add(NUR);
                    removeAlertAddControls();
                    removeSaveButton();
                    User.saveUser();
                    displayAlerts();
                    alertAddingMode = false;
                }
            }            
        }

        private void removeAlerts()
        {
            for(int i = removeAlertCheckBxs.Count - 1; i >= 0; i--)
            {
                if (removeAlertCheckBxs[i].Checked)
                    User.UserAlerts.RemoveAt(i);
            }

            removeAlertDeleteControls();
            removeSaveButton();
            User.saveUser();
            displayAlerts();
            alertDeletingMode = false;
        }

        private void endAlertEditing()
        {
            if(alertAddingMode)
            {
                removeAlertAddControls();
                removeSaveButton();
                User.saveUser();
                displayAlerts();
                alertAddingMode = false;
            }
            else if (alertDeletingMode)
            {
                removeAlertDeleteControls();
                removeSaveButton();
                User.saveUser();
                displayAlerts();
                alertDeletingMode = false;
            }
        }

        private void setNextAlert()
        {
            alertTimer = new System.Windows.Forms.Timer();
            if (User.UserAlerts.Count > 0)
            {
                int nextAlertTime = 1000;
                bool validAlert = false;
                do
                {

                    DateTime now = DateTime.Now;
                    int hour = now.Hour;
                    int min = now.Minute;
                    int sec = now.Second;
                    int timeInSec = min * 60 + hour * 3600 + sec;
                    KeyValuePair<int, UserAlert> distToNextAlert = new KeyValuePair<int, UserAlert>(24 * 3600, null);

                    foreach (UserAlert al in User.UserAlerts)
                    {
                        int distance = (al.minute * 60 + al.hour * 3600) - timeInSec;
                        if (distance < distToNextAlert.Key)
                        {
                            if (distance < 0)
                                distToNextAlert = new KeyValuePair<int, UserAlert>(24 * 3600 + distance, al);
                            else
                                distToNextAlert = new KeyValuePair<int, UserAlert>(distance, al);
                        }
                    }

                    nextAlert = distToNextAlert.Value;
                    alertTimer.Tick += new EventHandler(alertEvent);
                    nextAlertTime = (distToNextAlert.Key) * 1000;

                    if (nextAlertTime < 1000)
                        validAlert = false;
                    else
                        validAlert = true;


                } while (!validAlert);

                alertTimer.Interval = nextAlertTime;
                alertTimer.Start();
            }

        }

        private void alertEvent(object source, EventArgs e)
        {
            alertTimer.Stop();
            restoreWindow();
            bool alertNeeded = false;
            string alertMessage = "";
            bool alertMessageCreated = getAlertMessage(out alertNeeded, out alertMessage);
            if (alertNeeded && alertMessageCreated)
            {
                if (User.AlertPreference == UserPreference.Both)
                {
                    desktopAlert(alertMessage);
                    emailAlert(alertMessage);
                }
                else if (User.AlertPreference == UserPreference.Email)
                    emailAlert(alertMessage);
                else
                    desktopAlert(alertMessage);
            }
            setNextAlert();
        }

        private void desktopAlert(string alertMessage)
        {
            MessageBox.Show(alertMessage, "Weather Reminder", MessageBoxButtons.OK);
        }

        private void emailAlert(string alertMessage)
        {
            ;
        }

        private bool getAlertMessage(out bool alertNeeded, out string alertMessage)
        {
            alertNeeded = false;
            alertMessage = "Hello " + User.CurrentUser + "!" + System.Environment.NewLine;

            bool hot = false, cold = false, all = false, rain = false, thunder = false, snow = false, atmosphere = false;
            int hotThresh = 0, coldThresh = 0;

            foreach (string cond in nextAlert.conditions)
            {
                switch (cond)
                {
                    case "All":
                        {
                            all = true;
                            break;
                        }
                    case "Rain":
                        {
                            rain = true;
                            break;
                        }
                    case "Thund":
                        {
                            thunder = true;
                            break;
                        }
                    case "Snow":
                        {
                            snow = true;
                            break;
                        }
                    case "Atmos":
                        {
                            atmosphere = true;
                            break;
                        }
                    default:
                        {
                            if (cond.StartsWith("Hot"))
                            {
                                string resultString = Regex.Match(cond, @"\d+").Value;
                                if (!Int32.TryParse(resultString, out hotThresh))
                                    return false;
                                else
                                    hot = true;
                            }
                            else if (cond.StartsWith("Cold"))
                            {
                                string resultString = Regex.Match(cond, @"\d+").Value;
                                if (!Int32.TryParse(resultString, out coldThresh))
                                    return false;
                                else
                                    cold = true;
                            }
                            else
                                return false;

                            break;
                        }
                }
            }


            int weatherGroup = (int)Math.Floor((decimal)WeatherLookup.weatherInfo.Weathers[0].ID / 100);

            if (weatherGroup != 7)
            {
                alertMessage += "It is expected to be a " + WeatherLookup.weatherInfo.Weathers[0].Description + " today, with a high of "
                + WeatherLookup.weatherInfo.Main.Temperature.FahrenheitMaximum + " and a low of " + WeatherLookup.weatherInfo.Main.Temperature.FahrenheitMinimum + "." + System.Environment.NewLine;
            }
            else
            {
                alertMessage += "today there will be a high of "
                + WeatherLookup.weatherInfo.Main.Temperature.FahrenheitMaximum + " and a low of " + WeatherLookup.weatherInfo.Main.Temperature.FahrenheitMinimum + "." + System.Environment.NewLine;
            }

            if ((hot && (int)WeatherLookup.weatherInfo.Main.Temperature.FahrenheitMaximum > hotThresh))
            {
                alertMessage += "Make sure to wear light clothing today! It'll be hot...";
                alertNeeded = true;
            }
            else if ((cold && (int)WeatherLookup.weatherInfo.Main.Temperature.FahrenheitMinimum < coldThresh))
            {
                alertMessage += "It'll be cold today, make sure to wear warm clothes...";
                alertNeeded = true;
            }

            switch (weatherGroup)
            {
                case 2:
                    {
                        if (thunder || all)
                        {
                            alertMessage += "There's going to be a thunderstorm so don't forget rain-resistant clothing and stay safe.";
                            alertNeeded = true;
                        }
                        break;
                    }
                case 3:
                case 5:
                    {
                        if (rain || all)
                        {
                            alertMessage += "It's going to rain so don't forget rain-resistant clothing and to stay safe.";
                            alertNeeded = true;
                        }
                        break;
                    }
                case 6:
                    {
                        if (snow || all)
                        {
                            alertMessage += "It's going to snow so don't forget warm, water-proof clothing and to stay safe." + System.Environment.NewLine + "If you're driving don't forget your snow chains!";
                            alertNeeded = true;
                        }
                        break;
                    }
                case 7:
                    {
                        if (atmosphere || all)
                        {
                            alertMessage += System.Environment.NewLine + "Atmospheric Warning: " + WeatherLookup.weatherInfo.Weathers[0].Description;
                            alertNeeded = true;
                        }
                        break;
                    }
                default:
                    break;
            }


            return true;
        }

        private void chbx_NAL_All_CheckedChanged(object sender, EventArgs e)
        {
            if(chbx_NAL_All.Checked)
            {
                chbx_NAL_Atmosphere.Checked = false;
                chbx_NAL_Atmosphere.Visible = false;
                chbx_NAL_Atmosphere.Enabled = false;
                chbx_NAL_Rain.Checked = false;
                chbx_NAL_Rain.Visible = false;
                chbx_NAL_Rain.Enabled = false;
                chbx_NAL_Snow.Checked = false;
                chbx_NAL_Snow.Visible = false;
                chbx_NAL_Snow.Enabled = false;
                chbx_NAL_Thunder.Checked = false;
                chbx_NAL_Thunder.Visible = false;
                chbx_NAL_Thunder.Enabled = false;
            }
            else
            {
                chbx_NAL_Atmosphere.Checked = true;
                chbx_NAL_Atmosphere.Visible = true;
                chbx_NAL_Atmosphere.Enabled = true;
                chbx_NAL_Rain.Checked = true;
                chbx_NAL_Rain.Visible = true;
                chbx_NAL_Rain.Enabled = true;
                chbx_NAL_Snow.Checked = true;
                chbx_NAL_Snow.Visible = true;
                chbx_NAL_Snow.Enabled = true;
                chbx_NAL_Thunder.Checked = true;
                chbx_NAL_Thunder.Visible = true;
                chbx_NAL_Thunder.Enabled = true;
            }
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                trayIcon.Visible = true;
                this.ShowInTaskbar = false;
            }

        }

        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            restoreWindow();
        }

        private void restoreWindow()
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            trayIcon.Visible = false;
        }

    }

}
