using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingProgram
{
    internal class Invoices
    {
        private static int invoiceIdCount;

        private static List<Invoices> invoiceDatabase = new List<Invoices>();

        private int id;

        private string customerName;

        private DateTime dateSold;

        private DateTime dateDue;

        private List<Items> invoiceItems = new List<Items>();

        private double invoiceTotal;

        public Invoices()
        {

        }

        public Invoices(string line)
        {
            string[] temp = line.Split('#');
            id = int.Parse(temp[0]);
            SetHighestInvoiceID();
            customerName = temp[1];
            dateSold = DateTime.Parse(temp[2]);
            dateDue = DateTime.Parse(temp[3]);

            //Take the list of items that were sold, which are comma delimites, set them to the itemsSold var,
            //Then split them up into an array, then construct the items and add them to the list

            string tempItems = temp[4];
            string[] allItemsSold = tempItems.Split(',');      //Each item is delimited via a comma

            foreach (string singleItem in allItemsSold)
            {
                //Split each item to where the first spot in temp2 is the item name and the second is its quantity
                string[] temp2 = singleItem.Split('!');
                Items currItem = new Items();
                currItem.SetName(temp2[0]);
                currItem.SetQuantity(int.Parse(temp2[1]));
                ItemsDatabase.BuildItem(currItem);
                invoiceItems.Add(currItem);      //Returns a built item for each item name that it is given and adds it to the list
            }
            invoiceTotal = double.Parse(temp[5]);
        }

        public static void SetInvoiceIdCount(int num)
        {
            invoiceIdCount = num;
        }

        public static int GetInvoiceIdCount()
        {
            return invoiceIdCount;
        }

        public static void SetInvoiceDatabase(List<string> entireFile)
        {
            foreach(string line in entireFile)
            {
                invoiceDatabase.Add(new Invoices(line));
            }
        }

        public static List<Invoices> GetInvoicesDatabase()
        {
            return invoiceDatabase;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return id;
        }

        public void SetCustomerName(string customerName)
        {
            this.customerName = customerName;
        }

        public string GetCustomerName()
        {
            return customerName;
        }

        public void SetDateSold(DateTime date)
        {
            dateSold = date;
        }

        public DateTime GetDateSold()
        {
            return dateSold;
        }

        public void SetDateDue(DateTime date)
        {
            dateDue = date;
        }

        public DateTime GetDateDue()
        {
            return dateDue;
        }

        public void AddInvoiceItem(Items newItem)
        {
            invoiceItems.Add(newItem);
        }

        public void SetInvoiceItems(List<Items> myList)
        {
            invoiceItems = myList;
        }

        public List<Items> GetInvoiceItems()
        {
            return invoiceItems;
        }

        public void SetInvoiceTotal(double invoiceTotal)
        {
            this.invoiceTotal = invoiceTotal;
        }

        public double GetInvoiceTotal()
        {
            return invoiceTotal;
        }

        public string ToFileLine()
        {
            string fileLine = "";
            fileLine += $"{id}#{customerName}#{dateSold.ToString()}#{dateDue.ToString()}#";
            int count = 0;
            foreach(Items item in invoiceItems)
            {
                if(count > 0)
                {
                    fileLine += ",";
                }
                fileLine += $"{item.GetName()}!{item.GetQuantity()}";
                count++;
            }
            fileLine += $"#{invoiceTotal}";
            return fileLine;
        }

        public static List<string> ToFileDatabase()
        {
            List<string> entireFile = new List<string>();
            foreach(Invoices currInvoice in invoiceDatabase)
            {
                entireFile.Add(currInvoice.ToFileLine());
            }
            return entireFile;
        }


        public string ToStringDisplay()
        {
            string invoiceLine;
            invoiceLine = $"Id: {id, -5}Customer Name: {customerName, -15}Date Due: {dateDue.ToString("M"), -13}Invoice Total: ${invoiceTotal,-10}Items Sold & Quantity: ";
            int count = 0;
            foreach( Items item in invoiceItems)
            {
                if(count > 0)
                {
                    invoiceLine += $"\r\n{"", 112}";
                }
                string addToInvoice = $"{item.GetName()} X {item.GetQuantity()}";
                invoiceLine += $"{addToInvoice, -13}";
                count++;
            }
            return invoiceLine;

        }

        public static void AddToInvoiceDatabase(Invoices newInvoice)
        {
            invoiceDatabase.Add(newInvoice);

        }

        public static bool RemoveFromInvoiceDatabase(Invoices delInvoice)
        {
            foreach (Invoices currInvoice in invoiceDatabase)
            {
                if (delInvoice.GetId() == currInvoice.GetId())
                {
                    invoiceDatabase.Remove(currInvoice);
                    FileHandler.SaveFile(ToFileDatabase(), FileHandler.GetInvoiceFileName());
                    return true;
                }
            }
            return false;
        }

        public int CompareToID(Invoices currInvoice)
        {
            if (id < currInvoice.GetId())
            {
                return -1;
            }
            else if (id > currInvoice.GetId())
            {
                return 1;
            }
            return 0;
        }
        public int CompareToID(int id)
        {
            if(this.id < id)
            {
                return -1;
            }
            else if(this.id > id)
            {
                return 1;
            }
            return 0;
        }

        public int CompareToName(Invoices myInvoice)
        {
            return customerName.CompareTo(myInvoice.GetCustomerName());
        }

        public int CompareToName(string customerName)
        {
            return this.customerName.CompareTo(customerName);
        }

        public void CreateId()
        {
            IncInvoiceIdCount();
            id = invoiceIdCount;
        }

        public static void IncInvoiceIdCount()
        {
            invoiceIdCount++;
        }

        public void SetHighestInvoiceID()
        {
            if (invoiceIdCount < id)
            {
                invoiceIdCount = id;
            }
        }

        public void BuildInvoice(Invoices currInvoice)
        {
            id = (currInvoice.GetId());
            customerName = (currInvoice.GetCustomerName());
            dateSold = (currInvoice.GetDateSold());
            dateDue = (currInvoice.GetDateDue());
            invoiceItems = (currInvoice.GetInvoiceItems());
            invoiceTotal = (currInvoice.GetInvoiceTotal());
        }

       








    }
}
