using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AccountingProgram
{
    internal class FileHandler
    {

        private static string UserFileName = @"C:\Users\chase\OneDrive - The University of Alabama\School\UA 2022 Spring\MIS 221\Projects\Pariveda\AccountingProgram.sn\AccountingProgram\TextFiles\Users.txt";

        private static string InvoiceFileName = @"C:\Users\chase\OneDrive - The University of Alabama\School\UA 2022 Spring\MIS 221\Projects\Pariveda\AccountingProgram.sn\AccountingProgram\TextFiles\Invoices.txt";

        private static string ItemFileName = @"C:\Users\chase\OneDrive - The University of Alabama\School\UA 2022 Spring\MIS 221\Projects\Pariveda\AccountingProgram.sn\AccountingProgram\TextFiles\Items.txt";

        private static string EmployeeFileName = @"C:\Users\chase\OneDrive - The University of Alabama\School\UA 2022 Spring\MIS 221\Projects\Pariveda\AccountingProgram.sn\AccountingProgram\TextFiles\Employees.txt";

        private static string PayrollFileName = @"C:\Users\chase\OneDrive - The University of Alabama\School\UA 2022 Spring\MIS 221\Projects\Pariveda\AccountingProgram.sn\AccountingProgram\TextFiles\Payroll.txt";
        public static List<string> PullFile(string fileName)      //Reads in the entire file, saves it to a list, then returns it
        {
            List<string> entireFile = new List<string>();
            StreamReader inFile = new StreamReader($"{fileName}");
            string line = inFile.ReadLine();

            while (line != null)
            {
                entireFile.Add(line);
                line = inFile.ReadLine();
            }
            inFile.Close();
            return entireFile;
        }

        public static void SaveFile(List<string> entireFile, string fileName)           //Saves the file after receiving a list
        {
            StreamWriter outFile = new StreamWriter($"{fileName}");
            foreach (string line in entireFile)
            {
                outFile.WriteLine(line);
            }
            outFile.Close();
        }

        public static string GetUserFileName()
        {
            return UserFileName;
        }

        public static string GetInvoiceFileName()
        {
            return InvoiceFileName;
        }

        public static string GetItemFileName()
        {
            return ItemFileName;
        }

        public static string GetEmployeeFileName()
        {
            return EmployeeFileName;
        }

        public static string GetPayrollFileName()
        {
            return PayrollFileName;
        }
    }
}
