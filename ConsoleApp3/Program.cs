using System;

namespace HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            double sonuc;
            // İlk sayıyı al
            Console.Write("Birinci sayı: ");
            string sayi1_str = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(sayi1_str))
            {
                Console.WriteLine("Lütfen bir sayı girin!");
                Console.Write("Birinci sayı: ");
                string sayi1_str1 = Console.ReadLine();
                //kkkkkkkk
            }
            double sayi1 = Convert.ToDouble(sayi1_str);

            // İkinci sayıyı al
            Console.Write("İkinci sayı: ");
            string sayi2_str = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(sayi2_str))
            {
                Console.WriteLine("Lütfen bir sayı girin!");
                Console.ReadKey();
                return;
            }

            double sayi2 = Convert.ToDouble(sayi2_str);

            // İşlem seçeneğini al
            Console.WriteLine("İşlem Seçeneği:");
            Console.WriteLine("1- Toplama");
            Console.WriteLine("2- Çıkarma");
            Console.WriteLine("3- Çarpma");
            Console.WriteLine("4- Bölme");
            Console.Write("Seçiminiz: ");
            string secim_str = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(secim_str))
            {
                Console.WriteLine("Lütfen bir seçim yapın!");
                Console.ReadKey();
                return;
            }
            int secim = Convert.ToInt32(secim_str);

            // Sonucu hesapla ve yazdır
            switch (secim)
            {
                case 1:
                    Console.WriteLine("{0} + {1} = {2}", sayi1, sayi2, sayi1 + sayi2);
                    break;
                case 2:
                    Console.WriteLine("{0} - {1} = {2}", sayi1, sayi2, sayi1 - sayi2);
                    break;
                case 3:
                    Console.WriteLine("{0} * {1} = {2}", sayi1, sayi2, sayi1 * sayi2);
                    break;
                case 4:
                    if (sayi2 == 0)
                    {
                        Console.WriteLine("Bölen sıfır olamaz!");
                        Console.ReadKey();
                        return;
                    }
                    Console.WriteLine("{0} / {1} = {2}", sayi1, sayi2, sayi1 / sayi2);
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim!");
                    break;

                    Console.WriteLine("Sonuç: " + sonuc);

                    Console.WriteLine("Çıkış yapmak için q tuşuna basın, devam etmek için herhangi bir tuşa basın.");
                    if (Console.ReadKey().Key == ConsoleKey.Q) ;
            }
           

            Console.ReadKey();
        }
    }
}