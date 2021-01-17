using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityBakim
    {
        int _id;
        int _AracId;
        DateTime _GirisTarihi;
        DateTime _CikisTarihi;
        string _YapilanYer;
        decimal _BakimTutari;
        decimal _NakitOdeme;
        string _Aciklama;
        string _Plaka;

        public int Id { get => _id; set => _id = value; }
        public int AracId { get => _AracId; set => _AracId = value; }
        public DateTime GirisTarihi { get => _GirisTarihi; set => _GirisTarihi = value; }
        public DateTime CikisTarihi { get => _CikisTarihi; set => _CikisTarihi = value; }
        public string YapilanYer { get => _YapilanYer; set => _YapilanYer = value; }
        public decimal BakimTutari { get => _BakimTutari; set => _BakimTutari = value; }
        public string Aciklama { get => _Aciklama; set => _Aciklama = value; }
        public decimal NakitOdeme { get => _NakitOdeme; set => _NakitOdeme = value; }
        public string Plaka { get => _Plaka; set => _Plaka = value; }
    }
}
