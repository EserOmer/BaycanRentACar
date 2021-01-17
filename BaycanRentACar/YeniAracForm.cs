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
using BusinessLogicLayer;
using FacadeLayer;

namespace BaycanRentACar
{
    public partial class YeniAracForm : Form
    {
        public YeniAracForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Araclar goster = new Araclar();
            goster.Show();
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
            BLLAraclar.Ekle(ent);
            MessageBox.Show("Arac Ekleme Islemi Basari Ile Sonuclandi");
            this.Close();
            Araclar goster = new Araclar();
            goster.Show();
        }
    }
}
