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

namespace GarantiKitap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("Server=85.111.5.88;Port=3306;Database=iyonyaso_kitaplik;Uid=iyonyaso_kitaplik;Pwd='Ezber2000?';");
        public static string adSoyad;
        public static string kullaniciAdi;
        public static int mID;
        private void button1_Click(object sender, EventArgs e)
        {
            string kAdi = textBox1.Text;
            string parola = textBox2.Text;
            bool sonuc = false;

            con.Open();
            MySqlCommand yetkom = new MySqlCommand("SELECT * FROM yetkililer where kullaniciAdi = @p1 and sifre = @p2 LIMIT 1", con);
            yetkom.Parameters.AddWithValue("@p1", kAdi);
            yetkom.Parameters.AddWithValue("@p2", parola);

            MySqlDataReader yetkili = yetkom.ExecuteReader();


            yetkili.Read();


            string kullaniciAdi = yetkili["kullaniciAdi"].ToString();
            string rol = yetkili["rol"].ToString();

            

            yetkili.Close();


            if (rol == "1")
            {
                AnaYetkili ay = new AnaYetkili();
                ay.Show();
                this.Hide();

            }
            else
            {
               
                MySqlCommand komut = new MySqlCommand("SELECT * FROM yetkililer where kullaniciAdi = @p1 and sifre = @p2 ", con);
                komut.Parameters.AddWithValue("@p1",kAdi);
                komut.Parameters.AddWithValue("@p2", parola);

                MySqlDataReader dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    kullaniciAdi = dr["kullaniciAdi"].ToString();
                    sonuc = true;
                  
                }
                con.Close();

                if (sonuc)
                {
                    sonuc = false;
                    YetkiliIslem yi = new YetkiliIslem();
                    yi.Show();
                    this.Hide();
                   
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı veya Parola !","Hatalı Giriş Denemesi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                textBox1.Text = "";
                textBox2.Text = "";
            }
            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
