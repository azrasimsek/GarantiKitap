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
    public partial class YetkiliSil : Form
    {
        public YetkiliSil()
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
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {

            string selectedIDs = "";

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string id = row.Cells["ID"].Value.ToString();
               
                string sql = "DELETE FROM yetkililer WHERE ID=@ID";
                cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ID", id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            VeriGetir();

            MessageBox.Show("Yetkili silindi", "Yetkili Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //MessageBox.Show("Seçili ID'ler:\n" + selectedIDs, "Müşteri ID'leri", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void YetkiliSil_Load(object sender, EventArgs e)
        {
            VeriGetir();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "kullaniciAdi LIKE '" + textBox1.Text + "%'";
            dataGridView1.DataSource = dv;
        }
    }
}
