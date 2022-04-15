using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    //class'ın 2.kullanımı : bir operasyon tutucu olarak kullanıyoruz
    public class SepetManager
    {
        //metot tanımı
        // naming convention
        //metotlar reusebility = tekrar tekrar kullanılabilirlik imkanı verir.
        public void Ekle(Urun urun)
        {
            
            Console.WriteLine("Sepete eklendi : " + urun.UrunAdi);
        }
    }
}
