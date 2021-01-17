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
    public partial class AracGuncelle : Form
    {
        public AracGuncelle()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtPlaka.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtMarka.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtModel.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtKm.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtRenk.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            CmbVites.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void CmbPlaka_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtPlaka.Text = dataGridView1.Rows[CmbPlaka.SelectedIndex].Cells[1].Value.ToString();
            TxtMarka.Text = dataGridView1.Rows[CmbPlaka.SelectedIndex].Cells[2].Value.ToString();
            TxtModel.Text = dataGridView1.Rows[CmbPlaka.SelectedIndex].Cells[3].Value.ToString();
            TxtKm.Text = dataGridView1.Rows[CmbPlaka.SelectedIndex].Cells[5].Value.ToString();
            TxtRenk.Text = dataGridView1.Rows[CmbPlaka.SelectedIndex].Cells[4].Value.ToString();
            CmbVites.Text = dataGridView1.Rows[CmbPlaka.SelectedIndex].Cells[6].Value.ToString();
        }
        void AracListesi()
        {
            List<EntityAraclar> ArcLst = BLLAraclar.Listele();
            dataGridView1.DataSource = ArcLst;
            CmbPlaka.DisplayMember = "Plaka";
            CmbPlaka.ValueMember = "Id";
            CmbPlaka.DataSource = ArcLst;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AracGuncelle_Load(object sender, EventArgs e)
        {
            AracListesi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntityAraclar ent = new EntityAraclar();
            ent.Plaka = TxtPlaka.Text;
            ent.Marka = TxtMarka.Text;
            ent.Model = TxtModel.Text;
            ent.Renk = TxtRenk.Text;
            ent.Km = Convert.ToInt32(TxtKm.Text);
            ent.Vites = CmbVites.Text;
            ent.Id = Convert.ToInt32(CmbPlaka.SelectedValue);
            BLLAraclar.Guncelle(ent);
            MessageBox.Show("Arac Guncelleme Islemi Basari Ile Sonuclandi");
            AracListesi();
        }

    }
}
