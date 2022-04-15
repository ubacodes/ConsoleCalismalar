using System;

// metotlar = tekrar tekrar kullanılabilirliği sağlayan bir ortam sunuyor
// program içerisinde birden fazla yerde tekrar etmesi muhtemel işlemleri metotlar ile yönetiriz ki kendimizi programın her yerinde tekrar etmeyelim. SOLID prensiplerine uygun temiz kod yazalım
// nesne bazında

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();    //Urun class'ı içerisindeki tanımladığımız nesne yapısına uygun olan urun1 adında bi tane nesne türettik ve daha sonra bu nesnenin özelliklerini belirledik
            urun1.Id = 1;
            urun1.UrunAdi = "Elma";
            urun1.UrunFiyati = 34;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();    //Görüldüğü gibi aynı yapıda birden fazla nesne türetebiliriz. (e-Ticaret sitesindeki aynı kategori altındaki farklı markaların ürünlerini aynı sınıf yapısında türetebiliriz gibi)
            urun2.Id = 2;
            urun2.UrunAdi = "Armut";
            urun2.UrunFiyati = 13;
            urun2.Aciklama = "Bal armut";

            Urun urun3 = new Urun();
            urun3.Id = 3;
            urun3.UrunAdi = "Karpuz";
            urun3.UrunFiyati = 80;
            urun3.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunlerDizisi = new Urun[] {urun1, urun2, urun3};   //benzer yapıdaki nesneleri dizi yapısı içerisinde tutabiliyorduk. Aynı şekilde Urun class'ı yapısındaki birden fazla nesneyi bir dizi yapısı içerisinde barındırabiliriz.

            foreach (Urun item in urunlerDizisi)
            {
                Console.WriteLine("Ürünler dizisinin elemanı "+item.Id.ToString() + " : " +item.UrunAdi);
                Console.WriteLine("Ürünün fiyatı : " + item.UrunFiyati.ToString() + "₺");
            }
            Console.WriteLine("---------------------METOTLAR--------------------");

            SepetManager sepetManager = new SepetManager(); //SepetManager projesi içerisindeki class yapısından sepetManager isminde nesne türettik ki içeriğindeki metotları vs. yapıları kullanabilelim

            sepetManager.Ekle(urun2); // sepetManager class'ında tanımladığımız metodun içerisindeki işlemlerin yapılması için çağırdık. ( parametre alan bir metot olmadığı için Ekle(); olarak bıraktık fakat parametre girilen metotlar da olabilirdi.


        }
    }
}

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");