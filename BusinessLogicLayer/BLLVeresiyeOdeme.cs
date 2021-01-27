using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using FacadeLayer;

namespace BusinessLogicLayer
{
    public class BLLVeresiyeOdeme
    {
        public static int Ekle(EntityVeresiyeOdeme deger)
        {
            if (deger.VeresiyeId != null && deger.OdemeTutar != null)
            {
                return FacadeVeresiyeOdeme.Ekle(deger);
            }
            return -1;
        }
    }
}
