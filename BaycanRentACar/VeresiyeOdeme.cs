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
    public partial class VeresiyeOdeme : Form
    {
        public VeresiyeOdeme()
        {
            InitializeComponent();
        }

        private void VeresiyeOdeme_Load(object sender, EventArgs e)
        {
            LblPlaka.Text = Veresiyeler.aracPlaka;
            LblBakimTutari.Text = Veresiyeler.bakimTutari.ToString("C");
            LblBorc.Text = Veresiyeler.borc.ToString("C");
            LblYapilanYer.Text = Veresiyeler.yapilanYer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntityVeresiyeOdeme entityVeresiyeOdeme = new EntityVeresiyeOdeme();
            entityVeresiyeOdeme.VeresiyeId = Veresiyeler.veresiyeId;
            entityVeresiyeOdeme.OdemeTutar = Convert.ToDecimal(TxtOdemeTutari.Text);
            entityVeresiyeOdeme.OdemeTarihi = Convert.ToDateTime(dateTimePickerOdemeTarihi.Value);
            entityVeresiyeOdeme.Aciklama = TxtAciklama.Text;
            BLLVeresiyeOdeme.Ekle(entityVeresiyeOdeme);
            MessageBox.Show("Odeme Istlemi Basarili Sekilde Tamamlandi.");
        }
    }
}
