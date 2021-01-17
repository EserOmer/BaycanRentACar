using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityMusteri
    {
        int _id;
        string _AdSoyad;
        string _Telefon;
        string _Tc;
        string _SurucuSicilNo;
        string _Aciklama;

        public int Id { get => _id; set => _id = value; }
        public string AdSoyad { get => _AdSoyad; set => _AdSoyad = value; }
        public string Telefon { get => _Telefon; set => _Telefon = value; }
        public string Tc { get => _Tc; set => _Tc = value; }
        public string SurucuSicilNo { get => _SurucuSicilNo; set => _SurucuSicilNo = value; }
        public string Aciklama { get => _Aciklama; set => _Aciklama = value; }
    }
}
