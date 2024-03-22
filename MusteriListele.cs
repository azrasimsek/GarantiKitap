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
    public partial class MusteriListele : Form
    {
        public MusteriListele()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("Server=85.111.5.88;Database=iyonyaso_kitaplik;Uid=iyonyaso_kitaplik;Pwd='Ezber2000?';");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        void VeriGetir()
        {
            dt= new DataTable();
            con.Open();
            adapter = new MySqlDataAdapter("SELECT *FROM musteriler",con);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void MusteriListele_Load(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "adSoyad LIKE '" + textBox1.Text + "%'";
            dataGridView1.DataSource = dv;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
