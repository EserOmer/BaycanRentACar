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
        int _VeresiyeId;
        DateTime _OdemeTarihi;
        decimal _OdemeTutar;
        string _Aciklama;

        public int Id { get => _id; set => _id = value; }
        public DateTime OdemeTarihi { get => _OdemeTarihi; set => _OdemeTarihi = value; }
        public decimal OdemeTutar { get => _OdemeTutar; set => _OdemeTutar = value; }
        public string Aciklama { get => _Aciklama; set => _Aciklama = value; }
        public int VeresiyeId { get => _VeresiyeId; set => _VeresiyeId = value; }
    }
}
