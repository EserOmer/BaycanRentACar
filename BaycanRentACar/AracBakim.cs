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
    public partial class AracBakim : Form
    {
        
        public AracBakim()
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
        void BakimListesi() 
        {
            List<EntityBakim> BakimList = BLLBakim.Listele();
            dataGridView5.DataSource = BakimList;
        }
        private void AracBakim_Load(object sender, EventArgs e)
        {
            AracListesi();
            TxtNakitO.Text = "0";
            TxtBTutari.Text = "0";
            BakimListesi();
        }

          
        private void TxtNakitO_Leave(object sender, EventArgs e)
        {
            if (TxtNakitO.Text==""&&TxtBTutari.Text=="")
            {
                TxtNakitO.Text = "0";
                TxtBTutari.Text = "0";
            }
            if (Convert.ToInt32(TxtNakitO.Text) > Convert.ToInt32(TxtBTutari.Text))
            {
                MessageBox.Show("Bakım Tutarından Fazla Ödeme Yapamazsınız..");
                TxtNakitO.Text = "0";
            }
            TxtVTutari.Text = (Convert.ToInt32(TxtBTutari.Text) - Convert.ToInt32(TxtNakitO.Text)).ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntityBakim entbakim = new EntityBakim();
            entbakim.AracId = Convert.ToInt32(CmbArac.SelectedValue);
            entbakim.GirisTarihi = Convert.ToDateTime(dateTimePickerGirisT.Value);
            entbakim.CikisTarihi = Convert.ToDateTime(dateTimePickerCikisT.Value);
            entbakim.YapilanYer = TxtYapilanYer.Text;
            entbakim.BakimTutari = Convert.ToInt32(TxtBTutari.Text);
            entbakim.NakitOdeme = Convert.ToInt32(TxtNakitO.Text);
            entbakim.Aciklama = TxtAciklama.Text;
            BLLBakim.Ekle(entbakim);
            MessageBox.Show("Bakim Kaydi Basarili Bir Seklikde Eklendi");
            BakimListesi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static int aracId;
        public static int bakimId;
        private void dataGridView5_DoubleClick(object sender, EventArgs e)
        {
            int secilen = dataGridView5.SelectedCells[0].RowIndex;
            aracId= Convert.ToInt32(dataGridView5.Rows[secilen].Cells[1].Value);
            bakimId = Convert.ToInt32(dataGridView5.Rows[secilen].Cells[0].Value);
            BakimGuncelle form = new BakimGuncelle();
            form.Show();
        }
    }
}
