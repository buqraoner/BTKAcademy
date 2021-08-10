using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Eskişehir";
            customer.Id = 1;
            customer.FirstName = "Buğra";
            customer.LastName = "Öner";

            Customer customer2 = new Customer
            {
                Id = 2,
                City = "istanbul",
                FirstName = "Laylaylom",
                LastName = "Huhuhu"
            };
            
            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer2.FirstName);
            Console.WriteLine(customer2.LastName);
            Console.ReadLine();
        }

    }

    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added");

        }
        public void Update()
        {
            Console.WriteLine("Customer Uptaded");
        }
    }



}
