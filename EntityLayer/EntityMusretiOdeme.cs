using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityMusretiOdeme
    {
        int _id;
        int _MusteriId;
        decimal _Odenen;
        int _BorcId;
        DateTime _OdemeTarihi;

        public int Id { get => _id; set => _id = value; }
        public int MusteriId { get => _MusteriId; set => _MusteriId = value; }
        public decimal Odenen { get => _Odenen; set => _Odenen = value; }
        public int BorcId { get => _BorcId; set => _BorcId = value; }
        public DateTime OdemeTarihi { get => _OdemeTarihi; set => _OdemeTarihi = value; }
    }
}
