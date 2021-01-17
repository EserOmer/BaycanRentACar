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
    public class FacadeVeresiye
    {
        public static int Ekle(EntityVeresiye deger)
        {
            SqlCommand komut = new SqlCommand("VeresiyeEkle", SqlBaglantisi.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("BakimId", deger.BakimId);
            komut.Parameters.AddWithValue("Tutar", deger.Tutar);
            return komut.ExecuteNonQuery();
        }
        public static bool Guncelle(EntityVeresiye deger)
        {
            SqlCommand komut = new SqlCommand("VeresiyeGuncelle", SqlBaglantisi.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("BakimId", deger.BakimId);
            komut.Parameters.AddWithValue("Tutar", deger.Tutar);
            return komut.ExecuteNonQuery() > 0;
        }
        public static List<EntityVeresiye> VeresiyeListele()
        {

            List<EntityVeresiye> degerler = new List<EntityVeresiye>();
            SqlCommand komut = new SqlCommand("VeresiyeListesi", SqlBaglantisi.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityVeresiye ent = new EntityVeresiye();
                ent.Id = Convert.ToInt32(dr["id"]);
                ent.BakimId = Convert.ToInt32(dr["BakimId"]);
                ent.Tutar = Convert.ToDecimal(dr["Tutar"]);
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
    }
}
