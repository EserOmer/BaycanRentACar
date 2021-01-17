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
    public partial class Vize : Form
    {
        public Vize()
        {
            InitializeComponent();
        }

        void VizeListesi()
        {
            List<EntityAraclar> ArcList = BLLAraclar.Listele();
            List<EntityVize> VizeLst = BLLVize.Listele();
            dataGridView1.DataSource = VizeLst;
            CmbPlaka.DisplayMember = "Plaka";
            CmbPlaka.ValueMember = "Id";
            CmbPlaka.DataSource = ArcList;
            CmbPlkGncl.DisplayMember = "Plaka";
            CmbPlkGncl.ValueMember = "Id";
            CmbPlkGncl.DataSource = VizeLst;
        }

        private void Vize_Load(object sender, EventArgs e)
        {
            VizeListesi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntityVize ent = new EntityVize();
            ent.Baslangic = Convert.ToDateTime(DateTimeBaslangic.Text);
            ent.Bitis = Convert.ToDateTime(DateTimeBitis.Text);
            ent.Tutar = Convert.ToInt32(TxtTutar.Text);;
            ent.AracId = Convert.ToInt32(CmbPlaka.SelectedValue);
            BLLVize.Ekle(ent);
            MessageBox.Show("Vize Ekleme Islemi Basari Ile Sonuclandi");
            VizeListesi();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            EntityVize ent = new EntityVize();
            ent.Baslangic = Convert.ToDateTime(DateTimeBaslangicGnc.Text);
            ent.Bitis = Convert.ToDateTime(DataTimeBitisGnc.Text);
            ent.Tutar = Convert.ToDecimal(TxtTutarGnc.Text); 
            ent.AracId = Convert.ToInt32(CmbPlkGncl.SelectedValue);
            BLLVize.Guncelle(ent);
            MessageBox.Show("Vize Guncelleme Islemi Basari Ile Sonuclandi");
            VizeListesi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            CmbPlkGncl.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            DateTimeBaslangicGnc.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            DataTimeBitisGnc.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtTutarGnc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }
    }
}
