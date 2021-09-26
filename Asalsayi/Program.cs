using System;

namespace Asalsayi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}", 
                Sayi.AsalMi(n) ? "Asal sayidir." : "Asal sayi değildir!");
        }
    }
}
