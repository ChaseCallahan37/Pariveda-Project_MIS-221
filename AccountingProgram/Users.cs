using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingProgram
{
    public class Users
    {
        private string name;

        private string username;

        private string password;

        private string jobTitle;

        public Users(string line)
        {
            string[] temp = line.Split('#');
            name = temp[0];
            username = temp[1];
            password = temp[2];
            jobTitle = temp[3];
        }

        public Users()
        {

        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetUsername(string userName)
        {
            this.username = userName;
        }

        public string GetUsername()
        {
            return username;
        }

        public void SetPassword(string passWord)
        {
            this.password = passWord;
        }

        public string GetPassword()
        {
            return password;
        }

        public void SetJobTitle(string jobTitle)
        {
            this.jobTitle = jobTitle;
        }

        public string GetJobTitle()
        {
            return jobTitle;
        }

        public String ToString()
        {
            string toPrint = "";
            toPrint += $"Name: {name, -20}";
            toPrint += $"Username: {username, -20}";
            toPrint += $"Password: {password, -15}";
            toPrint += $"Job Title: {jobTitle, -10}";
            return toPrint;
        }

        public string ToFile()
        {
            return $"{name}#{username}#{password}#{jobTitle}";
        }

        public int CompareToUsers(Users currUser)
        {
            return username.CompareTo(currUser.GetUsername());
        }

        public int CompareToUsers(string username)
        {
            return username.CompareTo(username);
        }

        public int CompareTo(string username)
        {
            return this.username.CompareTo(username);
        }

        public void BuildUser(Users user)
        {
            name = user.GetName();
            username = user.GetUsername();
            password = user.GetPassword();
            jobTitle = user.GetJobTitle();
        }
    }
}
