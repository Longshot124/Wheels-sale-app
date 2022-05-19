using Product_Order.Models;
using System;
using System.Collections.Generic;

namespace Product_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            //public static Product productTest = new Product();

            Product product1 = new Product("Monoblock R18 Aero II",1800,10);
            Product product2 = new Product("Vossen cv3",2500,3);
            Product product3 = new Product("Vossen HF-5",3000,1); 
            Product product4 = new Product("Lider",700,20);
           

            List<Product> Products = new List<Product>();

            Products.Add(product1);
            Products.Add(product2);
            Products.Add(product3);
            Products.Add(product4);


            Console.WriteLine("Welcome to Market");

            Order order = new Order();
            int selection;
            int selection2;
            do
            {
                Console.WriteLine("Please choose one of them");
                Console.WriteLine("1 - Monoblock R18 Aero II 1800 AZN");
                Console.WriteLine("2 - Vossen CV3 2500 AZN");
                Console.WriteLine("3 - Vossen HF5 3000 AZN");
                Console.WriteLine("4 - Please indicate the Total Price");
                selection = int.Parse(Console.ReadLine());

                switch (selection)
                {
                    case 1:
                        Console.WriteLine(" Choose how much you want to buy:");
                        selection2 = int.Parse(Console.ReadLine());
                        order.Sale(product1, selection2);
                        break;
                    case 2:
                        Console.WriteLine(" Choose how much you want to buy:");
                        selection2 = int.Parse(Console.ReadLine());
                        order.Sale(product2, selection2);
                        break;
                    case 3:
                        Console.WriteLine(" Choose how much you want to buy:");
                        selection2 = int.Parse(Console.ReadLine());
                        order.Sale(product3, selection2);
                        break;
                    case 4:
                        order.Discount();




                        break;


                    default:
                        break;
                }



            } while (selection > 0 && selection < 4);

        }
            
    }
}
