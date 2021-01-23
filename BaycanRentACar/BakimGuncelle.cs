using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using FacadeLayer;
using BusinessLogicLayer;

namespace BaycanRentACar
{
    public partial class BakimGuncelle : Form
    {
        public BakimGuncelle()
        {
            InitializeComponent();
        }
        void AracListesi()
        {
            List<EntityAraclar> ArcLst = BLLAraclar.Listele();
            CmbArac.DisplayMember = "Plaka";
            CmbArac.ValueMember = "Id";
            CmbArac.DataSource = ArcLst;
            
        }
        private void BakimGuncelle_Load(object sender, EventArgs e)
        {
            AracListesi();
            CmbArac.SelectedIndex = AracBakim.aracId-1;
            EntityBakim entityBakim = BLLBakim.BakimListeleTek2(AracBakim.bakimId);
            dateTimePickerGirisT.Text = entityBakim.GirisTarihi.ToString();
            dateTimePickerCikisT.Text = entityBakim.CikisTarihi.ToString();
            TxtYapilanYer.Text = entityBakim.YapilanYer.ToString();
            TxtBTutari.Text = entityBakim.BakimTutari.ToString();
            TxtNakitO.Text = entityBakim.NakitOdeme.ToString();
            TxtVTutari.Text = (Convert.ToDecimal(TxtBTutari.Text) - Convert.ToDecimal(TxtNakitO.Text)).ToString();
            TxtAciklama.Text = entityBakim.Aciklama.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtNakitO_Leave(object sender, EventArgs e)
        {
            if (TxtNakitO.Text == "" && TxtBTutari.Text == "")
            {
                TxtNakitO.Text = "0";
                TxtBTutari.Text = "0";
            }
            if (Convert.ToDecimal(TxtNakitO.Text) > Convert.ToDecimal(TxtBTutari.Text))
            {
                MessageBox.Show("Bakım Tutarından Fazla Ödeme Yapamazsınız..");
                TxtNakitO.Text = "0";
            }
            TxtVTutari.Text = (Convert.ToDecimal(TxtBTutari.Text) - Convert.ToDecimal(TxtNakitO.Text)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntityBakim entbakim = new EntityBakim();
            entbakim.Id = AracBakim.bakimId;
            entbakim.AracId = Convert.ToInt32(CmbArac.SelectedValue);
            entbakim.GirisTarihi = Convert.ToDateTime(dateTimePickerGirisT.Value);
            entbakim.CikisTarihi = Convert.ToDateTime(dateTimePickerCikisT.Value);
            entbakim.YapilanYer = TxtYapilanYer.Text;
            entbakim.BakimTutari = Convert.ToDecimal(TxtBTutari.Text);
            entbakim.NakitOdeme = Convert.ToDecimal(TxtNakitO.Text);
            entbakim.Aciklama = TxtAciklama.Text;
            BLLBakim.Guncelle(entbakim);
            MessageBox.Show("Bakim Kaydi Basarili Bir Seklikde Guncellendi");
            this.Close();
        }
    }
}
