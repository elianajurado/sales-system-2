using System;
using sales_system_2;

namespace sales_system
{
    class Program
    {
        private static float price;
        private static float average;

        static void Main(string[] args)
        {
            Store store = new Store();

            Seller a1 = new Seller();
            a1.name = "Jacob";
            a1.age = 33;
            store.AddSeller(a1);

            Seller a2 = new Seller();
            a2.name = "marian";
            a2.age = 27;
            store.AddSeller(a2);

            Seller a3 = new Seller();
            a3.name = "Harry";
            a3.age = 27;
            store.AddSeller(a3);

            Product b1 = new Product();
            b1.name = "Shampoo";
            b1.price = 22000;
            store.AddProduct(b1);

            Product b2 = new Product();
            b2.name = "Eye Shadow";
            b2.price = 259000;
            store.AddProduct(b2);

            Product b3 = new Product();
            b3.name = "Red Lipstick";
            b3.price = 25000;
            store.AddProduct(b3);

            Sale c1 = new Sale();
            c1.product = b1;
            c1.seller = a2;
            c1.comments = "Marian of 27 years old sold a Shampoo";
            store.AddSale(c1);

            Sale c2 = new Sale();
            c2.product = b2;
            c2.seller = a1;
            c1.comments = "Jacob of 33 years old sold an eye shwadow";
            store.AddSale(c2);

            Sale c3 = new Sale();
            c3.product = b3;
            c3.seller = a3;
            c3.comments = "Harry de 27 años, sold a lipstick";
            store.AddSale(c3);

            Console.Write("Sales amount total: " + price);
            price = b1.price + b2.price + b3.price;
            average = price / 3;

            Console.Write(" The products price average is: " + average);

            Console.Write(a2.name + " Sold the cheaper product, a shampoo of " + b2.price);

            Console.Write(" the most expensive product is" + b2.price);


        }
    }
}
