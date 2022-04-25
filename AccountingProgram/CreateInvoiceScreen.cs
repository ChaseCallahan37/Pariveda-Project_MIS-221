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
    internal partial class CreateInvoiceScreen : Form
    {
        private double invoiceTotal = 0;

        private Invoices currInvoice = new Invoices();

        private Invoices delInvoice = new Invoices();

        private bool runDelete = false;
        public CreateInvoiceScreen(Invoices oldInvoice)
        {
            InitializeComponent();
            delInvoice = oldInvoice;
            FillInvoice();
            runDelete = true;
        }

        public CreateInvoiceScreen()
        {
            InitializeComponent();
            delInvoice.SetId(-1);
            currInvoice.CreateId();
        }

        public void CloseWindow()
        {
            this.Close();
        }

        private void FillInvoice()
        {
            customerNameTextBox.Text = delInvoice.GetCustomerName();
            dateSoldMenu.Text = delInvoice.GetDateSold().ToString();
            dateDuePicker.Text = delInvoice.GetDateDue().ToString();

            foreach (Items item in delInvoice.GetInvoiceItems())
            {
                if(item.GetName() == "luxury bag")
                {
                    luxBagQuanTextBox.Text = item.GetQuantity().ToString();
                }
                else if(item.GetName() == "standard bag")
                {
                    stanBagQuanTextBox.Text = item.GetQuantity().ToString();
                }
                else if(item.GetName()== "deluxe bag")
                {
                    delBagQuanTextBox.Text = item.GetQuantity().ToString();
                }
            }
            currInvoice.SetId(delInvoice.GetId());
        }

        private void PullFormInfo()
        {
            currInvoice.SetCustomerName(customerNameTextBox.Text.ToLower());
            currInvoice.SetDateSold(DateTime.Parse(dateSoldMenu.Text));
            currInvoice.SetDateDue(DateTime.Parse(dateDuePicker.Text));
            if (luxBagQuanTextBox.Text != "")
            {
                Items newItem = new Items("luxury bag", int.Parse(luxBagQuanTextBox.Text));
                ItemsDatabase.BuildItem(newItem);
                currInvoice.AddInvoiceItem(newItem);
            }
            if (stanBagQuanTextBox.Text != "")
            {
                Items newItem = new Items("standard bag", int.Parse(stanBagQuanTextBox.Text));
                ItemsDatabase.BuildItem(newItem);
                currInvoice.AddInvoiceItem(newItem);
            }
            if (delBagQuanTextBox.Text != "")
            {
                Items newItem = new Items("deluxe bag", int.Parse(delBagQuanTextBox.Text));
                ItemsDatabase.BuildItem(newItem);
                currInvoice.AddInvoiceItem(newItem);
            }
            currInvoice.SetInvoiceTotal(double.Parse(invoiceTotalLabel.Text));
        }


        private bool ContinueToSave()       //Checks to see if it is okay to continue on to save
        {
            if(customerNameTextBox.Text == "")
            {
                return false;
            }
            if(DateTime.Parse(dateDuePicker.Text) == DateTime.Today)
            {
                return false;
            }
            if(luxBagQuanTextBox.Text == null && stanBagQuanTextBox.Text == null && delBagQuanTextBox.Text == null)
            {
                return false;
            }
            if(luxBagQuanTextBox.Text == null && luxBagQuanTextBox.Text == "")
            {
                return false;
            }
            if (stanBagQuanTextBox.Text == null && stanBagQuanTextBox.Text == "")
            {
                return false;
            }
            if (delBagQuanTextBox.Text == null && delBagQuanTextBox.Text == "")
            {
                return false;
            }
            return true;
        }

        
        private void CreateInvoiceScreen_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void createInvoiceHeaderLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dateSoldTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateDueTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void luxBagQuanTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!((Utilities.CheckIsNum(luxBagQuanTextBox.Text)) || luxBagQuanTextBox.Text == ""))    //If it is not convertible then
            {
                luxBagQuanTextBox.ResetText();
                MessageBox.Show("Please enter a number");
            }
            else
            {
                if ((Utilities.CheckIsNum(luxBagQuanTextBox.Text)))
                {
                    Items currItem = new Items();
                    currItem.SetName("luxury bag");
                    ItemsDatabase.BuildItem(currItem);
                    double total = currItem.GetPrice() * double.Parse(luxBagQuanTextBox.Text);
                    luxuryBagTotal.Text = total.ToString();
                }
                else
                {
                    luxuryBagTotal.ResetText();
                }
                
            }
        }

        private void stanBagQuanTextBox_TextChanged(object  sender, EventArgs e)
        {
            if (!((Utilities.CheckIsNum(stanBagQuanTextBox.Text)) || stanBagQuanTextBox.Text == ""))    //If it is not convertible then
            {
                stanBagQuanTextBox.ResetText();
                MessageBox.Show("Please enter a number");
            }
            else
            {
                if ((Utilities.CheckIsNum(stanBagQuanTextBox.Text)))
                {
                    Items currItem = new Items();
                    currItem.SetName("standard bag");
                    ItemsDatabase.BuildItem(currItem);
                    double total = currItem.GetPrice() * double.Parse(stanBagQuanTextBox.Text);
                    standardBagTotal.Text = total.ToString();
                }
                else
                {
                    standardBagTotal.ResetText();
                }

            }
        }

        private void delBagQuanTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!((Utilities.CheckIsNum(delBagQuanTextBox.Text)) || delBagQuanTextBox.Text == ""))    //If it is not convertible then
            {
                delBagQuanTextBox.ResetText();
                MessageBox.Show("Please enter a number");
            }
            else
            {
                if ((Utilities.CheckIsNum(delBagQuanTextBox.Text)))
                {
                    Items currItem = new Items();
                    currItem.SetName("deluxe bag");
                    ItemsDatabase.BuildItem(currItem);
                    double total = currItem.GetPrice() * double.Parse(delBagQuanTextBox.Text);
                    deluxeBagTotal.Text = total.ToString();
                }
                else
                {
                    deluxeBagTotal.ResetText();
                }

            }
        }

        private void luxuryBagTotal_Click(object sender, EventArgs e)
        {
               
        }

        private void standardBagTotal_Click(object sender, EventArgs e)
        {
            double price = ItemsDatabase.SearchForPrice("standard bag");
            if(stanBagQuanTextBox.Text != null && stanBagQuanTextBox.Text != "")
            {
                //Convert the quantity box to a double and multiply it by the price, then convert it to a string, then display it
                double total = price * double.Parse(stanBagQuanTextBox.Text);
                standardBagTotal.Text = total.ToString();

            }
        }

        private void deluxeBagTotal_Click(object sender, EventArgs e)
        {

        }

        private void invoiceTotalLabel_Click(object sender, EventArgs e)
        {
            invoiceTotalLabel.Text = invoiceTotal.ToString();
            
        }

        private void saveIncoiceButton_Click(object sender, EventArgs e)
        {
            if(ContinueToSave())
            {
                PullFormInfo();
                Invoices.AddToInvoiceDatabase(currInvoice);
                if(runDelete)
                {
                    Invoices.RemoveFromInvoiceDatabase(delInvoice);
                }
                FileHandler.SaveFile(Invoices.ToFileDatabase(), FileHandler.GetInvoiceFileName());
                MessageBox.Show("Invoice Saved");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill out all the required fields");
            }
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateSoldMenu_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateDuePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double luxTotal = 0;
            double stanTotal = 0;
            double delTotal = 0;
            if (luxBagQuanTextBox.Text != "")
            {
                luxTotal = double.Parse(luxuryBagTotal.Text);
            }
            if (stanBagQuanTextBox.Text != "")
            {
                stanTotal = double.Parse(standardBagTotal.Text);
            }
            if (delBagQuanTextBox.Text != "")
            {
                delTotal = double.Parse(deluxeBagTotal.Text);
            }
            invoiceTotal = luxTotal + stanTotal + delTotal;
            invoiceTotalLabel.Text = invoiceTotal.ToString();
        }

        private void overallPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
