using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingProgram
{
    public class Employees
    {

        private static List<Employees> employeesDatabase = new List<Employees>();

        private static int idCount;

        private int employeeId;

        private string name;

        private int yearsOfService;

        private string dept;

        private double rate;

        private bool isSalary;

        public Employees()
        {

        }

        public Employees(string line)
        {
            string[] temp = line.Split('#');
            employeeId = int.Parse(temp[0]);
            name = temp[1];
            yearsOfService = int.Parse(temp[2]);
            dept = temp[3];
            rate = double.Parse(temp[4]);
            isSalary = bool.Parse(temp[5]);
            CheckHighestId();
        }

        public static void SetEmployeesDatabase(List<string> entireFile)
        {
            foreach (string line in entireFile)
            {
                employeesDatabase.Add(new Employees(line));
            }
        }

        public static List<Employees> GetEmployeesDatabase()
        {
            return employeesDatabase;
        }

        public void SetEmployeeId(int employeeId)
        {
            this.employeeId = employeeId;
        }

        public int GetEmployeeId()
        {
            return employeeId;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetYearsOfService(int yearsOfService)
        {
            this.yearsOfService = yearsOfService;
        }

        public int GetYearsOfService()
        {
            return yearsOfService;
        }

        public void SetDept(string dept)
        {
            this.dept = dept;
        }

        public string GetDept()
        {
            return dept;
        }

        public void SetRate(double rate)
        {
            this.rate = rate;
        }

        public double GetRate()
        {
            return rate;
        }

        public void SetIsSalary(bool isSalary)
        {
            this.isSalary = isSalary;
        }

        public bool GetIsSalary()
        {
            return isSalary;
        }

        private void CheckHighestId()
        {
            if(idCount < employeeId)
            {
                idCount = employeeId;
            }
        }

        public static int GetIdCount()
        {
            return idCount;
        }

        public static void IncIdCount()
        {
            idCount++;
        }

        public void CreateId()
        {
            IncIdCount();
            employeeId = idCount;
        }

        public string ToStringDisplay()
        {
            string toPrint = $"Employee ID: {employeeId, -5}Name: {name, -20}Years Of Service: {yearsOfService, -5}Department: {dept, -20}Rate: {rate, -6}";
            if(isSalary)
            {
                toPrint += $"Compensation: Salary";
            }
            else
            {
                toPrint += $"Compensation: Hourly";
            }
            return toPrint;
        }

        public static List<string> ToFileDatabase()
        {
            List<string> entireFile = new List<string>();
            foreach(Employees currEmployee in employeesDatabase)
            {
                entireFile.Add(currEmployee.ToFileLine());
            }
            return entireFile;
        }

        public string ToFileLine()
        {
            return $"{employeeId}#{name}#{yearsOfService}#{dept}#{rate}#{isSalary}";
        }

        public void BuildEmployee(Employees currEmployee)
        {
            employeeId = currEmployee.GetEmployeeId();
            name = currEmployee.GetName();
            yearsOfService = currEmployee.GetYearsOfService();
            dept = currEmployee.GetDept();
            rate = currEmployee.GetRate();
            isSalary = currEmployee.GetIsSalary();

        }

        public static bool DeleteEmployee(Employees deleteEmployee)
        {
            foreach(Employees currEmployee in employeesDatabase)
            { 
                if(deleteEmployee.GetEmployeeId() == currEmployee.GetEmployeeId())
                {
                    employeesDatabase.Remove(currEmployee);
                    FileHandler.SaveFile(ToFileDatabase(), FileHandler.GetEmployeeFileName());
                    return true;
                }
            }
            return false;
        }

        public static void AddEmployee(Employees newEmployee)
        {
            employeesDatabase.Add(newEmployee);
        }
    }
}
