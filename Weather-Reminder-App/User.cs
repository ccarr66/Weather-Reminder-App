using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Reminder_App
{
    static class User
    {
        private static List<string> users;
        private static int userselected;
        /*
         * data members describing user go here
         * need to develop appropriate getters/setters 
         */

        public static void determineAvailableUsers()
        {
            //return list of users available
            //instantiates "Users" and determines all the users available
            ;
        }

        public static void saveNewUser()
        {
            //saves new user to file
            ;
        }

        public static void readNewUser()
        {
            //reads user info from file
            ;
        }

        public static uint NumOfUsers
        {
            get { return users.Count; }
        }

        public static string AddUser
        {
            set { users.Add(value); }
        }

        public static int UserSelected
        {
            get { return userselected; }
            set { userselected = value; }
        }

    }
}
