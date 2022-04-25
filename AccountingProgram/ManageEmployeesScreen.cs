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
    public partial class ManageEmployeesScreen : Form
    {

        private Employees searchEmp = new Employees();

        private Employees deleteEmp = new Employees();

        private Employees editEmp = new Employees();

        private static yearsOfServiceTextBox createEmployeeScreen = new yearsOfServiceTextBox();
        public ManageEmployeesScreen()
        {
            InitializeComponent();
            HideObjects();
        }

        private void HideObjects()
        {
            deleteEmployeePanel.Visible = false;
            editEmployeePanel.Visible = false;
            createEmployeePanel.Visible = false;
        }

        private void UserNotFound()
        {
            MessageBox.Show("User could not be found");
        }

        private void SearchEmployees()
        {
            BuildSearchEmployee();
            Searcher employeeSearcher = new Searcher(searchEmp);
            viewEmployeeSearchTextBox.Text = employeeSearcher.SearchEmployeeDatabase();

        }
        
        private void BuildDeleteEmployee(Employees currEmployee)
        {
            if(Utilities.CheckIsNum(employeeDeleteIdTextBox.Text))
            {
                deleteEmp.SetEmployeeId(int.Parse(employeeDeleteIdTextBox.Text));
                Searcher delSearcher = new Searcher(deleteEmp);
                if(delSearcher.FindEmployee())
                {
                    MessageBox.Show("Found!");
                }
                else
                {
                    UserNotFound();
                }
            }
            else
            {
                UserNotFound();
            }
        }

        private void BuildSearchEmployee()
        {
            //Builds the employee from the text fields
            if (searchEmployeesTextBox.Text != "")
            {
                searchEmp.SetName(searchEmployeesTextBox.Text);
            }
            else
            {
                searchEmp.SetName("");
            }
            if(searchEmployeeDeptTextBox.Text != "")
            {
                searchEmp.SetDept(searchEmployeeDeptTextBox.Text);
            }
            else
            {
                searchEmp.SetDept("");
            }
            if (searchIdemployeeTextBox.Text != "" && Utilities.CheckIsNum(searchIdemployeeTextBox.Text))
            {
                searchEmp.SetEmployeeId(int.Parse(searchIdemployeeTextBox.Text));
            }
            else
            {
                searchEmp.SetEmployeeId(-1);
            }
        }
            

        private void searchEmployeesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SearchEmployees();
        }

        private void searchIdemployeeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void viewEmployeeSearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editEmployeeButton_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editEmployeeRadio_CheckedChanged(object sender, EventArgs e)
        {
            HideObjects();
            editEmployeePanel.Visible = true;
        }

        private void deleteEmployeeRadio_CheckedChanged(object sender, EventArgs e)
        {
            HideObjects();
            deleteEmployeePanel.Visible = true;
        }

        private void createEmployeeRadio_CheckedChanged(object sender, EventArgs e)
        {
            HideObjects();
            createEmployeePanel.Visible = true;

        }

        private void deleteEmployeeButton_Click(object sender, EventArgs e)
        {
            BuildDeleteEmployee(deleteEmp);
            DialogResult dialogResult = MessageBox.Show("Would you like to delete this Employee?", "Delete Employee", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Employees.DeleteEmployee(deleteEmp);
            }
        }

        private void employeeDeleteIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteEmployeePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void editEmployee_Click(object sender, EventArgs e)
        {
            if (Utilities.CheckIsNum(editEmployeeTextBox.Text))
            {
                editEmp.SetEmployeeId(int.Parse(editEmployeeTextBox.Text));
                Searcher employeeSearcher = new Searcher(editEmp);
                //If the employee is found
                if(employeeSearcher.FindEmployee())
                {
                    createEmployeeScreen = new yearsOfServiceTextBox(editEmp);
                    createEmployeeScreen.Show();
                }
                else
                {
                    UserNotFound();
                }
            }
            else
            {
                UserNotFound();
            }
        }

        private void editEmployeePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void createEmployee_Click(object sender, EventArgs e)
        {
            createEmployeeScreen = new yearsOfServiceTextBox();
            createEmployeeScreen.Show();
        }

        private void closeAllWindows_Click(object sender, EventArgs e)
        {
            Program.CloseLogin();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
