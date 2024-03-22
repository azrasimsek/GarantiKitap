using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;





namespace GarantiKitap
{
    public partial class AnaYetkili : Form
    {
        public AnaYetkili()
        {
            InitializeComponent();
        }

        private void AnaYetkili_Load(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMEkle_Click(object sender, EventArgs e)
        {
            MusteriEkle me=new MusteriEkle();
            me.Show();
           
        }

        private void btnMGuncelle_Click(object sender, EventArgs e)
        {
            MusteriGuncelle mg = new MusteriGuncelle();
            mg.Show();
        }

        private void btnMSil_Click(object sender, EventArgs e)
        {
            MusteriSilme musterisil = new MusteriSilme();
            musterisil.Show();
        }

        private void btnMListele_Click(object sender, EventArgs e)
        {
            MusteriListele ml = new MusteriListele();
            ml.Show();
        }

        private void btnYEkle_Click(object sender, EventArgs e)
        {
            YetkiliEkle ye = new YetkiliEkle();
            ye.Show();
        }

        private void btnYSil_Click(object sender, EventArgs e)
        {
            YetkiliSil yetkiliSil= new YetkiliSil();
            yetkiliSil.Show();
        }

        private void btnYGuncelle_Click(object sender, EventArgs e)
        {
            YetkiliGuncelle yg = new YetkiliGuncelle();
            yg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YetkiliListele yl = new YetkiliListele();
            yl.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        
        private async void btnTMusteriMesaj_Click(object sender, EventArgs e)
        {
            TMMesaj tumMusterilerM = new TMMesaj();
            tumMusterilerM.Show();
        }

        private void btnMusteriMesaj_Click(object sender, EventArgs e)
        {
            SMMesaj secilenMusteriMesaj = new SMMesaj();
            secilenMusteriMesaj.Show();
        }
    }
}
