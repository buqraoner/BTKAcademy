using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //NewMethod(); //ForLoop
            // i++ , i+=2 ,i=i+2
            // NewMethod1(); // WhileLoop
            // NewMethod2(); // DoWhileLoop
           // NewMethod3(); // foreach
            if (IsPrimeNumber(6))
            {
                Console.WriteLine("This is prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }


            static bool IsPrimeNumber(int number)
            {
                bool result = true;
                for (int i = 2; i < number-1; i++)
                {
                    if (number%i==0)
                    {
                        result = false;
                        i = number;
                    }

                }
                return result;
            }

        }

      /*  private static void NewMethod3()
        {
            string[] students = new string[3] { "Engin", "Derin", "Salih" };
            foreach (var student in students)
            {

                Console.WriteLine(student);
            }
            Console.ReadLine();
        } */

        private static void NewMethod2()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            }
            while (number >= 0);
            Console.ReadLine();
        }

        private static void NewMethod1()
        {
            int number = 100;
            while (number >= 0)
            {

                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Now number is {0}");
        }

        private static void NewMethod()
        {
            for (int i = 1; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished!");
        }
    }
}
