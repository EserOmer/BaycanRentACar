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
using System.Data.SqlClient;

namespace BaycanRentACar
{
    public partial class Sigorta : Form
    {
        public Sigorta()
        {
            InitializeComponent();
        }
        void SigortaListesi()
        {
            List<EntityAraclar> ArcList = BLLAraclar.Listele();
            List<EntitySigorta> SgrtLst = BLLSigorta.Listele();
            dataGridView1.DataSource = SgrtLst;
            CmbPlaka.DisplayMember = "Plaka";
            CmbPlaka.ValueMember = "Id";
            CmbPlaka.DataSource = ArcList;
            CmbPlkGncl.DisplayMember = "Plaka";
            CmbPlkGncl.ValueMember = "Id";
            CmbPlkGncl.DataSource = SgrtLst;
        }

        private void Sigorta_Load(object sender, EventArgs e)
        {
            SigortaListesi();
        }

        private void BtnKydt_Click(object sender, EventArgs e)
        {
            EntitySigorta ent = new EntitySigorta();
            ent.Baslangic = Convert.ToDateTime(DateTimeBaslangic.Text);
            ent.Bitis = Convert.ToDateTime(DateTimeBitis.Text);
            ent.Tutar = Convert.ToInt32(TxtTutar.Text); ;
            ent.AracId = Convert.ToInt32(CmbPlaka.SelectedValue);
            BLLSigorta.Ekle(ent);
            MessageBox.Show("Sigorta Ekleme Islemi Basari Ile Sonuclandi");
            SigortaListesi();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            EntitySigorta ent = new EntitySigorta();
            ent.Baslangic = Convert.ToDateTime(DateTimeBaslangicGnc.Text);
            ent.Bitis = Convert.ToDateTime(DataTimeBitisGnc.Text);
            ent.Tutar = Convert.ToDecimal(TxtTutarGnc.Text);
            ent.AracId = Convert.ToInt32(CmbPlkGncl.SelectedValue);
            BLLSigorta.Guncelle(ent);
            MessageBox.Show("Sigorta Guncelleme Islemi Basari Ile Sonuclandi");
            SigortaListesi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            CmbPlkGncl.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            DateTimeBaslangicGnc.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            DataTimeBitisGnc.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtTutarGnc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
