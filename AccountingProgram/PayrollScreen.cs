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
    public partial class PayrollScreen : Form
    {

        private Payroll searchPayroll = new Payroll();

        private Payroll editPayroll = new Payroll();

        private Payroll deletePayroll = new Payroll();

        public PayrollScreen()
        {
            InitializeComponent();
            HideObjects();
        }

        private void HideObjects()
        {
            editPayrollPanel.Visible = false;
            deletePayrollPanel.Visible = false;
            processPayrollPanel.Visible = false;
        }

        private void ValidData()
        {
            if (!Utilities.CheckIsNum(payrollHoursSearchTextBox.Text))
            {
                payrollHoursSearchTextBox.ResetText();
            }
        }

        private void SearchPayroll()
        {
            Searcher searcherPayroll = new Searcher(searchPayroll);
            if(searcherPayroll.FindPayroll())
            {
                viewPayrollTextBox.Text = searcherPayroll.SearchPayrollDatabase();
            }
            else
            {
                PayrollNotFound();
            }


        }

        private void BuildSearchPayroll()
        {
            Employees searchEmployee = new Employees();
            if (employeeNameSearchTextBox.Text != "")
            {
                searchEmployee.SetName(employeeNameSearchTextBox.Text);
                Searcher employeeSearcher = new Searcher(searchEmployee);
                if(employeeSearcher.FindEmployee())
                {
                    searchPayroll.SetEmployee(searchEmployee);
                }
            }
            else if(employeeNameSearchTextBox.Text == "")
            {
                searchEmployee.SetName("null");
            }
            if(Utilities.CheckIsNum(payrollHoursSearchTextBox.Text))
            {
                searchPayroll.SetHoursWorked(int.Parse(payrollHoursSearchTextBox.Text));
            }
            else
            {
                searchPayroll.SetHoursWorked(-1);
            }
        }

        private void PayrollNotFound()
        {
            MessageBox.Show("Payroll was not found");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PayrollScreen_Load(object sender, EventArgs e)
        {

        }

        private void editPayrollRadio_CheckedChanged(object sender, EventArgs e)
        {
            HideObjects();
            editPayrollPanel.Visible = true;
        }

        private void deletePayrollId_CheckedChanged(object sender, EventArgs e)
        {
            HideObjects();
            deletePayrollPanel.Visible = true;
        }

        private void runPayrollRadio_CheckedChanged(object sender, EventArgs e)
        {
            HideObjects();
            processPayrollPanel.Visible = true;
        }

        private void employeeNameSearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void payrollHoursSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ValidData();
        }

        private void deletePayrollButton_Click(object sender, EventArgs e)
        {

        }
    }
}
