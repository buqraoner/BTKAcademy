﻿using System;

namespace MutlakDeger
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("|{0}| = {1}", n, Sayi.MutlakDeger(n));

            
        }
    }
}
