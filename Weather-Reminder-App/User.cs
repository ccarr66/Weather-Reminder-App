using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Reminder_App
{
    static class User
    {
        private static string appPath;
        private static List<string> users;
        private static string currentUser;
        private static string locationCity;
        private static List<UserAlert> alerts;
        private static string[] divisionMarkers = new string[3]{ "##Username", "##Location", "##Alerts" };
        /*
         * data members describing user go here
         * need to develop appropriate getters/setters 
         */

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

            currentUser = "NULL";
            locationCity = "NULL";
            alerts = new List<UserAlert>();
        }

        public static bool saveNewUser(string username, string location)
        {
            //saves new user to file
            string filePath = appPath + '\\' +  username + ".usr";
            try
            {
                FileStream fs = new FileStream(filePath, FileMode.Create);
                using (StreamWriter stream = new StreamWriter(fs))
                {
                    stream.WriteLine(divisionMarkers[0]);
                    stream.WriteLine(username);
                    stream.WriteLine(divisionMarkers[1]);
                    stream.WriteLine(location);
                    stream.WriteLine(divisionMarkers[2]);
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

                    buf = stream.ReadLine();
                    if (buf != divisionMarkers[2])
                        return false;

                    buf = stream.ReadLine();
                    while(buf != null)
                    {
                        string[] parts = buf.Split(' ');
                        if(parts.Length == 4)
                        {
                            bool validUR;
                            UserAlert newUR = new UserAlert(parts[0], parts[1], parts[2], parts[3], out validUR);
                            if (validUR)
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

        public static uint NumOfUsers
        {
            get { return (uint)(users.Count); }
        }
        
        public static string CurrentUser
        {
            get { return currentUser; }
            set { currentUser = value; }
        }

        public static List<string> UserList
        {
            get { return users; }
        }

        public static string UserLocation
        {
            get { return locationCity; }
            set { locationCity = value; }
        }

    }

    class UserAlert
    {
        public int hour;
        public int minute;
        public string weatherType;
        public int temp;
        public UserAlert(string hr, string min, string wT, string val, out bool valid)
        {

            valid = true;

            this.hour = Convert.ToInt32(hr);
            if (this.hour > 23 || this.hour < 0)
                valid = false;

            this.minute = Convert.ToInt32(min);
            if (this.minute > 59 || this.minute < 0)
                valid = false;

            this.weatherType = wT;
            if (this.weatherType != "Rain" && this.weatherType != "Thunder" && this.weatherType != "Snow" && this.weatherType != "Atmosphere" && this.weatherType != "Cold" && this.weatherType != "Hot" && this.weatherType != "Clear")
                valid = false;

            if (val == "null")
                this.temp = -1;
            else
            {
                this.temp = Convert.ToInt32(val);
                if (this.temp > 330 || this.temp < 190)
                    valid = false;
            }
        }

        public override string ToString()
        {
            return hour.ToString() + " " + minute.ToString() + " " + weatherType + " " + temp;
        }
    }
}
