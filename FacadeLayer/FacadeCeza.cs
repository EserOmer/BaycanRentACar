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
    public class FacadeCeza
    {
        public static int Ekle(EntityCeza deger)
        {
            SqlCommand komut = new SqlCommand("CezaEkle", SqlBaglantisi.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("Tarih", deger.Tarih);
            komut.Parameters.AddWithValue("Tutar", deger.Tutar);
            komut.Parameters.AddWithValue("AracId", deger.AracId);
            return komut.ExecuteNonQuery();
        }
        public static bool Guncelle(EntityCeza deger)
        {
            SqlCommand komut = new SqlCommand("CezaGuncelle", SqlBaglantisi.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("Tarih", deger.Tarih);
            komut.Parameters.AddWithValue("Tutar", deger.Tutar);
            komut.Parameters.AddWithValue("Id", deger.AracId);
            komut.Parameters.AddWithValue("CezaDurum", deger.CezaDurum);
            return komut.ExecuteNonQuery() > 0;
        }

        public static List<EntityCeza> CezaListele()
        {

            List<EntityCeza> degerler = new List<EntityCeza>();
            SqlCommand komut = new SqlCommand("CezaListesi", SqlBaglantisi.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityCeza ent = new EntityCeza();
                ent.Id = Convert.ToInt32(dr["id"]);
                ent.Tarih = Convert.ToDateTime(dr["Tarih"]);
                ent.Tutar = Convert.ToDecimal(dr["Tutar"]);
                ent.CezaDurum = Convert.ToBoolean(dr["CezaDurum"]);
                ent.DURUM = ent.CezaDurum ? "Ödenmedi" : "Ödendi";
                ent.Plaka = dr["Plaka"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static List<EntityCeza> CezaListeleTek(int Plaka)
        {

            List<EntityCeza> degerler = new List<EntityCeza>();
            SqlCommand komut = new SqlCommand("CezaListesiTek", SqlBaglantisi.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("AracId",Plaka);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityCeza ent = new EntityCeza();
                ent.Id = Convert.ToInt32(dr["id"]);
                ent.Tarih = Convert.ToDateTime(dr["Tarih"]);
                ent.Tutar = Convert.ToDecimal(dr["Tutar"]);
                ent.CezaDurum = Convert.ToBoolean(dr["CezaDurum"]);
                ent.DURUM = ent.CezaDurum ? "Ödenmedi" : "Ödendi";
                ent.Plaka = dr["Plaka"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
    }
}
