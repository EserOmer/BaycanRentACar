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
    public partial class BakimGecmisi : Form
    {
        public BakimGecmisi()
        {
            InitializeComponent();
        }
        void AracListesi()
        {
            List<EntityAraclar> ArcLst = BLLAraclar.Listele();
            dataGridView1.DataSource = ArcLst;
            
        }
        private void BakimGecmisi_Load(object sender, EventArgs e)
        {
            AracListesi();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            EntityVize VizeLstTek = BLLVize.ListeleTek(Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value));
            if (VizeLstTek.Bitis.ToString("dd.MM.yyyy") == "01.01.0001" && VizeLstTek.Baslangic.ToString("dd.MM.yyyy") == "01.01.0001" && VizeLstTek.Tutar == 0)
            {
                VBIT.Text ="---" ;
                VBT.Text = "---";
                VTUT.Text = "---";
            }
            else
            {
                VBIT.Text = VizeLstTek.Bitis.ToString("dd.MM.yyyy");
                VBIT.Visible = true;
                VBT.Text = VizeLstTek.Baslangic.ToString("dd.MM.yyyy");
                VBT.Visible = true;
                VTUT.Text = VizeLstTek.Tutar.ToString();
                VTUT.Visible = true;
            }
            EntitySigorta SigortaLstTek = BLLSigorta.ListeleTek(Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value));
            if (SigortaLstTek.Bitis.ToString("dd.MM.yyyy") == "01.01.0001"&& SigortaLstTek.Baslangic.ToString("dd.MM.yyyy") == "01.01.0001"&& SigortaLstTek.Tutar == 0)
            {
                SBIT.Text ="---" ;
                SBT.Text = "---";
                STUT.Text = "---";
            }
            else
            {
                SBIT.Text = SigortaLstTek.Bitis.ToString("dd.MM.yyyy");
                SBIT.Visible = true;
                SBT.Text = SigortaLstTek.Baslangic.ToString("dd.MM.yyyy");
                SBT.Visible = true;
                STUT.Text = SigortaLstTek.Tutar.ToString();
                STUT.Visible = true;
            }
            EntityKasko KaskoLstTek = BLLKasko.ListeleTek(Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value));
            if (KaskoLstTek.Bitis.ToString("dd.MM.yyyy") == "01.01.0001" && KaskoLstTek.Baslangic.ToString("dd.MM.yyyy") == "01.01.0001" && KaskoLstTek.Tutar == 0)
            {
                KBIT.Text ="---" ;
                KBT.Text = "---";
                KTUT.Text = "---";
            }
            else
            {
                KBIT.Text = KaskoLstTek.Bitis.ToString("dd.MM.yyyy");
                KBIT.Visible = true;
                KBT.Text = KaskoLstTek.Baslangic.ToString("dd.MM.yyyy");
                KBT.Visible = true;
                KTUT.Text = KaskoLstTek.Tutar.ToString();
                KTUT.Visible = true;
            }
            List<EntityCeza> ArcCeza = BLLCeza.ListeleTek(Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value));
            dataGridView4.DataSource = ArcCeza;

            List<EntityBakim> BakimLstTek = BLLBakim.ListeleTek(Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value));
            dataGridView5.DataSource = BakimLstTek;
        }
    }
}
