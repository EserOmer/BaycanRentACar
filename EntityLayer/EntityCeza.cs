using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityCeza
    {
        int _id;
        int _AracId;
        DateTime _Tarih;
        decimal _Tutar;
        Boolean _CezaDurum;
        string _Plaka;
        string _DURUM;

        public int Id { get => _id; set => _id = value; }
        public int AracId { get => _AracId; set => _AracId = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        public decimal Tutar { get => _Tutar; set => _Tutar = value; }
        public bool CezaDurum { get => _CezaDurum; set => _CezaDurum = value; }
        public string Plaka { get => _Plaka; set => _Plaka = value; }
        public string DURUM { get => _DURUM; set => _DURUM = value; }
    }
}
