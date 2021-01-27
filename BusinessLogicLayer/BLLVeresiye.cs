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
        public static List<EntityVeresiye> Listele()
        {
            return FacadeVeresiye.VeresiyeListele();
        }
        public static List<EntityVeresiye> ListeleTek(int deger)
        {
            return FacadeVeresiye.VeresiyeListeleTek(deger);
        }
    }
}
