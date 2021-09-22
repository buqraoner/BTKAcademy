using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayList();

            // List();

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");

            //Console.WriteLine(dictionary["table"]);
            // Console.WriteLine(dictionary["glass"]);

            foreach(var item in dictionary)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

          Console.WriteLine(dictionary.ContainsKey("glass"));
          Console.WriteLine(dictionary.ContainsKey("table"));

            Console.ReadLine();
        }






























        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }


            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, Firstname = "Engin" });
            customers.Add(new Customer { Id = 2, Firstname = "Derin" });

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Firstname);
            }
        }


        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");


            cities.Add("İstanbul");

            cities.Add(1);
            cities.Add('A');

            foreach (var city in cities)
            {
                Console.WriteLine(city);
         
            
            }
        }
        class Customer
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string Firstname { get; internal set; }
        }
        
    }
}
