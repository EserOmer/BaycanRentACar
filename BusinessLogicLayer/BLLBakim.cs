using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using FacadeLayer;

namespace BusinessLogicLayer
{
    public class BLLBakim
    {
        public static int Ekle(EntityBakim deger)
        {
            if (deger.BakimTutari != null && deger.AracId != null)
            {
                return FacadeBakim.Ekle(deger);
            }
            return -1;
        }
        public static bool Guncelle(EntityBakim deger)
        {
            if (deger.BakimTutari != null && deger.AracId != null)
            {
                return FacadeBakim.Guncelle(deger);
            }
            return false;
        }
        public static List<EntityBakim> Listele()
        {
            return FacadeBakim.BakimListele();
        }
        public static List<EntityBakim> ListeleTek(int Plaka)
        {
            return FacadeBakim.BakimListeleTek(Plaka);
        }
    }
}
