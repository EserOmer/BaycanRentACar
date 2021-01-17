using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityKiradaOlanArac
    {
        int _id;
        int _AracId;
        int _MusteriId;
        DateTime _BaslangicTarihi;
        DateTime _TeslimTarihi;
        string _TeslimYakit;
        decimal _GunlukTutar;
        decimal EkstraUcret;
        decimal _ToplamTutar;
        Boolean _OdemeSekli;
        decimal _OdenenTutar;
        string _Aciklama;
        int _VerilisKm;
        int _IadeKm;

        public int Id { get => _id; set => _id = value; }
        public int AracId { get => _AracId; set => _AracId = value; }
        public int MusteriId { get => _MusteriId; set => _MusteriId = value; }
        public DateTime BaslangicTarihi { get => _BaslangicTarihi; set => _BaslangicTarihi = value; }
        public DateTime TeslimTarihi { get => _TeslimTarihi; set => _TeslimTarihi = value; }
        public string TeslimYakit { get => _TeslimYakit; set => _TeslimYakit = value; }
        public decimal GunlukTutar { get => _GunlukTutar; set => _GunlukTutar = value; }
        public decimal EkstraTutar { get => EkstraUcret; set => EkstraUcret = value; }
        public decimal ToplamTutar { get => _ToplamTutar; set => _ToplamTutar = value; }
        public Boolean OdemeSekli { get => _OdemeSekli; set => _OdemeSekli = value; }
        public decimal OdenenTutar { get => _OdenenTutar; set => _OdenenTutar = value; }
        public string Aciklama { get => _Aciklama; set => _Aciklama = value; }
        public int VerilisKm { get => _VerilisKm; set => _VerilisKm = value; }
        public int IadeKm { get => _IadeKm; set => _IadeKm = value; }
    }
}
