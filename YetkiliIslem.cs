using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarantiKitap
{
    public partial class YetkiliIslem : Form
    {
        public YetkiliIslem()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMEkle_Click(object sender, EventArgs e)
        {
            MusteriEkle musteriEkle= new MusteriEkle();
            musteriEkle.Show();
        }

        private void btnMGuncelle_Click(object sender, EventArgs e)
        {
            MusteriGuncelle mg = new MusteriGuncelle();
            mg.Show();
        }

        private void btnMSil_Click(object sender, EventArgs e)
        {
            MusteriSilme musteriSilme= new MusteriSilme();
            musteriSilme.Show();    
        }

        private void btnMListele_Click(object sender, EventArgs e)
        {
            MusteriListele ml = new MusteriListele();   
            ml.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusteriSilme musteriSilme= new MusteriSilme();
            musteriSilme.Show();
        }

        private void YetkiliIslem_Load(object sender, EventArgs e)
        {

        }
    }
}
