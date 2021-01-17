using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace FacadeLayer
{
    public class FacadeSigorta
    {
        public static int Ekle(EntitySigorta deger)
        {
            SqlCommand komut = new SqlCommand("SigortaEkle", SqlBaglantisi.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("Baslangic", deger.Baslangic);
            komut.Parameters.AddWithValue("Bitis", deger.Bitis);
            komut.Parameters.AddWithValue("Tutar", deger.Tutar);
            komut.Parameters.AddWithValue("AracId", deger.AracId);
            return komut.ExecuteNonQuery();
        }
        public static bool Guncelle(EntitySigorta deger)
        {
            SqlCommand komut = new SqlCommand("SigortaGuncelle", SqlBaglantisi.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("Baslangic", deger.Baslangic);
            komut.Parameters.AddWithValue("Bitis", deger.Bitis);
            komut.Parameters.AddWithValue("Tutar", deger.Tutar);
            komut.Parameters.AddWithValue("Id", deger.AracId);
            return komut.ExecuteNonQuery() > 0;
        }

        public static List<EntitySigorta> SigortaListele()
        {

            List<EntitySigorta> degerler = new List<EntitySigorta>();
            SqlCommand komut = new SqlCommand("SigortaListesi", SqlBaglantisi.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntitySigorta ent = new EntitySigorta();
                ent.Id = Convert.ToInt32(dr["id"]);
                ent.Baslangic = Convert.ToDateTime(dr["Baslangic"]);
                ent.Bitis = Convert.ToDateTime(dr["Bitis"]);
                ent.Tutar = Convert.ToDecimal(dr["Tutar"]);
                ent.Plaka = dr["Plaka"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static EntitySigorta SigortaListeleTek(int deger)
        {
            SqlCommand komut = new SqlCommand("SigortaListesiTek", SqlBaglantisi.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("AracId", deger);
            SqlDataReader dr = komut.ExecuteReader();
            EntitySigorta ent = new EntitySigorta();
            while (dr.Read())
            {
                ent.Id = Convert.ToInt32(dr["id"]);
                ent.Baslangic = Convert.ToDateTime(dr["Baslangic"]);
                ent.Bitis = Convert.ToDateTime(dr["Bitis"]);
                ent.Plaka = dr["Plaka"].ToString();
                ent.Tutar = Convert.ToDecimal(dr["Tutar"]);
            }
            dr.Close();

            return ent;
        }
    }
}
