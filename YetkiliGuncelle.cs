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
    public partial class YetkiliGuncelle : Form
    {
        public YetkiliGuncelle()
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
            adapter = new MySqlDataAdapter("SELECT *FROM yetkililer", con);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void YetkiliGuncelle_Load(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "kullaniciAdi LIKE '" + txtAra.Text + "%'";
            dataGridView1.DataSource = dv;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string sql = "UPDATE yetkililer SET kullaniciAdi=@kullaniciAdi,sifre=@sifre " + "WHERE ID=@ID";
            cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@kullaniciAdi", txtkullaniciAdi.Text);
            cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);
            cmd.Parameters.AddWithValue("@ID", txtID.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            VeriGetir();
            MessageBox.Show("Yetkili Kaydı Güncellendi.", "Yetkili Güncelleme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtID.Text = "";
            txtkullaniciAdi.Text = "";
            txtSifre.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtkullaniciAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtSifre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
            catch
            {

            }
        }
    }
}
