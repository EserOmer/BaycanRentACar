using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using FacadeLayer;

namespace BusinessLogicLayer
{
    public class BLLKasko
    {
        public static int Ekle(EntityKasko deger)
        {
            if (deger.Baslangic != null && deger.Bitis != null && deger.Tutar != null)
            {
                return FacadeKasko.Ekle(deger);
            }
            return -1;
        }
        public static bool Guncelle(EntityKasko deger)
        {
            if (deger.Baslangic != null && deger.Bitis != null && deger.Tutar != null)
            {
                return FacadeKasko.Guncelle(deger);
            }
            return false;
        }
        public static List<EntityKasko> Listele()
        {
            return FacadeKasko.KaskoListele();
        }
        public static EntityKasko ListeleTek(int deger)
        {
            return FacadeKasko.KaskoListeleTek(deger);
        }
    }
}
