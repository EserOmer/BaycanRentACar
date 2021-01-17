using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using FacadeLayer;

namespace BusinessLogicLayer
{
    public class BLLVeresiye
    {
        public static int Ekle(EntityVeresiye deger)
        {
            if (deger.BakimId != null)
            {
                return FacadeVeresiye.Ekle(deger);
            }
            return -1;
        }
        public static bool Guncelle(EntityVeresiye deger)
        {
            if (deger.BakimId != null)
            {
                return FacadeVeresiye.Guncelle(deger);
            }
            return false;
        }
        public static List<EntityVeresiye> Listele()
        {
            return FacadeVeresiye.VeresiyeListele();
        }
    }
}
