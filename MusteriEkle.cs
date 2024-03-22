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
using MySql.Data.MySqlClient;

namespace GarantiKitap
{
    public partial class MusteriEkle : Form
    {
        MySqlConnection con = new MySqlConnection("Server=85.111.5.88;Database=iyonyaso_kitaplik;Uid=iyonyaso_kitaplik;Pwd='Ezber2000?';");
        public MusteriEkle()
        {
            InitializeComponent();
        }
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO musteriler(adSoyad,telefon)"+"VALUES (@adSoyad,@telefon)";
            cmd = new MySqlCommand(sql,con);
            cmd.Parameters.AddWithValue("@adSoyad",txtAdSoyad.Text);
            cmd.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Müşteri Kaydı Oluşturuldu.","Müşteri Kayıt İşlemi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            txtAdSoyad.Text = "";
            txtTelefon.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MusteriEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
