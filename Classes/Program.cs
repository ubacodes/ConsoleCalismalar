using System;
// Classları değişkenlerden farklı olarak bir yapıyı tutmak için kullanıyoruz. (birden fazla değişkenin barınabildiği yapılar)
// değişkenler = tek veri tipinde değerleri tutar
// classlar = birden fazla veri tipinde değişkenlerin bulunduğu yapıları tutar. küme gibi

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();    //oluşturduğumuz class yapısından örnek bir nesne türettik adına kurs1 dedik (yapısı içerisinde Kurs classı içerisinde belirlediğimiz özellikleri olmalı)
            kurs1.kursAdi = "Java";
            kurs1.kursUcreti = 0.0;
            kurs1.kursEgitmeni = "Engin Demiroğ";
            kurs1.kursİzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "C#";
            kurs2.kursUcreti = 0.0;
            kurs2.kursEgitmeni = "Umut B. Alpan";
            kurs2.kursİzlenmeOrani = 77;

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "Python";
            kurs3.kursUcreti = 0.0;
            kurs3.kursEgitmeni = "Kerem Varış";
            kurs3.kursİzlenmeOrani = 81;

            //Console.WriteLine(kurs1.kursAdi + " : " + kurs2.kursEgitmeni);

            //Kurs veri tipinde bir array oluştur bu arrayin ismi kurslar olsun elemanları ise kurs1, kurs2 ve kurs3 nesnesi olsun.
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };


            int sira = 0;
            foreach (Kurs item in kurslar)
            {
                //Kurs veri tipinde alias = item olacak şekilde kurslar arrayini dön, sırasıyla satırlardaki gibi kursAdi özelliğini, kursUcreti özelliğini ... gibi istediğim özellikleri kullanıcıya sunabilirim.
                Console.WriteLine((sira + 1).ToString() + " KursAdi : " + item.kursAdi);
                Console.WriteLine((sira + 1).ToString() + " KursEğitmeni : " + item.kursEgitmeni);
                Console.WriteLine((sira + 1).ToString() + " KursİzlenmeOrani : " + item.kursİzlenmeOrani);
                sira++;
            }
            

        }

        class Kurs  // sanki sen kendi veri tipini yazıyormuşsun gibi düşün
        {
            public string kursAdi { get; set; }     //prop = property = özellik diye bahsederiz. bunlar bizim class yapımız için belirlediğimiz temel yapının özellikleridir.
            public double kursUcreti { get; set; }      //get = çağırılabilir  set = düzenlenebilir
            public string kursEgitmeni { get; set; }
            public int kursİzlenmeOrani { get; set; }
        }
    }
}

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");