using System;
using System.Collections.Generic;
using System.Text;

namespace Product_Order.Models
{

    class Order
    {
        public double Totalprice;
        public DateTime Date;

        public Order()
        {
            Date = DateTime.Now;
        }
        public void Sale(Product product, int count)
        {

            double price = product.Price * count;
            Totalprice += price;
            Console.WriteLine($" The Cart price is { Math.Round(Totalprice)} AZN");
        }

        public void Discount()
        {
            Predicate<double> nodiscount = Totalprice => Totalprice <= 100;
            Predicate<double> discount10 = Totalprice => Totalprice > 100 && Totalprice < 200;
            Predicate<double> discount20 = Totalprice => Totalprice >= 200;
            if (nodiscount(Totalprice))
            {
                Console.WriteLine($" There is no discount -  {Math.Round(Totalprice)} \n Thanks for shopping");
            }
            if (discount10(Totalprice))
            {
                Totalprice = Totalprice - Totalprice * 10 / 100;
                Console.WriteLine($" 10 % discount -  {Math.Round(Totalprice)} \n Thanks for shopping");
            }
            if (discount20(Totalprice))
            {
                Totalprice = Totalprice - Totalprice * 10 / 100;
                Console.WriteLine($" 20 % discount -  {Math.Round(Totalprice)} \n Thanks for shopping");
            }
            Console.WriteLine(Date);

        }
    }
}
