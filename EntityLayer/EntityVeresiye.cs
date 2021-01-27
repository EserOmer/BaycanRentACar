using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityVeresiye
    {
        int _Id;
        int _BakimId;
        decimal _Tutar;
        string _YapilanYer;
        decimal _BakimTutari;
        decimal _NakitOdeme;
        string _Aciklama;

        public int Id { get => _Id; set => _Id = value; }
        public decimal Tutar { get => _Tutar; set => _Tutar = value; }
        public int BakimId { get => _BakimId; set => _BakimId = value; }
        public string YapilanYer { get => _YapilanYer; set => _YapilanYer = value; }
        public decimal BakimTutari { get => _BakimTutari; set => _BakimTutari = value; }
        public decimal NakitOdeme { get => _NakitOdeme; set => _NakitOdeme = value; }
        public string Aciklama { get => _Aciklama; set => _Aciklama = value; }
    }
}
