using System;
using System.Collections.Generic;
using System.Text;

namespace Asalsayi
{
    class Sayi
    {
        public static bool AsalMi(int n)
        {
            if (n <=1)
            {
                Console.WriteLine("En kucuk asal sayi 2'dir");
                    return false;
            }

            bool kontrol = true;
            for(int i=2; i<n; i++)
            
                if (n % i == 0)
                {
                    kontrol = false;
                    break;
                }

            return kontrol;

            

        }
    }
}
