using System.Collections.Generic;

namespace KafeSiparis
{
    class Masa
    {
        public double toplamTutar { get; set; }

        public List<Siparis> siparisler = new List<Siparis>();

        public Masa()
        {
            siparisler = new List<Siparis>();
        }



    }
}
