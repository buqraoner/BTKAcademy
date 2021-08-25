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



		int i = 23;
		object o = i;

		i *= 2; //i = i*2
		i = (int) o; // cast 
		Console.WriteLine("Deger turu: {0}",i)
			Console.WriteLine("Referans turu:{0}",o);










           

	}
}
