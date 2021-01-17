using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntitySigorta
    {
        int _id;
        DateTime _Baslangic;
        DateTime _Bitis;
        int _AracId;
        decimal _Tutar;
        string _Plaka;

        public int Id { get => _id; set => _id = value; }
        public DateTime Baslangic { get => _Baslangic; set => _Baslangic = value; }
        public DateTime Bitis { get => _Bitis; set => _Bitis = value; }
        public int AracId { get => _AracId; set => _AracId = value; }
        public decimal Tutar { get => _Tutar; set => _Tutar = value; }
        public string Plaka { get => _Plaka; set => _Plaka = value; }
    }
}
