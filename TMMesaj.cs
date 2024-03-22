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
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace GarantiKitap
{
    public partial class TMMesaj : Form
    {
        public TMMesaj()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string[] tumtelefonlar;

        public class Messages
        {
            public AuthInfo auth { get; set; }
            public string MsgType { get; set; }
            public string DataCoding { get; set; }
            public string Originator { get; set; }
            public string Message { get; set; }
            public List<string> To { get; set; }
        }

        public class AuthInfo
        {
            public string username { get; set; }
            public string password { get; set; }
        }
        //
        private async void btn1_Click(object sender, EventArgs e) 
        {
            //public string MySqlBaglanti = "SERVER=192.198.1.1;" + "DATABASE=veritabaniAdi;" + "UID=kullaniciAdi;" + "PASSWORD=sifre;";
            //MySqlConnection con = new MySqlConnection("Server=localhost;Database=garantikitap;Uid=root;Pwd='';");

            using (MySqlConnection con = new MySqlConnection("Server=85.111.5.88;Database=iyonyaso_kitaplik;Uid=iyonyaso_kitaplik;Pwd='Ezber2000?';"))
            {
                con.Open();

                MySqlCommand command = new MySqlCommand("SELECT * FROM musteriler", con);
                MySqlDataReader reader = command.ExecuteReader();
                
                

               
                List<string> numbers = new List<string>();

                while (reader.Read())
                {
                    string phoneNumber = reader.GetString(2); // 'phoneNumber' sütununun indeksini doğru şekilde ayarlayın
                    numbers.Add(phoneNumber);
                }
                reader.Close();

                MySqlCommand command2 = new MySqlCommand("SELECT * FROM smshesap WHERE ID = 1", con);
                MySqlDataReader reader2 = command2.ExecuteReader();

                reader2.Read();

                string smskadi = reader2.GetString(1);
                string smspasssif = reader2.GetString(2);
                string link = reader2.GetString(3);


                reader2.Close();

                string baslik = listBox1.Text;
                string mesaj = textBox1.Text;
                



                string formattedNumbers = string.Join(",", numbers.Select(numara => numara));
                List<string> formattedNumbersList = formattedNumbers.Split(',').Select(number => $"{number}").ToList();

                
                

                Messages message = new Messages()
                {
                    auth = new AuthInfo()
                    {
                        username = smskadi,
                        password = smspasssif
                    },
                    MsgType = "Turkey",
                    DataCoding = "Standart",
                    Originator = baslik,
                    Message = mesaj,
                    To = formattedNumbersList
                };

                string jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(message);


                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Post, link);

                var content = new StringContent(jsonString, null, "application/json");

                request.Content = content;

                var response = await client.SendAsync(request);

                response.EnsureSuccessStatusCode();

                string responseContent = await response.Content.ReadAsStringAsync();

                MessageBox.Show("Mesaj Geçerli Numaralı Müşterilere Gönderildi");
            }
        }

        private void TMMesaj_Load(object sender, EventArgs e)
        {

            using (MySqlConnection con = new MySqlConnection("Server=85.111.5.88;Database=iyonyaso_kitaplik;Uid=iyonyaso_kitaplik;Pwd='Ezber2000?';"))
            {
                con.Open();

                MySqlCommand command = new MySqlCommand("SELECT * FROM basliklar", con);
                MySqlDataReader reader = command.ExecuteReader();



                while (reader.Read())
                {
                    string baslik = reader.GetString(1); // 'phoneNumber' sütununun indeksini doğru şekilde ayarlayın
                    listBox1.Items.Add(baslik);
             
                }

                reader.Close();

              
               
            }

        }
    }
}
