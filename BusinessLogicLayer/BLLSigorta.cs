using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using FacadeLayer;

namespace BusinessLogicLayer
{
    public class BLLSigorta
    {
        public static int Ekle(EntitySigorta deger)
        {
            if (deger.Baslangic != null && deger.Bitis != null && deger.Tutar != null)
            {
                return FacadeSigorta.Ekle(deger);
            }
            return -1;
        }
        public static bool Guncelle(EntitySigorta deger)
        {
            if (deger.Baslangic != null && deger.Bitis != null && deger.Tutar != null)
            {
                return FacadeSigorta.Guncelle(deger);
            }
            return false;
        }
        public static List<EntitySigorta> Listele()
        {
            return FacadeSigorta.SigortaListele();
        }
        public static EntitySigorta ListeleTek(int deger)
        {
            return FacadeSigorta.SigortaListeleTek(deger);
        }
    }
}
