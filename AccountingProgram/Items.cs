using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingProgram
{
    internal class Items
    {

        private string name;

        private string description;

        private double price;

        private int quantity;



        public Items(string[] temp)
        {
            name = temp[0];
            description = temp[1];
            price = double.Parse(temp[2]);
        }

        public Items(string itemName, int quantity)
        {
            name = itemName;
            this.quantity = quantity;
        }

        public Items(Items item)
        {
            name = item.GetName();
            description = item.GetDescription();
            price = item.GetPrice();
        }

        public Items(string itemName)       //Construct a new item and set the name to the name that is received
        {
            Items currItem = new Items();
            currItem.SetName(itemName);
            ItemsDatabase.BuildItem(currItem);    //Go find the item in the database and build it out if it is found
        }

        public Items()
        {

        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetDescription(string description)
        {
            this.description = description;
        }

        public string GetDescription()
        {
            return description;
        }

        public void SetPrice(double price)
        {
            this.price = price;
        }

        public double GetPrice()
        {
            return price;
        }

        public void SetQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public int GetQuantity()
        {
            return quantity;
        }

        public void FinishBuilding(Items item)      //Receive the item from the database list and finish building out the object
        {
            this.description = item.GetDescription();
            this.price = item.GetPrice();
        }

        public string GetLine()
        {
            return $"Name: {name}\tDescription{description}\tPrice: {price}\tQuantity: {quantity}\n";
        }

    }
}
