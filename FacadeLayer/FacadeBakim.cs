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
    public class FacadeBakim
    {
        public static int Ekle(EntityBakim deger)
        {
            SqlCommand komut = new SqlCommand("BakimEkle", SqlBaglantisi.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("AracId", deger.AracId);
            komut.Parameters.AddWithValue("GirisTarihi", deger.GirisTarihi);
            komut.Parameters.AddWithValue("CikisTarihi", deger.CikisTarihi);
            komut.Parameters.AddWithValue("YapilanYer", deger.YapilanYer);
            komut.Parameters.AddWithValue("BakimTutari", deger.BakimTutari);
            komut.Parameters.AddWithValue("NakitOdeme", deger.NakitOdeme);
            komut.Parameters.AddWithValue("Aciklama", deger.Aciklama);
            return komut.ExecuteNonQuery();
        }
        public static bool Guncelle(EntityBakim deger)
        {
            SqlCommand komut = new SqlCommand("BakimGuncelle", SqlBaglantisi.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("Id", deger.Id);
            //komut.Parameters.AddWithValue("AracId", deger.AracId);
            komut.Parameters.AddWithValue("GirisTarihi", deger.GirisTarihi);
            komut.Parameters.AddWithValue("CikisTarihi", deger.CikisTarihi);
            komut.Parameters.AddWithValue("YapilanYer", deger.YapilanYer);
            komut.Parameters.AddWithValue("BakimTutari", deger.BakimTutari);
            komut.Parameters.AddWithValue("NakitOdeme", deger.NakitOdeme);
            komut.Parameters.AddWithValue("Aciklama", deger.Aciklama);
            return komut.ExecuteNonQuery() > 0;
        }
        public static List<EntityBakim> BakimListele()
        {

            List<EntityBakim> degerler = new List<EntityBakim>();
            SqlCommand komut = new SqlCommand("BakimListesi", SqlBaglantisi.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityBakim ent = new EntityBakim();
                ent.Id = Convert.ToInt32(dr["id"]);
                ent.GirisTarihi = Convert.ToDateTime(dr["GirisTarihi"]);
                ent.CikisTarihi = Convert.ToDateTime(dr["CikisTarihi"]);
                ent.YapilanYer = dr["YapilanYer"].ToString();
                ent.BakimTutari = Convert.ToDecimal(dr["BakimTutari"]);
                ent.NakitOdeme = Convert.ToDecimal(dr["NakitOdeme"]);
                ent.Aciklama =dr["Aciklama"].ToString();
                ent.AracId = Convert.ToInt32(dr["AracId"]);
                ent.Plaka = dr["Plaka"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static List<EntityBakim> BakimListeleTek(int deger)
        {
            List<EntityBakim> degerler = new List<EntityBakim>();
            SqlCommand komut = new SqlCommand("BakimListesiTek", SqlBaglantisi.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("AracId", deger);
            SqlDataReader dr = komut.ExecuteReader();
            
            while (dr.Read())
            {
                EntityBakim ent = new EntityBakim();
                ent.Id = Convert.ToInt32(dr["id"]);
                ent.GirisTarihi = Convert.ToDateTime(dr["GirisTarihi"]);
                ent.CikisTarihi = Convert.ToDateTime(dr["CikisTarihi"]);
                ent.YapilanYer = dr["YapilanYer"].ToString();
                ent.BakimTutari = Convert.ToDecimal(dr["BakimTutari"]);
                ent.Aciklama = dr["Aciklama"].ToString();
                ent.AracId = Convert.ToInt32(dr["AracId"]);
                ent.NakitOdeme = Convert.ToDecimal(dr["NakitOdeme"]);
                degerler.Add(ent);
            }
            dr.Close();

            return degerler;
        }
        public static EntityBakim BkmLstTk(int deger)
        {
            SqlCommand komut = new SqlCommand("BakimListesiTek2", SqlBaglantisi.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("BakimId", deger);
            SqlDataReader dr = komut.ExecuteReader();
            EntityBakim ent = new EntityBakim();
            while (dr.Read())
            {

                ent.Id = Convert.ToInt32(dr["id"]);
                ent.GirisTarihi = Convert.ToDateTime(dr["GirisTarihi"]);
                ent.CikisTarihi = Convert.ToDateTime(dr["CikisTarihi"]);
                ent.YapilanYer = dr["YapilanYer"].ToString();
                ent.BakimTutari = Convert.ToDecimal(dr["BakimTutari"]);
                ent.Aciklama = dr["Aciklama"].ToString();
                ent.AracId = Convert.ToInt32(dr["AracId"]);
                ent.NakitOdeme = Convert.ToDecimal(dr["NakitOdeme"]);
            }
            dr.Close();

            return ent;
        }
    }
}
