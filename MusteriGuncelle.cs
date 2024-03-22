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
    public partial class MusteriGuncelle : Form
    {
        public MusteriGuncelle()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("Server=85.111.5.88;Database=iyonyaso_kitaplik;Uid=iyonyaso_kitaplik;Pwd='Ezber2000?';");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        void VeriGetir()
        {
            dt = new DataTable();
            con.Open();
            adapter = new MySqlDataAdapter("SELECT *FROM musteriler", con);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE musteriler SET adSoyad=@adSoyad,telefon=@telefon " + "WHERE ID=@ID";
            cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@adSoyad", txtAdSoyad.Text);
            cmd.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            cmd.Parameters.AddWithValue("@ID", txtID.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            VeriGetir();
            MessageBox.Show("Müşteri Kaydı Güncellendi.", "Müşteri Güncelleme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtID.Text = "";
            txtAdSoyad.Text = "";
            txtTelefon.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MusteriGuncelle_Load(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "adSoyad LIKE '" + txtAra.Text + "%'";
            dataGridView1.DataSource= dv;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtAdSoyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtTelefon.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
            catch 
            {

            }
        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
