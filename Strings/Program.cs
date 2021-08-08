using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "My name is Buğra Öner";

            var result = sentence.Length;
            var result2 = sentence.Clone();

            sentence = "My name is Abc";
            Console.WriteLine(result2);
            

            bool result3 = sentence.EndsWith("r");
            bool result4 = sentence.StartsWith("My name");
            
            var result5 = sentence.IndexOf("name");
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");
            var result8 = sentence.Insert(0,"Hello, "); //0 karakterden itibaren" Hello, " EKLE
            var result9 = sentence.Substring(3,4);
            //metni parçalamak
            var result10 = sentence.ToLower();
            var result11 = sentence.ToUpper();
            // var result12 = sentence.Replace("", "");
            var result13 = sentence.Remove(2,5);

            
            Console.WriteLine(result13);
            Console.ReadLine();
            // bitimi

            // başlangıc 
            // aramak
        }



    }

}
