using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingProgram
{
    internal class Searcher
    {

        private static List<Employees> employeeDatabase = Employees.GetEmployeesDatabase();

        private static List<Payroll> payrollDatabase = Payroll.GetPayrollDatabase();

        private static List<Invoices> invoicesDatabase = Invoices.GetInvoicesDatabase();

        private Invoices searchInvoice = new Invoices();

        private Employees searchEmployee = new Employees();

        private Payroll searchPayroll = new Payroll();

        public Searcher()
        {

        }

        public Searcher(Employees searchEmployee)
        {
            this.searchEmployee = searchEmployee;
        }

        public Searcher(Payroll searchPayroll)
        {
            this.searchPayroll = searchPayroll;
        }
        
        public Searcher(Invoices searchInvoice)
        {
            this.searchInvoice = searchInvoice;
        }

        public Employees GetSearchEmployee()
        {
            return searchEmployee;
        }

        public Payroll GetSearchPayroll()
        {
            return searchPayroll;
        }

        public Invoices GetSearchInvoice()
        {
            return searchInvoice;
        }

        public string SearchEmployeeDatabase()
        {
            //Searches for employees that contain any similar information as the search employee
            string toPrint = "";
            string underLine = "";
            for (int i = 0; i < 149; i++)
            {
                underLine += "_";
            }
            foreach (Employees curremployee in employeeDatabase)
            {
                if(searchEmployee.GetEmployeeId() == -1)
                {
                    if (curremployee.GetName().Contains(searchEmployee.GetName())
                    && curremployee.GetDept().Contains(searchEmployee.GetDept()))
                    {
                        toPrint += $"{curremployee.ToStringDisplay()} \r\n";
                    }
                }
                else
                {
                    if (curremployee.GetName().Contains(searchEmployee.GetName())
                    && curremployee.GetDept().Contains(searchEmployee.GetDept())
                    && curremployee.GetEmployeeId() == searchEmployee.GetEmployeeId())
                    {
                        toPrint += $"{curremployee.ToStringDisplay()}\r\n";
                    }
                }
                toPrint += $"{underLine}";
            }
            return toPrint;
        }

        public bool FindEmployee()
        {
            //tries to build the employee, returns true if built and fasle if not
            foreach(Employees currEmployee in employeeDatabase)
            {
                if(currEmployee.GetEmployeeId() == searchEmployee.GetEmployeeId())
                {
                    searchEmployee.BuildEmployee(currEmployee);
                    return true;
                }
            }
            return false;
        }

        public string SearchPayrollDatabase()
        {
            string toPrint = "";

            foreach(Payroll currPayroll in payrollDatabase)
            {
                if(currPayroll.GetPayrollId() == searchPayroll.GetPayrollId())
                {

                }
            }

            return toPrint;
        }

        public bool FindPayroll()
        {
            foreach(Payroll currPayroll in payrollDatabase)
            {
                if (searchPayroll.GetHoursWorked() == currPayroll.GetHoursWorked())
                {
                    searchPayroll = currPayroll;
                }
            }
            return false;
        }

        public bool FindInvoice()
        {
            foreach(Invoices currInvoice in invoicesDatabase)
            {
                if(currInvoice.GetId() == searchInvoice.GetId())
                {
                    searchInvoice.BuildInvoice(currInvoice);
                    return true;
                }
            }
            return false;
        }

        public string SearchInvoiceDatabase()
        {
            string toPrint = "";
            foreach(Invoices currInvoice in invoicesDatabase)
            {
                if(currInvoice.GetCustomerName().Contains(searchInvoice.GetCustomerName()))
                {
                    string underline = "";
                    string line = $"{currInvoice.ToStringDisplay()}";
                    for(int i = 0; i < 150; i++)
                    {
                        underline += "_";
                    }
                    toPrint += $"{line}\r\n{underline}";
                }
            }
            return toPrint;
        }
    }
}
