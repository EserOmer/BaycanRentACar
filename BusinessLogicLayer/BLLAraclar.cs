using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using FacadeLayer;

namespace BusinessLogicLayer
{
    public class BLLAraclar
    {
        public static int Ekle(EntityAraclar deger) 
        {
            if (deger.Plaka!=null && deger.Marka!=null && deger.Model!=null && deger.Km>0)
            {
                return FacadeAraclar.Ekle(deger);
            }
            return -1;
        }
        public static bool Guncelle(EntityAraclar deger)
        {
            if (deger.Plaka != null && deger.Marka != null && deger.Model != null && deger.Km > 0 )
            {
                return FacadeAraclar.Guncelle(deger);
            }
            return false;
        }
        public static List<EntityAraclar> Listele() 
        {
            return FacadeAraclar.AracListele();
        }
    }
}
