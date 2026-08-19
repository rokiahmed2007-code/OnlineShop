using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Category { get; set; }

       
        Product(int ID,string Name,decimal Price) {
            this.ID = ID;
            this.Name = Name;
            this.Price = Price;
        }
        Product(int ID, string Name, decimal Price,int Stock,string Category) {
            this.ID = ID;
            this.Name = Name;
            this.Price = Price;
            this.Stock = Stock;
            this.Category = Category;
        }
        public void DisplayInfo()
        {

        Console.WriteLine($" Product Information \n Name: {Name}\n Price: {Price}\n Stock: {Stock}\n Category:{Category}");

        }

       public void AddStock(int amount)
        {
            if (amount > 0) { Stock += amount; }

            else { Console.WriteLine("Wrong Amount!!"); }
            
        }
        public void RemoveStock(int amount)
        {
            if (amount <= Stock && amount > 0)
            {
                Stock -= amount;
            }
            else
            {
                Console.WriteLine(" Not Enough Stock.");
            }
        }
       
    }
}
