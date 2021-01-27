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
    public class FacadeVeresiyeOdeme
    {
        public static int Ekle(EntityVeresiyeOdeme deger)
        {
            SqlCommand komut = new SqlCommand("VeresiyeOde", SqlBaglantisi.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("OdemeTarihi", deger.OdemeTarihi);
            komut.Parameters.AddWithValue("OdemeTutari", deger.OdemeTutar);
            komut.Parameters.AddWithValue("Aciklama", deger.Aciklama);
            komut.Parameters.AddWithValue("VeresiyeId", deger.VeresiyeId);
            return komut.ExecuteNonQuery();
        }
        public static List<EntityVeresiyeOdeme> OdemeListele()
        {

            List<EntityVeresiyeOdeme> degerler = new List<EntityVeresiyeOdeme>();
            SqlCommand komut = new SqlCommand("OdemeListesi", SqlBaglantisi.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityVeresiyeOdeme ent = new EntityVeresiyeOdeme();
                ent.Id = Convert.ToInt32(dr["id"]);
                ent.VeresiyeId = Convert.ToInt32(dr["VeresiyeId"]);
                ent.OdemeTutar = Convert.ToDecimal(dr["OdemeTutar"]);
                ent.OdemeTarihi = Convert.ToDateTime(dr["OdemeTarihi"]);
                ent.Aciklama = dr["Aciklama"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
    }
}
