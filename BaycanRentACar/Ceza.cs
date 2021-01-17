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
    public partial class Ceza : Form
    {
        public Ceza()
        {
            InitializeComponent();
        }
        void CezaListesi()
        {
            List<EntityAraclar> ArcList = BLLAraclar.Listele();
            List<EntityCeza> CezaLst = BLLCeza.Listele();
            dataGridView1.DataSource = CezaLst;
            CmbPlaka.DisplayMember = "Plaka";
            CmbPlaka.ValueMember = "Id";
            CmbPlaka.DataSource = ArcList;
            CmbPlkGncl.DisplayMember = "Plaka";
            CmbPlkGncl.ValueMember = "Id";
            CmbPlkGncl.DataSource = CezaLst;
            
        }

        private void Ceza_Load(object sender, EventArgs e)
        {
            CezaListesi();
        }

       

        private void BtnKydt_Click(object sender, EventArgs e)
        {
            EntityCeza ent = new EntityCeza();
            ent.Tarih = Convert.ToDateTime(dateTimeTarih.Text);
            ent.Tutar = Convert.ToInt32(TxtTutar.Text); 
            ent.AracId = Convert.ToInt32(CmbPlaka.SelectedValue);
            BLLCeza.Ekle(ent);
            MessageBox.Show("Ceza Ekleme Islemi Basari Ile Sonuclandi");
            CezaListesi();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            EntityCeza ent = new EntityCeza();
            ent.Tarih = Convert.ToDateTime(dateTimeTarih.Text);
            ent.Tutar = Convert.ToDecimal(TxtTutarGnc.Text); ;
            ent.AracId = Convert.ToInt32(CmbPlkGncl.SelectedValue);
            if (radioButtonOdendi.Checked==true)
            {
                ent.CezaDurum = false;
            }
            if (radioButtonOdenmedi.Checked==true)
            {
                ent.CezaDurum = true;
            }
            BLLCeza.Guncelle(ent);
            MessageBox.Show("Ceza Guncelleme Islemi Basari Ile Sonuclandi");
            CezaListesi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            CmbPlkGncl.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            dateTimeTarih.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtTutarGnc.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            if (Convert.ToBoolean(dataGridView1.Rows[secilen].Cells[4].Value) == true)
            {
                radioButtonOdenmedi.Checked = true;
            }
            if (Convert.ToBoolean(dataGridView1.Rows[secilen].Cells[4].Value) == false)
            {
                radioButtonOdendi.Checked = true;
            }
        }
    }
}
