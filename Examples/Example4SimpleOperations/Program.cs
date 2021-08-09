using System;

namespace Example4
{
    class Program
    {
        //SimpleOperations
        /* Please enter the first number: 5
        Please enter the second number: 10
             toplam: 15
             fark : -5
             carpim : 50
             bolum : 0.5
             kalan : 5 */
        static void Main(string[] args)
        {
            int number1, number2;
            Console.Write("Please enter the first number :");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the first number :");
            number2 = Convert.ToInt32(Console.ReadLine());

            int toplam,
                fark,
                carpim,
                kalan;

            decimal bolum;


            toplam = number1 + number2;
            fark   = number1 - number2;
            carpim = number1 * number2;
            kalan = number1 % number2;
            bolum = number1 / number2;

            Console.WriteLine("Toplam : {0}",toplam);
            Console.WriteLine("Fark : {0}",fark);
            Console.WriteLine("carpim : {0}",carpim);
            Console.WriteLine("Kalan : {0}",kalan);
            Console.WriteLine("Bölüm : {0}",bolum);
           
            


            
          


        }

    }
}
           