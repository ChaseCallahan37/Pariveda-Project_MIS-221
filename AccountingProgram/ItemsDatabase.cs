using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingProgram
{
    internal class ItemsDatabase
    {

        private static List<Items> itemsDatabase = new List<Items>();

        

        public static void SetItemsDatabase(List<string> entireFile)
        {
            foreach (string line in entireFile)
            {
                string[] temp = line.Split('#');
                itemsDatabase.Add(new Items(temp));        //Add each invoice by creating a new invoice by giving it the line from the file and allowing the constructor to build the invoice
            }
        }

        public static List<Items> GetItemsDatabase()
        {
            return itemsDatabase;
        }

        public static void AddItem(Items newItem)
        {
            itemsDatabase.Add(newItem);
        }

        //Give this method an item to see it it exitst, if it does, then the item in the datbase will be used to construct a new item
        //and set it equal to the current item
        public static void BuildItem(Items currItem)  
        {
            foreach (Items item in itemsDatabase)
            {
                string word1 = currItem.GetName();
                string word2 = item.GetName();
                int r = word1.CompareTo(word2);
                
                if(r == 0)
                {
                    
                    //Give Finish building the item that has the other variable data to finish building out the object
                    currItem.FinishBuilding(item);     
                }
            }
        }

        public static double SearchForPrice(string itemName)        //Searches for the item and then returns the price
        {
            Items currItem = new Items(itemName);
            BuildItem(currItem);
            return currItem.GetPrice();
        }

        public static string DisplayAllItems()
        {
            string toPrint = "";

            foreach (Items item in itemsDatabase)
            {
                toPrint += item.GetLine();
                toPrint += "\r\n";
            }

            return toPrint;
        }

        




    }
}
