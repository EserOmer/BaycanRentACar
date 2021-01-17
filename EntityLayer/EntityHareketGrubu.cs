using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityHareketGrubu
    {
        int _id;
        int _AracId;
        int _KaskoId;
        int _SigortaId;
        int _VizeId;
        int _CezaId;
        int _BakimId;

        public int Id { get => _id; set => _id = value; }
        public int AracId { get => _AracId; set => _AracId = value; }
        public int KaskoId { get => _KaskoId; set => _KaskoId = value; }
        public int SigortaId { get => _SigortaId; set => _SigortaId = value; }
        public int VizeId { get => _VizeId; set => _VizeId = value; }
        public int CezaId { get => _CezaId; set => _CezaId = value; }
        public int BakimId { get => _BakimId; set => _BakimId = value; }
    }
}
