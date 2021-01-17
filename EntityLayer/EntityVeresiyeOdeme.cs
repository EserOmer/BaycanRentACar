using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityVeresiyeOdeme
    {
        int _id;
        DateTime _OdemeTarihi;
        decimal _Tutar;
        string _Acıklama;

        public int Id { get => _id; set => _id = value; }
        public DateTime OdemeTarihi { get => _OdemeTarihi; set => _OdemeTarihi = value; }
        public decimal Tutar { get => _Tutar; set => _Tutar = value; }
        public string Acıklama { get => _Acıklama; set => _Acıklama = value; }
    }
}
