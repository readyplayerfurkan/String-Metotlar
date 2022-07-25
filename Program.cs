using System;

namespace stringMetotlar
{
    class Program
    {
        public static void Main(string[] args)
        {
            // String Metotları

            string deger1 = "Merhaba! Dersimiz C Sharp. Hoşgeldiniz!";
            string deger2 = "Dersimiz C Sharp. Hoşgeldiniz!";

            // Length / string değerin uzunluğunu dönüyor.

            Console.WriteLine(deger1.Length);

            // ToUpper, ToLower / string değer içerisinde tüm harfleri büyük/küçük yapıyor.

            Console.WriteLine(deger1.ToLower());
            Console.WriteLine(deger1.ToUpper());

            // Concat / 2 farklı string değerini birleştiriyor.

            Console.WriteLine(string.Concat(deger1, deger2));

            // Compare, CompareTo / 2 farklı string değerini karşılıştırıyor. Girilen değer hedef değerden büyükse 1, eşitse 0, küçükse -1 döndürüyor.

            Console.WriteLine(deger1.CompareTo(deger2));
            Console.WriteLine(string.Compare(deger2, deger1, true));

            // Contains / Bir string değer içerisinde başka bir alt değer aranıyor.

            Console.WriteLine(deger1.Contains(deger2));
            Console.WriteLine(deger2.StartsWith("Dersimiz"));
            Console.WriteLine(deger2.EndsWith("C Sharp"));

            // IndexOf / String içerisinde bir karakteri veya bir kelimeyi arıyor ve onun başlangıç indeksini veriyor.

            Console.WriteLine(deger1.IndexOf(deger2));
            Console.WriteLine(deger1.LastIndexOf("i")); // Seçilen karakterin veya kelimenin string içerisinde en sondaki değerin indeksini dönüyor.

            // Insert / Bir string içerisine kelime veya harf ekliyor.

            Console.WriteLine(deger2.Insert(0, "Merhaba! "));

            // PadLeft, PadRight / String değerin sağına veya soluna istediğimiz bir karakteri istediğimiz miktarda doldurabiliyoruz.

            Console.WriteLine(deger1.PadRight(32) + deger2);
            Console.WriteLine(deger1.PadLeft(20));
            Console.WriteLine(deger1 + deger2.PadLeft(40, '*'));
            Console.WriteLine(deger1.PadRight(15, ' ') + deger2);

            // Remove / Belirlenen indeksten itibaren karakter çıkartır.

            Console.WriteLine(deger1.Remove(9));
            Console.WriteLine(deger1.Remove(9, 5));

            // Replace / Seçilen karakter ile belirlenen bir karakteri yer değiştiriyor.

            Console.WriteLine(deger1.Replace("C Sharp", "C#"));

            // Split / Stringi belirlenen bir ayırtaç ile parçalara bölüyor.

            Console.WriteLine(deger1.Split(' ')[3]);

            // Substring / Seçilen indexten itibaren değeri alır ve yeni bir string değere atar.

            Console.WriteLine(deger1.Substring(9));
            Console.WriteLine(deger1.Substring(9, 8));


        }
    }
}