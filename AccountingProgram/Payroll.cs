using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingProgram
{
    internal class Payroll
    {
        private static int payrollIdCount;

        private static List<Payroll> payrollDatabase = new List<Payroll>();

        private int payrollId;

        private Employees employee = new Employees();

        private DateTime datePaid;

        private double hoursWorked = 40;

        private double paycheckTotal;

        public Payroll()
        {

        }

        public Payroll(Employees employee)
        {
            this.employee = employee;
            this.hoursWorked = 40;
            this.paycheckTotal = hoursWorked * employee.GetRate();
        }

        public Payroll(string line)
        {
            string[] temp = line.Split('#');
            payrollId = int.Parse(temp[0]);
            employee.SetEmployeeId(int.Parse(temp[1]));
            Searcher empSearcher = new Searcher(employee);
            empSearcher.FindEmployee();
            datePaid = DateTime.Parse(temp[2]);
            hoursWorked = double.Parse(temp[3]);
            paycheckTotal = double.Parse(temp[4]);
            CheckHighestId();
        }

        public static void SetPayrollDatabase(List<string> entireFile)
        {
            foreach(string line in entireFile)
            {
                payrollDatabase.Add(new Payroll(line));
            }
        }

        public static List<Payroll> GetPayrollDatabase()
        {
            return payrollDatabase;
        }

        public void SetPayrollId(int payrollId)
        {
            this.payrollId = payrollId;
        }

        public int GetPayrollId()
        {
            return payrollId;
        }

        public void SetEmployee(Employees employee)
        {
            this.employee = employee;
        }

        public Employees GetEmployee()
        {
            return employee;
        }

        public void SetHoursWorked(double hoursWorked)
        {
            this.hoursWorked = hoursWorked;
        }

        public double GetHoursWorked()
        {
            return hoursWorked;
        }

        public void SetPaycheckTotal()
        {
            paycheckTotal = employee.GetRate() * hoursWorked;
        }

        public double GetPaycheckTotal()
        {
            return employee.GetRate() * hoursWorked;
        }

        public string ToStringDisplay()
        {
            string toPrint = $"Payroll ID: {payrollId, -5}Employee ID: {employee.GetEmployeeId().ToString(), -5}Employee Name: {employee.GetName(), -20}Date Paid: {datePaid.ToString("M"), -8}Hours Worked: {hoursWorked.ToString(), -5}Paycheck Total: {paycheckTotal, -8}";

            return toPrint;
        }

        public string ToFileLine()
        {
            return $"{payrollId.ToString()}#{employee.GetEmployeeId()}#{datePaid.ToString("M")}#{hoursWorked.ToString()}#{paycheckTotal.ToString()}";

        }

        public static List<string> ToFileDatabase()
        {
            List<string> entireFile = new List<string>();
            foreach(Payroll currPayroll in payrollDatabase)
            {
                entireFile.Add(currPayroll.ToFileLine());
            }
            return entireFile;
        }

        public static void CreatePayroll()
        {
            foreach(Employees currEmployee in Employees.GetEmployeesDatabase())
            {
                payrollDatabase.Add(new Payroll(currEmployee));
            }
        }

        public  void CheckHighestId()
        {
            if(payrollIdCount < payrollId)
            {
                payrollIdCount = payrollId;
            }
        }
    }
}
