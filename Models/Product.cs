using System;
using System.Collections.Generic;
using System.Text;

namespace Product_Order.Models
{
    public class Product
    {
        public string Name;
        public double Price;
        public int Count;
        public List<Product> Products;

        public Product()
        {

        }

        public Product(string name, double price,int count)
        {
            Name = name;
            Price = price;
            Count = count;
        }

        public void ShowAllProducts() 
        {
                foreach (Product product in Products)
                {
                         Console.WriteLine(product);
                   // Console.WriteLine($"Name : {item.Name} \n Price : {item.Price} \n Count : {item.Count}");
                }

          
        }
    }
}
