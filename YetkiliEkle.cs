using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Security.Policy;

namespace GarantiKitap
{
    public partial class YetkiliEkle : Form
    {
        public YetkiliEkle()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("Server=85.111.5.88;Database=iyonyaso_kitaplik;Uid=iyonyaso_kitaplik;Pwd='Ezber2000?';");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO yetkililer(kullaniciAdi,sifre)" + "VALUES (@kullaniciAdi,@sifre)";
            cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@kullaniciAdi", txtkullaniciAdi.Text);
            cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Yetkili Kaydı Oluşturuldu.", "Yetkili Kayıt İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtkullaniciAdi.Text = "";
            txtSifre.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void YetkiliEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
