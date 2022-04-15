using System;
//Döngüleri, birbirine benzeyen işlemleri tekrar etmek için kullanırız. - Bir şeyleri tekrar etmek için kullanılan yapılardır.

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array = dizi
            // Miktarı sürekli değişkenlik gösteren benzer yapıdaki nesnelerimizi diziler yardımıyla tanımlarız ve her defasında her yerde tüm nesneler için kendimizi tekrar etmekten kurtarırız. Örn: e-Ticaret sitesi için ürünler bir array yapıda olabilir.
            string[] kurslar = new string[] { "yazılım geliştirici yetiştirme kampı", "java kampı", "python kursu", "yazılıma yeni başlayanlar kursu", "ileri seviye .net kursu", "api geliştirme kursu", "CS öğren" };

            // for döngüsü ile dinamik bir yapı oluşturma örneği
            for (int i = 0; i < kurslar.Length; i++)    // i isminde integer veri türünde bi değişken tanımla değeri 0 olsun, i < 10 şartını sağladığı sürece döngü devam etsin, i değerini her döngü turunda 1 tane arttır.
            {
                Console.WriteLine(i+1 + " : " +kurslar[i]);
            }
            Console.WriteLine("for döngüsü tamamlandı." + "\n");

            // foreach döngüsü
            // alias = takma isim
            int sira = 0;
            foreach (string kurs in kurslar) // string veri türünde kurs adında bir geçici değişken tanımla bu değişken sırası ile kurslar(array) 'ın elemanlarını dönsün
            {
                Console.WriteLine((sira+1).ToString()+ " : " + kurs);
                sira++;
            }
            Console.WriteLine("foreach döngüsü tamamlandı." + "\n");
        }
    }
}




// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
