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
    public partial class CreateUserScreen : Form
    {

        private Users newUser = new Users();

        private Users delUser = new Users();
        public CreateUserScreen()
        {
            InitializeComponent();
            delUser.SetUsername("null");
        }

        public CreateUserScreen(Users newUser)
        {
            delUser.BuildUser(newUser);
            this.newUser.BuildUser(newUser);
            InitializeComponent();
            FillOutForm();
        }

        private void FillOutForm()
        {
            nameTextBox.Text = newUser.GetName();
            usernameTextBox.Text = newUser.GetUsername();
            passwordTextBox.Text = newUser.GetPassword();
            comboBox1.Text = newUser.GetJobTitle();
        }

        public void CloseWindow()
        {
            this.Close();
        }

        private bool ContinueToSave()
        {
            if(nameTextBox.Text == "")
            {
                return false;
            }
            if(usernameTextBox.Text == "")
            {
                return false;
            }
            if(passwordTextBox.Text == "")
            {
                return false;
            }
            if(comboBox1.Text == "")
            {
                return false;
            }
            return true;
        }

        private void PullFormInfo()
        {
            newUser.SetName(nameTextBox.Text);
            newUser.SetPassword(passwordTextBox.Text);
            newUser.SetUsername(usernameTextBox.Text);
            newUser.SetJobTitle(comboBox1.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(ContinueToSave())
            {
                if(delUser.CompareToUsers("null") == 0)
                {
                    UserDatabase.DeleteUser(delUser);
                }
                PullFormInfo();
                UserDatabase.AddUser(newUser);
                FileHandler.SaveFile(UserDatabase.ToFile(), FileHandler.GetUserFileName());
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill out all required fields");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateUserScreen_Load(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            CloseWindow();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
