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
    public partial class ManageUsersScreen : Form
    {
        private Users mainUser = new Users();

        private CreateUserScreen createUserScreen = new CreateUserScreen();
        public ManageUsersScreen()
        {
            InitializeComponent();
        }

        public ManageUsersScreen(Users mainUser)
        {
            InitializeComponent();
            this.mainUser = mainUser;
        }

        public void SetMainUser(Users mainUser)
        {
            this.mainUser = mainUser;
        }

        public Users GetMainUser()
        {
            return this.mainUser;
        }

        public void CloseWindow()
        {
            this.Close();
        }

        private void DisplaySearch()    //Method to take input in the search text box and see if any users contain the string in their name
        {
            Users searchUser = new Users();
            searchUser.SetName(searchUserTextBox.Text);
            //Returns a string with all the data needed to print
            viewUsersTextBox.Text = UserDatabase.SearchUsers(searchUser);
        }

        private void PopulateEditWindow()
        {
            Users editUser = new Users();
            editUser.SetUsername(usernameTextBox.Text);
            if(UserDatabase.FindUser(editUser))
            {

            }
            else
            {
                MessageBox.Show("User was not found");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }

        private void ManageUsersScreen_Load(object sender, EventArgs e)
        {

        }

        private void searchUserTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void userSearchButton_Click(object sender, EventArgs e)
        {

        }

        private void viewUsersTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void editUserButton_Click(object sender, EventArgs e)
        {
            Users newUser = new Users();
            newUser.SetUsername(usernameTextBox.Text);
            if(UserDatabase.FindUsername(newUser))
            {
                createUserScreen = new CreateUserScreen(newUser);
                createUserScreen.Show();
            }
            else
            {
                MessageBox.Show("User could not be found");
            }
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            Users delUser = new Users();
            delUser.SetUsername(usernameTextBox.Text);
            if(UserDatabase.FindUsername(delUser) == true)
            {
                DialogResult dialogResult = MessageBox.Show("Would you like to delete this User?", "Delete User", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (UserDatabase.DeleteUser(delUser))
                    {
                        MessageBox.Show("User was deleted");
                    }
                    else
                    {
                        MessageBox.Show("User was not deleted");
                    }
                }
            }
            else
            {
                MessageBox.Show("User could not be found");
            }
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            Program.CloseLogin();
        }

        private void viewTextBoxTest_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            createUserScreen.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplaySearch();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
