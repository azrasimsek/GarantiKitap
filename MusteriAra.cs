using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarantiKitap
{
    public partial class MusteriAra : Form
    {
        public MusteriAra()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(" server = LAPTOP-F1R95NSP\\SQLEXPRESS ; initial catalog = GarantiKitap; integrated security = sspi ");

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from musteriler where ID = @p1 ", con);
            komut.Parameters.AddWithValue("@p1", txtAra.Text);
            con.Open();
            SqlDataReader dr = komut.ExecuteReader();

             if (dr.Read())
                {
                txtID.Text = dr["ID"].ToString();
                txtAdSoyad.Text = dr["adSoyad"].ToString();
                txtTelefon.Text = dr["telefon"].ToString();
                 }

            else
            {
                MessageBox.Show( "Numaralı Kayıt Bulunamadı !","Kayıt Arama Hatası",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtID.Text = "";
                txtID.Text = "";
                txtAdSoyad.Text = "";
                txtTelefon.Text = "";

            }
            con.Close();

        }

        private void MusteriAra_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTelefon_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
