using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    //Property - özellikler
    //classların 1. kullanımı özellik tutucu ( bir nesne yapısı oluştururken )
    public class Urun
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public double UrunFiyati { get; set; }
        public string Aciklama { get; set; }
    }
}
