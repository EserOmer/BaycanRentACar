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
    public class FacadeVize
    {
        public static int Ekle(EntityVize deger)
        {
            SqlCommand komut = new SqlCommand("VizeEkle", SqlBaglantisi.Baglanti);
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
        public static bool Guncelle(EntityVize deger)
        {
            SqlCommand komut = new SqlCommand("VizeGuncelle", SqlBaglantisi.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("Baslangic", deger.Baslangic);
            komut.Parameters.AddWithValue("Bitis", deger.Bitis);
            komut.Parameters.AddWithValue("Tutar", deger.Tutar);
            komut.Parameters.AddWithValue("Id", deger.AracId);
            return komut.ExecuteNonQuery()>0;
        }

        public static List<EntityVize> VizeListele()
        {
            
            List<EntityVize> degerler = new List<EntityVize>();
            SqlCommand komut = new SqlCommand("VizeListesi", SqlBaglantisi.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityVize ent = new EntityVize();
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
        public static EntityVize VizeListeleTek(int deger)
        {
            SqlCommand komut = new SqlCommand("VizeListesiTek", SqlBaglantisi.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("AracId", deger);
            SqlDataReader dr = komut.ExecuteReader();
            EntityVize ent = new EntityVize();
            while (dr.Read())
            {
                
                ent.Id = Convert.ToInt32(dr["id"]);
                ent.Baslangic = Convert.ToDateTime(dr["Baslangic"]);
                ent.Bitis = Convert.ToDateTime(dr["Bitis"]);
                ent.Tutar = Convert.ToDecimal(dr["Tutar"]);
                ent.Plaka = dr["Plaka"].ToString();
            }
            dr.Close();
            
            return ent;
        }
    }
}
