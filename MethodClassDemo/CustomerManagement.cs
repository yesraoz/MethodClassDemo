using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MethodClassDemo
{
    public class CustomerManagement
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("MÜŞTERİ EKLENDİ. BİLGİLERİ;");
            Console.WriteLine("________________");
            Console.WriteLine("Müşteri Numarası: " + customer.Id);
            Console.WriteLine("Müşteri Adı Soyadı: " + customer.Name);
            Console.WriteLine("Müşteri T.C. Kimlik No: " + customer.TCNo);
            Console.WriteLine("Müşteri Sehir: " + customer.City);
            Console.WriteLine("________________");
        }
        public void Remove(Customer customer)
        {
            Console.WriteLine("MÜŞTERİ AYRILDI. BİLGİLERİ;");
            Console.WriteLine("________________");
            Console.WriteLine("Müşteri Numarası: " + customer.Id);
            Console.WriteLine("Müşteri Adı Soyadı: " + customer.Name);
            Console.WriteLine("Müşteri T.C. Kimlik No: " + customer.TCNo);
            Console.WriteLine("Müşteri Sehir: " + customer.City);
            Console.WriteLine("________________");
        }
        public void List(Customer[] customer)
        {
            Console.WriteLine("MÜŞTERİLERİN LİSTESİ;");
            Console.WriteLine("_______________");
            foreach (Customer list in customer)
            {
                Console.WriteLine("________________");
                Console.WriteLine("Müşteri Numarası: " + list.Id);
                Console.WriteLine("Müşteri Adı Soyadı: " + list.Name);
                Console.WriteLine("Müşteri T.C. Kimlik No: " + list.TCNo);
                Console.WriteLine("Müşteri Sehir: " + list.City);
                Console.WriteLine("________________");
            }
        }
    }
}
