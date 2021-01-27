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
    public partial class Araclar : Form
    {
        private bool isCollapsed;
        private bool isCollapsed2;

        public Araclar()
        {
            InitializeComponent();
        }

        void AracListesi() 
        {
            List<EntityAraclar> ArcLst = BLLAraclar.Listele();
            dataGridView1.DataSource = ArcLst;
        }

        private void Araclar_Load(object sender, EventArgs e)
        {
            AracListesi();
            timer1.Start();
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                BtnArcIslemler.Image = Resources.Collapse_Arrow_20px;

                panelDropDown.Height += 10;
                if (panelDropDown.Size == panelDropDown.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                BtnArcIslemler.Image = Resources.Expand_Arrow_20px;
                panelDropDown.Height -= 10;
                if (panelDropDown.Size == panelDropDown.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }


        private void button8_Click(object sender, EventArgs e)
        {
            YeniAracForm goster = new YeniAracForm();
            goster.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AracGuncelle goster = new AracGuncelle();
            goster.Show();
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsed2)
            {
                BtnDetaylar.Image = Resources.Collapse_Arrow_20px;

                panelDropDown2.Height += 10;
                if (panelDropDown2.Size == panelDropDown2.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed2 = false;
                }
            }
            else
            {
                BtnDetaylar.Image = Resources.Expand_Arrow_20px;
                panelDropDown2.Height -= 10;
                if (panelDropDown2.Size == panelDropDown2.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed2 = true;
                }
            }
        }


        private void BtnArcKrl_Click(object sender, EventArgs e)
        {
            AracKirala goster = new AracKirala();
            goster.Show();
        }

        private void BtnDetaylar_Click_1(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void BtnGecmisDetaylar_Click(object sender, EventArgs e)
        {
            BakimGecmisi goster = new BakimGecmisi();
            goster.Show();
        }

        private void BtnYeniAracEkle_Click(object sender, EventArgs e)
        {
            YeniAracForm goster = new YeniAracForm();
            goster.Show();
            this.Close();
        }

        private void BtnArcIslemler_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void BtnAracGuncelle_Click(object sender, EventArgs e)
        {
            AracGuncelle goster = new AracGuncelle();
            goster.Show();
        }

        private void BtnBkmKyd_Click(object sender, EventArgs e)
        {
            AracBakim goster = new AracBakim();
            goster.Show();
        }

        private void BtnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Vize goster = new Vize();
            goster.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sigorta goster = new Sigorta();
            goster.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Kasko goster = new Kasko();
            goster.Show();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCeza_Click(object sender, EventArgs e)
        {
            Ceza goster = new Ceza();
            goster.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Veresiyeler veresiyeler = new Veresiyeler();
            veresiyeler.Show();
        }
    }
}
