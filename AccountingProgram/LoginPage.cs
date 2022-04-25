using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingProgram
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //Pull in the text from the textboxes and set the username and password for the main user
            Users mainUser = new Users();
            mainUser.SetUsername(usernameTextBox.Text);
            mainUser.SetPassword(passwordTextBox.Text);
            if(UserDatabase.FindUser(mainUser))       //Checks to see if the user exists, if they do, rest of main user info will be filled in
            {
                MainScreen mainScreen = new MainScreen(mainUser);
                mainScreen.Show();
                usernameTextBox.ResetText();
                passwordTextBox.ResetText();
            }
            else
            {
                MessageBox.Show("Please enter a valid username and password");
            }


        }
    }
}
