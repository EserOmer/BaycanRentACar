using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityMusteriBorc
    {
        int _id;
        int _MusteriId;
        decimal _Borc;
        DateTime _BorcTarihi;
        int _AracId;

        public int Id { get => _id; set => _id = value; }
        public int MusteriId { get => _MusteriId; set => _MusteriId = value; }
        public decimal Borc { get => _Borc; set => _Borc = value; }
        public DateTime BorcTarihi { get => _BorcTarihi; set => _BorcTarihi = value; }
        public int AracId { get => _AracId; set => _AracId = value; }
    }
}
