using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;

namespace FacadeLayer
{
    public class FacadeAraclar
    {
        public static int Ekle(EntityAraclar deger) 
        {
            SqlCommand komut = new SqlCommand("AracEkle", SqlBaglantisi.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            if (komut.Connection.State!=ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("Plaka", deger.Plaka);
            komut.Parameters.AddWithValue("Marka", deger.Marka);
            komut.Parameters.AddWithValue("Model", deger.Model);
            komut.Parameters.AddWithValue("Renk", deger.Renk);
            komut.Parameters.AddWithValue("Km", deger.Km);
            komut.Parameters.AddWithValue("Vites", deger.Vites);
            return komut.ExecuteNonQuery();
        }

        public static bool Guncelle(EntityAraclar deger)
        {
            SqlCommand komut = new SqlCommand("AracGuncelle", SqlBaglantisi.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("Plaka", deger.Plaka);
            komut.Parameters.AddWithValue("Marka", deger.Marka);
            komut.Parameters.AddWithValue("Model", deger.Model);
            komut.Parameters.AddWithValue("Renk", deger.Renk);
            komut.Parameters.AddWithValue("Km", deger.Km);
            komut.Parameters.AddWithValue("Vites", deger.Vites);
            komut.Parameters.AddWithValue("Id", deger.Id);
            return komut.ExecuteNonQuery() > 0;
        }

        public static List<EntityAraclar> AracListele() 
        {
            List<EntityAraclar> degerler = new List<EntityAraclar>();
            SqlCommand komut = new SqlCommand("AracListesi", SqlBaglantisi.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityAraclar ent = new EntityAraclar();
                ent.Id = Convert.ToInt32(dr["id"]);
                ent.Plaka = dr["Plaka"].ToString();
                ent.Marka = dr["Marka"].ToString();
                ent.Model = dr["Model"].ToString();
                ent.Km = Convert.ToInt32(dr["Km"]);
                ent.Renk = dr["Renk"].ToString();
                ent.Vites = dr["Vites"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
    }
}
