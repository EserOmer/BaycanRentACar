using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using FacadeLayer;

namespace BusinessLogicLayer
{
    public class BLLCeza
    {
        public static int Ekle(EntityCeza deger)
        {
            if (deger.Tarih != null  && deger.Tutar != null)
            {
                return FacadeCeza.Ekle(deger);
            }
            return -1;
        }
        public static bool Guncelle(EntityCeza deger)
        {
            if (deger.Tarih != null && deger.Tutar != null)
            {
                return FacadeCeza.Guncelle(deger);
            }
            return false;
        }
        public static List<EntityCeza> Listele()
        {
            return FacadeCeza.CezaListele();
        }
        public static List<EntityCeza> ListeleTek(int Plaka)
        {
            return FacadeCeza.CezaListeleTek(Plaka);
        }
    }
}
