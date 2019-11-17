using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Weather_Reminder_App
{
    static class User
    {
        private static string appPath;
        private static List<string> users;
        private static string currentUser;
        private static string locationCity;
        private static string emailAddr;
        private static UserPreference alertPref;
        private static List<UserAlert> alerts;
        private const int maxNumAlerts = 5;
        private static string[] divisionMarkers = new string[5]{ "##Username", "##Location", "##User Alert Preference", "##Email Address", "##Alerts" };
        /*
         * data members describing user go here
         * need to develop appropriate getters/setters 
         */

        static User()
        {
            appPath = "";
            users = new List<string>();
            currentUser = "";
            locationCity = "";
            emailAddr = "";
            alertPref = UserPreference.Desktop;
            alerts = new List<UserAlert>();
        }

        public static void determineAvailableUsers()
        {
            //return list of users available
            //instantiates "Users" and determines all the users available
            appPath = Path.GetDirectoryName(Application.ExecutablePath);
            string[] usrFiles = Directory.GetFiles(appPath, "*.usr");
            users = new List<string>();

            for (int i = 0; i < usrFiles.Length; i++)
            {
                usrFiles[i] = usrFiles[i].Remove(0, appPath.Length + 1);
                usrFiles[i] = usrFiles[i].Remove(usrFiles[i].Length - 4, 4);
                users.Add(usrFiles[i]);
            }
        }

        public static bool saveUser()
        {
            //saves new user to file
            string filePath = appPath + '\\' +  currentUser + ".usr";
            try
            {
                FileStream fs = new FileStream(filePath, FileMode.Create);
                using (StreamWriter stream = new StreamWriter(fs))
                {
                    stream.WriteLine(divisionMarkers[0]);
                    stream.WriteLine(currentUser);

                    stream.WriteLine(divisionMarkers[1]);
                    stream.WriteLine(locationCity);

                    stream.WriteLine(divisionMarkers[2]);
                    stream.WriteLine(alertPref);

                    stream.WriteLine(divisionMarkers[3]);
                    stream.WriteLine(emailAddr);

                    stream.WriteLine(divisionMarkers[4]);
                    foreach (UserAlert al in User.alerts)
                        stream.WriteLine(al.ToString());
                }
                fs.Close();
            }
            catch
            {
                return false;
            }

            return true;
        }

        public static bool readUserFile()
        {
            alerts = new List<UserAlert>();
            //reads user info from file
            //saves new user to file
            string filePath = appPath + '\\' + User.CurrentUser + ".usr";
            try
            {
                FileStream fs = new FileStream(filePath, FileMode.Open);
                using (StreamReader stream = new StreamReader(fs))
                {
                    string buf = stream.ReadLine();
                    if (buf != divisionMarkers[0])
                        return false;

                    buf = stream.ReadLine();
                    if (buf != null)
                        User.CurrentUser = buf;
                    else return false;

                    buf = stream.ReadLine();
                    if (buf != divisionMarkers[1])
                        return false;

                    buf = stream.ReadLine();
                    if (buf != null)
                        User.locationCity = buf;
                    else return false;

                    //Alert Pref
                    buf = stream.ReadLine();
                    if (buf != divisionMarkers[2])
                        return false;

                    buf = stream.ReadLine();
                    if (buf != null)
                    {
                        if (!Enum.TryParse(buf, out alertPref))
                            return false;
                    }
                    else return false;

                    //Email Addr
                    buf = stream.ReadLine();
                    if (buf != divisionMarkers[3])
                        return false;

                    buf = stream.ReadLine();
                    if (buf != null)
                        User.emailAddr = buf;
                    else return false;

                    //ALERTS
                    buf = stream.ReadLine();
                    if (buf != divisionMarkers[4])
                        return false;

                    buf = stream.ReadLine();
                    while(buf != null)
                    {
                        string[] parts = buf.Split(';');
                        if(parts.Length == 4)
                        {
                            bool validUR;
                            UserAlert newUR = new UserAlert(parts[0], parts[1], parts[2], parts[3], out validUR);
                            if (validUR && User.alerts.Count < maxNumAlerts)
                                User.alerts.Add(newUR);
                        }
                        buf = stream.ReadLine();
                    }
                }
                fs.Close();
            }
            catch
            {
                return false;
            }

            return true;
        }

        public static void deleteUser(string username)
        {
            File.Delete(appPath + "\\" + username + ".usr");
        }

        public static uint NumOfUsers
        {
            get { return (uint)(users.Count); }
        }
        
        public static string CurrentUser
        {
            get { return currentUser; }
            set { currentUser = value; }
        }

        public static string UserLocation
        {
            get { return locationCity; }
            set { locationCity = value; }
        }

        public static string UserEmailAddr
        {
            get { return emailAddr; }
            set { emailAddr = value; }
        }

        public static UserPreference AlertPreference
        {
            get { return alertPref; }
            set { alertPref = value; }
        }

        public static List<string> UserList
        {
            get { return users; }
        }

        public static List<UserAlert> UserAlerts
        {
            get { return alerts;}
        }

        public static bool validateUsername(string username)
        {
            if (username.Contains("/") || username.Contains("\\") || username.Contains(":") || username.Contains("*") || username.Contains("?") || username.Contains("\\")
                || username.Contains("|") || username.Contains("<") || username.Contains(">") || username.Contains("\""))
                return false;
            if (username.Length < 1)
                return false;
            return true;
        }

        public static bool userIsNew(string username)
        {
            determineAvailableUsers();
            foreach (string usr in User.UserList)
                if (username == usr)
                    return false;
            return true;
        }

        public static bool validateLocation(string location)
        {
            return WeatherLookup.validCity(location);
        }

        public static bool validateEmailAddr(string emailAddr)
        {
            return (new EmailAddressAttribute().IsValid(emailAddr));
        }

    }

    class UserAlert
    {
        public string name;
        public int hour;
        public int minute;
        public string[] conditions;
        public UserAlert(string nm, string hr, string min, string conds, out bool valid)
        {

            valid = true;
            if (nm.Length > 10)
                this.name = nm.Substring(0, 10);
            else
                this.name = nm;

            this.hour = Convert.ToInt32(hr);
            if (this.hour > 23 || this.hour < 0)
                valid = false;

            this.minute = Convert.ToInt32(min);
            if (this.minute > 59 || this.minute < 0)
                valid = false;

            this.conditions = conds.Split(',');
            foreach(string cond in conditions)
            {
                switch(cond)
                {
                    case "All":
                        break;
                    case "Rain":
                        break;
                    case "Thund":
                        break;
                    case "Snow":
                        break;
                    case "Atmos":
                        break;
                    default:
                        {
                            if (cond.StartsWith("Hot") || cond.StartsWith("Cold"))
                            {
                                string resultString = Regex.Match(cond, @"\d+").Value;
                                int temperature;
                                if (!Int32.TryParse(resultString, out temperature))
                                    valid = false;
                            }
                            else
                                valid = false;
                            break;
                        }
                }
            }
        }

        public override string ToString()
        {
            string output = name + ';' + hour.ToString() + ';' + minute.ToString() + ';';
            for (int i = 0; i < conditions.Length; i++)
            {
                output += conditions[i];
                if (i < conditions.Length - 1)
                    output += ',';
            }

            return output;
        }
    }

    public enum UserPreference { Desktop = 0, Email, Both };
}
