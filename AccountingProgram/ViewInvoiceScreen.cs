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
    public partial class viewInvoiceScreen : Form
    {

        private static CreateInvoiceScreen createInvoiceScreen = new CreateInvoiceScreen();

        private Invoices searchInvoices = new Invoices();

        private Invoices editInvoices = new Invoices();

        private Invoices delInvoices = new Invoices();


        public viewInvoiceScreen()
        {
            InitializeComponent();
            HideObjects();
        } 
        public void HideObjects()
        {
            deleteInvoicePanel.Visible = false;
            editInvoicePanel.Visible = false;
            createInvoicePanel.Visible = false;
        }

        private void InvoiceNotFound()
        {
            MessageBox.Show("Invoice not found");
        }

        private void DisplaySearch()
        {
            BuildSearchInvoice();
            Searcher invoiceSearcher = new Searcher(searchInvoices);
            //Searches the database of invoices that match dependent on
            //containing name and returns them
            viewTextBox.Text = invoiceSearcher.SearchInvoiceDatabase();
            
        }

        private void BuildSearchInvoice()
        {
            if(searchInvoiceTextBox.Text != "")
            {
                searchInvoices.SetCustomerName(searchInvoiceTextBox.Text);
            }
            else
            {
                searchInvoices.SetCustomerName("");
            }    
            
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void viewTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void searchInvoiceTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void clearButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void deleteInvoiceButton_Click(object sender, EventArgs e)
        {
            if (Utilities.CheckIsNum(invoiceDeleteIdTextBox.Text))
            {
                delInvoices.SetId(int.Parse(invoiceDeleteIdTextBox.Text));
                Searcher invoiceSearcher = new Searcher(delInvoices);
                if(invoiceSearcher.FindInvoice())
                {
                    createInvoiceScreen = new CreateInvoiceScreen(delInvoices);
                    createInvoiceScreen.Show();
                }
                else
                {
                    invoiceDeleteIdTextBox.ResetText();
                    InvoiceNotFound();
                }
            }
            else
            {
                invoiceDeleteIdTextBox.ResetText();
                InvoiceNotFound();
            }
                
        }

        private void idInvoiceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void editInvoiceButton_Click(object sender, EventArgs e)
        {
            if (Utilities.CheckIsNum(editInvoiceIdTextBox.Text))
            {
                editInvoices.SetId(int.Parse(editInvoiceIdTextBox.Text));
                Searcher invoiceSearcher = new Searcher(editInvoices);
                if (invoiceSearcher.FindInvoice())
                {
                    createInvoiceScreen = new CreateInvoiceScreen(editInvoices);
                    createInvoiceScreen.Show();
                }
                else
                {
                    editInvoiceIdTextBox.ResetText();
                    InvoiceNotFound();
                }
            }
            else
            {
                editInvoiceIdTextBox.ResetText();
                InvoiceNotFound();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void createInvoiceButton_Click(object sender, EventArgs e)
        {
            createInvoiceScreen = new CreateInvoiceScreen();
            createInvoiceScreen.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplaySearch();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void closeAllWindows_Click(object sender, EventArgs e)
        {

            Program.CloseLogin();
        }

        private void editInvoiceButton_Click_1(object sender, EventArgs e)
        {
            if(Utilities.CheckIsNum(editInvoiceIdTextBox.Text))
            {
                editInvoices.SetId(int.Parse(editInvoiceIdTextBox.Text));
                Searcher invoiceSearcher = new Searcher(editInvoices);
                if(invoiceSearcher.FindInvoice())
                {
                    createInvoiceScreen = new CreateInvoiceScreen(editInvoices);
                    createInvoiceScreen.Show();
                }
                else
                {
                    InvoiceNotFound();
                }
            }
            else
            {
                InvoiceNotFound();
            }
            
        }

        private void editEmployeeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void editInvoiceRadio_CheckedChanged(object sender, EventArgs e)
        {
            HideObjects();
            editInvoicePanel.Visible = true;
        }

        private void deleteInvoiceRadio_CheckedChanged(object sender, EventArgs e)
        {
            HideObjects();
            deleteInvoicePanel.Visible = true;
        }

        private void createInvoiceRadio_CheckedChanged(object sender, EventArgs e)
        {
            HideObjects();
            createInvoicePanel.Visible = true;
        }

        private void searchLabel_Click(object sender, EventArgs e)
        {

        }

        private void employeeDeleteIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void createInvoiceButton_Click_1(object sender, EventArgs e)
        {
            createInvoiceScreen = new CreateInvoiceScreen();
            createInvoiceScreen.Show();
        }

        private void deleteInvoiceButton_Click_1(object sender, EventArgs e)
        {
            if(Utilities.CheckIsNum(invoiceDeleteIdTextBox.Text))
            {
                delInvoices.SetId(int.Parse(invoiceDeleteIdTextBox.Text));
                Searcher invoiceSearcher = new Searcher(delInvoices);
                if(invoiceSearcher.FindInvoice())
                {
                    Invoices.RemoveFromInvoiceDatabase(delInvoices);
                    MessageBox.Show("Invoice Deleted");
                }
                else
                {
                    InvoiceNotFound();
                }
            }
            else
            {
                InvoiceNotFound();
            }
            
        }

        private void searchPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
