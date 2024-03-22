namespace GarantiKitap
{
    partial class YetkiliIslem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YetkiliIslem));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMEkle = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnMListele = new System.Windows.Forms.Button();
            this.btnMGuncelle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(178, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnMEkle
            // 
            this.btnMEkle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMEkle.Location = new System.Drawing.Point(129, 21);
            this.btnMEkle.Name = "btnMEkle";
            this.btnMEkle.Size = new System.Drawing.Size(257, 54);
            this.btnMEkle.TabIndex = 0;
            this.btnMEkle.Text = "Müşteri Ekle";
            this.btnMEkle.UseVisualStyleBackColor = false;
            this.btnMEkle.Click += new System.EventHandler(this.btnMEkle_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Red;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCikis.Location = new System.Drawing.Point(129, 451);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(257, 48);
            this.btnCikis.TabIndex = 4;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnMListele
            // 
            this.btnMListele.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMListele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMListele.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMListele.Location = new System.Drawing.Point(129, 332);
            this.btnMListele.Name = "btnMListele";
            this.btnMListele.Size = new System.Drawing.Size(257, 56);
            this.btnMListele.TabIndex = 3;
            this.btnMListele.Text = "Müşterileri Listele";
            this.btnMListele.UseVisualStyleBackColor = false;
            this.btnMListele.Click += new System.EventHandler(this.btnMListele_Click);
            // 
            // btnMGuncelle
            // 
            this.btnMGuncelle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMGuncelle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMGuncelle.Location = new System.Drawing.Point(129, 121);
            this.btnMGuncelle.Name = "btnMGuncelle";
            this.btnMGuncelle.Size = new System.Drawing.Size(257, 56);
            this.btnMGuncelle.TabIndex = 1;
            this.btnMGuncelle.Text = "Müşteri Güncelle";
            this.btnMGuncelle.UseVisualStyleBackColor = false;
            this.btnMGuncelle.Click += new System.EventHandler(this.btnMGuncelle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnMEkle);
            this.groupBox1.Controls.Add(this.btnCikis);
            this.groupBox1.Controls.Add(this.btnMListele);
            this.groupBox1.Controls.Add(this.btnMGuncelle);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(12, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 525);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yetkili İşlemleri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(129, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "Müşteri Sil";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // YetkiliIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(529, 675);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YetkiliIslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yetkili İşlemleri";
            this.Load += new System.EventHandler(this.YetkiliIslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMEkle;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnMListele;
        private System.Windows.Forms.Button btnMGuncelle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}