using System;


namespace ConsoleCalismalar
{
    class Program
    {
        static void Main(string[] args)
        {
            //degiskenlerin tanımlanması
            string kategoriEtiketi = "Kategori:";
            string seciliKategori = "Yazılım Geliştirme";
            string ogrenciSayisiEtiketi = "Kayıtlı Öğrenciler:";
            bool sistemeGirisYapmisMi = true;
            string username = "admin";
            
            //--------- kullanıcı ile etkileşim basit writeline komutları
            int ogrenciSayisi = 31938;
            Console.WriteLine(kategoriEtiketi + seciliKategori);
            Console.WriteLine(ogrenciSayisiEtiketi + ogrenciSayisi.ToString() +"\n");

            //---------

            //--------- mantıksal değişken ile basit şartlı yapı if - else
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Hoşgeldiniz:" + username +"\n"+ "Kullanıcı ayarları butonu." +"\n");
            }
            else
            {
                Console.WriteLine("Sisteme Giriş Yapınız."+"\n");
            }
            //---------

            //---------- if - else
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Düşüş oku <--" +"\n");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Yükseliş  oku --> " + "\n");
            }
            else { Console.WriteLine(" -- "); }

            //---------

        }
    }
}


// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
