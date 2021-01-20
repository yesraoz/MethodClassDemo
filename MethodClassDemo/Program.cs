using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MethodClassDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 11111;
            customer1.Name = "Esra Öz";
            customer1.TCNo = 11111111111;
            customer1.City = "Aydýn";

            Customer customer2 = new Customer();
            customer2.Id = 22222;
            customer2.Name = "Seminay Civciv";
            customer2.TCNo = 22222222222;
            customer2.City = "Bursa";

            Customer customer3 = new Customer();
            customer3.Id = 33333;
            customer3.Name = "Batuhan Panda";
            customer3.TCNo = 33333333333;
            customer3.City = "Eskiþehir";

            Customer customer4 = new Customer();
            customer4.Id = 44444;
            customer4.Name = "Özgür Kuþ";
            customer4.TCNo = 44444444444;
            customer4.City = "Ýzmir";

            Customer customer5 = new Customer();
            customer5.Id = 55555;
            customer5.Name = "Tuðçe Sincap";
            customer5.TCNo = 55555555555;
            customer5.City = "Antalya";


            Customer[] musteriler = new Customer[] { customer1, customer2, customer3};


            CustomerManagement Management = new CustomerManagement();



            Management.List(musteriler);
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("  ");


            Console.WriteLine("________________");
            Management.Add(customer4);
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("  ");

            Console.WriteLine("________________");
            Management.Remove(customer5);
        }

    }
}
