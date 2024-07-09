using System;

namespace MyNamespace
{
    class Program
    {
        public static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp Hosgeldiniz.";
            string degisken2 = "CSharp";

            // length

            Console.WriteLine(degisken.Length);

            // toupper, tolower

            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            // concat
            Console.WriteLine(String.Concat(degisken,"halil özcan"));

            //Compare CompareTo

            Console.WriteLine(degisken.CompareTo(degisken2)); // 0,1,-1 değerleri döndürür.

            Console.WriteLine(String.Compare(degisken, degisken2, true)); // true = küçük büyük harf duyarsız demek; false = tam tersi işlem;

            // Contains
            Console.WriteLine(degisken.Contains(degisken2)); // iki değişkendeki aynı olan kelimenin var olup olamdığını kontrol ediyor.

            Console.WriteLine(degisken.EndsWith("Hosgeldiniz."));
            Console.WriteLine(degisken.StartsWith("merhaba"));

            // indexof

            Console.WriteLine(degisken.IndexOf("CSharp"));

            //insert

            Console.WriteLine(degisken.Insert(0, "merhaba"));

            Console.WriteLine(degisken.LastIndexOf("i"));

            // padLeft padRight

            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30, '*'));
            Console.WriteLine(degisken.PadRight(50) + degisken2);
            Console.WriteLine(degisken.PadRight(50, '*') + degisken2);

            // remove

            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));//5.indexten başla 3 karakter sil
            Console.WriteLine(degisken.Remove(0,1));//0. indexten başla 1 karakter sil yani baştaki ilk harfi silme

            // Replace

            Console.WriteLine(degisken.Replace('a', 'x'));
            Console.WriteLine(degisken.Replace("CSharp", "Halil"));

            //Split

            Console.WriteLine(degisken.Split(' ')[1]);

            // substring

            Console.WriteLine(degisken.Substring(5));
            Console.WriteLine(degisken.Substring(4,5));



        }
    }
}