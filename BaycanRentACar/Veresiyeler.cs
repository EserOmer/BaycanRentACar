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
using BaycanRentACar.Properties;

namespace BaycanRentACar
{
    public partial class Veresiyeler : Form
    {
        public Veresiyeler()
        {
            InitializeComponent();
        }
        void AracListesi()
        {
            List<EntityAraclar> ArcLst = BLLAraclar.Listele();
            dataGridView1.DataSource = ArcLst;
        }
        void VeresiyeListesi()
        {
            List<EntityVeresiye> VeresiyeLst = BLLVeresiye.Listele();
            dataGridView2.DataSource = VeresiyeLst;
        }

        private void Veresiyeler_Load(object sender, EventArgs e)
        {
            AracListesi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            List<EntityVeresiye> entityVeresiye = BLLVeresiye.ListeleTek(Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value));
            dataGridView2.DataSource = entityVeresiye;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VeresiyeListesi();
        }
        public static string aracPlaka;
        public static decimal bakimTutari;
        public static decimal borc;
        public static string yapilanYer;
        public static int veresiyeId;
        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            int secilen2 = dataGridView1.SelectedCells[0].RowIndex;
            aracPlaka = dataGridView1.Rows[secilen2].Cells[1].Value.ToString();
            bakimTutari = Convert.ToDecimal(dataGridView2.Rows[secilen].Cells[4].Value);
            borc= Convert.ToDecimal(dataGridView2.Rows[secilen].Cells[1].Value);
            yapilanYer = dataGridView2.Rows[secilen].Cells[3].Value.ToString();
            veresiyeId= Convert.ToInt32(dataGridView2.Rows[secilen].Cells[0].Value);
            VeresiyeOdeme veresiyeOdeme = new VeresiyeOdeme();
            veresiyeOdeme.Show();
        }
    }
}
