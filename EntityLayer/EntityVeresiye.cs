using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityVeresiye
    {
        int _id;
        int _BakimId;
        decimal _Tutar;

        public int Id { get => _id; set => _id = value; }
        public decimal Tutar { get => _Tutar; set => _Tutar = value; }
        public int BakimId { get => _BakimId; set => _BakimId = value; }
    }
}
