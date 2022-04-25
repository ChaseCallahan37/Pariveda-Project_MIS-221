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
    public partial class MainScreen : Form
    {
        private static Users mainUser;

        private static viewInvoiceScreen viewInvScreen = new viewInvoiceScreen();

        private static ManageUsersScreen manageUsersScreen = new ManageUsersScreen();

        private static ManageEmployeesScreen manageEmployeesScreen = new ManageEmployeesScreen();


        
        public MainScreen(Users user)
        {
            InitializeComponent();
            mainUser = user;
            ShowUserInfo();
        }

        private void ShowUserInfo()
        {
            displayUserLabel.Text = $"Welcome\n{mainUser.GetName()}!";
        }

        private void CloseEverything()
        {
            CloseAllButLogin();
            Program.CloseLogin();
        }
        private void CloseAllButLogin()
        {
            this.Close();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            CloseAllButLogin();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void invoiceButton_Click(object sender, EventArgs e)
        {
            viewInvScreen = new viewInvoiceScreen();
            viewInvScreen.Show();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void displayUserLabel_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Program.CloseLogin();
        }

        private void welcomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void createUser_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void usersScreenButton_Click(object sender, EventArgs e)
        {
            manageUsersScreen = new ManageUsersScreen(mainUser);
            manageUsersScreen.Show();
        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            manageEmployeesScreen = new ManageEmployeesScreen();
            manageEmployeesScreen.Show();
        }

        private void payrollButton_Click(object sender, EventArgs e)
        {

        }
    }
}
