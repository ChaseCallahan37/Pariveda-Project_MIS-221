using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingProgram
{
    internal static class Program
    {
        private static LoginPage loginPage;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {
            //Get the databases ready
            UserDatabase.SetUserDatabase(FileHandler.PullFile(FileHandler.GetUserFileName()));
            Invoices.SetInvoiceDatabase(FileHandler.PullFile(FileHandler.GetInvoiceFileName()));
            ItemsDatabase.SetItemsDatabase(FileHandler.PullFile(FileHandler.GetItemFileName()));
            Employees.SetEmployeesDatabase(FileHandler.PullFile(FileHandler.GetEmployeeFileName()));
            Payroll.SetPayrollDatabase(FileHandler.PullFile(FileHandler.GetPayrollFileName()));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            loginPage = new LoginPage();
            Application.Run(loginPage);
        }

        public static void CloseLogin()
        {
            DialogResult dialogResult = MessageBox.Show("Would you like to close the program?", "Close Program", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                loginPage.Close();
            }
        }
    }
}
