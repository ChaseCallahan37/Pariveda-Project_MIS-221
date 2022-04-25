using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingProgram
{
    internal class UserDatabase
    {
        private static List<Users> userDatabase = new List<Users>();


        public static void SetUserDatabase(List<string> entireFile)         //Pulls in the entire file to work with it
        {
            foreach (string line in entireFile)
            {
                userDatabase.Add(new Users(line));
            }
        }

        public static List<Users> GetUserDatabase()
        {
            return userDatabase;
        }

        public static bool FindUser(Users mainUser)       //Receives the main user and checks it against all the users in the database
        {
            foreach (Users currUser in userDatabase)
            {
                if(currUser.GetUsername() == mainUser.GetUsername() && currUser.GetPassword() == mainUser.GetPassword())
                {
                    mainUser.BuildUser(currUser);       //Fills in the remaining information
                    return true;                        //End the search and return true
                }
            }

            return false;     //Return false to indicate that the user was not found
        }

        public static bool FindUsername(Users newUser)
        {
            foreach(Users currUser in userDatabase)
            {
                if(newUser.CompareToUsers(currUser) == 0)
                {
                    newUser.BuildUser(currUser);
                    return true;
                }
            }
            return false;
        }

        public static string SearchUsers(Users searchUser)
        {
            string toPrint = "";
            foreach(Users currUser in userDatabase)
            {
                if(currUser.GetName().Contains(searchUser.GetName()))
                {
                    toPrint += currUser.ToString();
                    toPrint += "\r\n";
                }
            }
            return toPrint;
        }

        public static void AddUser(Users currUser)      //Adds a new user to the list
        {
            userDatabase.Add(currUser);
        }

        public static bool DeleteUser(Users delUser)
        {
            List<Users> usersList = userDatabase;
            foreach(Users currUser in usersList)
            {
                //If the usernames match up, then remove it from the parent list
                if(delUser.CompareToUsers(currUser) == 0)
                {
                    userDatabase.Remove(currUser);
                    FileHandler.SaveFile(ToFile(), FileHandler.GetUserFileName());
                    return true;
                }   
            }
            return false;
        }

        public static List<string> ToFile()
        {
            List<string> userList = new List<string>();
            foreach (Users currUser in userDatabase)
            {
                userList.Add(currUser.ToFile());
            }
            return userList;
        }
    }
}
