using System;

public class Class1
{
	public Class1()
	{
		maks = System.Int16.MaxValue;
		mins = System.Int16.MinValue;
		int sayi = 23;
		sayi = sayi * 2;

		Console.Write(sayi);

		int maks, mins;
		Console.WriteLine(sayi);
		Console.WriteLine("INT16 =>Min : {0} \t Mak:{1}",
			mins, maks);

		//kututututututututlama

		int i = 23;
		object o = i;

		i *= 2; //i = i*2
		i = (int) o; // cast 
		Console.WriteLine("Deger turu: {0}",i)
			Console.WriteLine("Referans turu:{0}",o);
  // const
  //readonly

   		counst double pi = 3.1428;
			Double alan,r;

			Console.WriteLine("r =");
			r=Convert.ToDouble(Console.Readline());
			
			alan = pi*r*r;
			Console.WriteLine("R{0} icin alan = {1}",r,alan)
			Console.Read();



			










           

	}
}
