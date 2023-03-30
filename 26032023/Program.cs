using System;

namespace _26032023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Mehsulun melumatlarini daxil edin : ");

            //Console.WriteLine("Mehsulun adini qeyd edin :");
            //string name = Console.ReadLine();

            //Console.WriteLine("Mehsulun qiymetini daxil edin");
            //double price;
            //string priceStr = Console.ReadLine();

            //while (!double.TryParse(priceStr, out price) || price <= 0)
            //{
            //    Console.WriteLine("Daxil etdiyiniz qiymetin formati duzgun deyil!!!");
            //    priceStr = Console.ReadLine();
            //}

            Product product = new Product
            {
                Name = "Book",
                Price = 100
            };

            product.DiscountedPercent = 10;
            Console.WriteLine(product.DiscountedPrice);
            //product.DiscountedPrice = 12;
            //product.SetPrice(-12);
            //Console.WriteLine(product.GetPrice());
            //product.Price = -10;
            //product.Age = -17;
            //Console.WriteLine(product.Price);
            //Console.WriteLine(product.Age);
            //product.Name = "Absbs";
            //Console.WriteLine(product.Name);
            product.GetInfo();

        }
    }
}
