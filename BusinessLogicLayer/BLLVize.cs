using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using FacadeLayer;

namespace BusinessLogicLayer
{
    public class BLLVize
    {
        public static int Ekle(EntityVize deger)
        {
            if (deger.Baslangic!=null && deger.Bitis!=null &&deger.Tutar!=null)
            {
                return FacadeVize.Ekle(deger);
            }
            return -1;
        }
        public static bool Guncelle(EntityVize deger)
        {
            if (deger.Baslangic != null && deger.Bitis != null && deger.Tutar != null)
            {
                return FacadeVize.Guncelle(deger);
            }
            return false;
        }
        public static List<EntityVize> Listele()
        {
            return FacadeVize.VizeListele();
        }
        public static EntityVize ListeleTek(int deger)
        {
            return FacadeVize.VizeListeleTek(deger);
        }
    }
}
