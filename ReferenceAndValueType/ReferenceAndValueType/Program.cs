using System;
using System.Data;

namespace ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;

            Console.WriteLine(number2);

            string[] cities1 = new string[] { "Ankara", "Adana", "Afyon" };//101
            string[] cities2 = new string[] { "Bursa", "Bolu", "Balıkesir" };//102
            cities2 = cities1; // 102// = 1011111111111111111 
                               //cities 2 = 101
            cities1[0] = "İstanbul";
            Console.WriteLine(cities2[0]);

            DataTable dataTable = new DataTable();
            DataTable dataTable2 = new DataTable();
            dataTable = dataTable2;
            Console.ReadLine();



        }
    }
}
