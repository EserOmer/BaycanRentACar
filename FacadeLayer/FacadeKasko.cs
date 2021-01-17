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
    public class FacadeKasko
    {
        public static int Ekle(EntityKasko deger)
        {
            SqlCommand komut = new SqlCommand("KaskoEkle", SqlBaglantisi.Baglanti);
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
        public static bool Guncelle(EntityKasko deger)
        {
            SqlCommand komut = new SqlCommand("KaskoGuncelle", SqlBaglantisi.Baglanti);
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

        public static List<EntityKasko> KaskoListele()
        {

            List<EntityKasko> degerler = new List<EntityKasko>();
            SqlCommand komut = new SqlCommand("KaskoListesi", SqlBaglantisi.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityKasko ent = new EntityKasko();
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
        public static EntityKasko KaskoListeleTek(int deger)
        {
            SqlCommand komut = new SqlCommand("KaskoListesiTek", SqlBaglantisi.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("AracId", deger);
            SqlDataReader dr = komut.ExecuteReader();
            EntityKasko ent = new EntityKasko();
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
