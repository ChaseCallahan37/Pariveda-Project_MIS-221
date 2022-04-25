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
    public partial class yearsOfServiceTextBox : Form
    {

        private Employees newEmployee = new Employees();
        
        private Employees delEmployee = new Employees();
        public yearsOfServiceTextBox()
        {
            InitializeComponent();
            delEmployee.SetEmployeeId(-1);
        }
        public yearsOfServiceTextBox(Employees employee)
        {
            InitializeComponent();
            delEmployee.BuildEmployee(employee);
            FillOutForm();
        }

        private void FillOutForm()
        {
            nameTextBox.Text = delEmployee.GetName();
            yearsServiceTextBox.Text = (delEmployee.GetYearsOfService()).ToString();
            deptComboBox.Text = delEmployee.GetDept();
            payRateTextBox.Text = delEmployee.GetRate().ToString();
            if(delEmployee.GetIsSalary())
            {
                salaryRadio.PerformClick();
            }
            else
            {
                hourlyRadio.PerformClick();
            }
        }

        private bool CreateNewEmployee()
        {
            //pulls in info from form to make new user
            //if there is a user to be deleted, function returns true
            bool deleteOldEmployee; 
            if(delEmployee.GetEmployeeId() == -1)
            {
                newEmployee.CreateId();
                deleteOldEmployee = true;
            }
            else
            {
                newEmployee.SetEmployeeId(delEmployee.GetEmployeeId());
                deleteOldEmployee = false;
            }
            newEmployee.SetName(nameTextBox.Text);
            newEmployee.SetYearsOfService(int.Parse(yearsServiceTextBox.Text));
            newEmployee.SetDept(deptComboBox.Text);
            if(salaryRadio.Checked)
            {
                newEmployee.SetIsSalary(true);
            }
            else if(hourlyRadio.Checked)
            {
                newEmployee.SetIsSalary(false);
            }
            return deleteOldEmployee;
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateEmployeeScreen_Load(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Employees.AddEmployee(newEmployee);
            //If there is an employee to be deleted
            if (!CreateNewEmployee())
            {
                Employees.DeleteEmployee(delEmployee);
            }
            FileHandler.SaveFile(Employees.ToFileDatabase(), FileHandler.GetEmployeeFileName());
            MessageBox.Show("Employee Database Updated");
            this.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void payRateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void yearsServiceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
