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
                ent.BakimTutari = Convert.ToDecimal(dr["BakimTutari"]);
                ent.NakitOdeme = Convert.ToDecimal(dr["NakitOdeme"]);
                ent.YapilanYer = dr["YapilanYer"].ToString();
                ent.Aciklama = dr["Aciklama"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static List<EntityVeresiye> VeresiyeListeleTek(int deger)
        {

            List<EntityVeresiye> degerler = new List<EntityVeresiye>();
            SqlCommand komut = new SqlCommand("VeresiyeListesiTek", SqlBaglantisi.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("AracId", deger);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                EntityVeresiye ent = new EntityVeresiye();
                ent.Id = Convert.ToInt32(dr["id"]);
                ent.BakimId = Convert.ToInt32(dr["BakimId"]);
                ent.Tutar = Convert.ToDecimal(dr["Tutar"]);
                ent.BakimTutari = Convert.ToDecimal(dr["BakimTutari"]);
                ent.NakitOdeme = Convert.ToDecimal(dr["NakitOdeme"]);
                ent.YapilanYer = dr["YapilanYer"].ToString();
                ent.Aciklama = dr["Aciklama"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
    }
}
