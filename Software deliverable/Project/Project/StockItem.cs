using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class StockItem
    {

        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int MinQuantity { get; set; }
        public string Category { get; set; }

        public StockItem(int itemID,string itemName,double price,string description,int quantity, int minquantity,string category)
        {
            this.ItemID = itemID;
            this.ItemName = itemName;
            this.Price = price;
            this.Description = description;
            this.Quantity = quantity;
            this.MinQuantity = minquantity;
            this.Category = category;
        }
        public override string ToString()
        {
            return $"{ItemID},{ItemName},{Price},{Quantity},{Category}";
        }
    }
}
