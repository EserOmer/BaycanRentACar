using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityAraclar
    {
        int _id;
        string _Plaka;
        string _Marka;
        string _Model;
        string _Renk;
        int _Km;
        string _Vites;

        public int Id { get => _id; set => _id = value; }
        public string Plaka { get => _Plaka; set => _Plaka = value; }
        public string Marka { get => _Marka; set => _Marka = value; }
        public string Model { get => _Model; set => _Model = value; }
        public string Renk { get => _Renk; set => _Renk = value; }
        public int Km { get => _Km; set => _Km = value; }
        public string Vites { get => _Vites; set => _Vites = value; }
    }
}
