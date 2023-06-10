
namespace Cumhuriyet
{
    partial class RSS_TekHaber
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Tarih = new System.Windows.Forms.Label();
            this.pic_gorsel = new System.Windows.Forms.PictureBox();
            this.lbl_index = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.link_lbl_url = new System.Windows.Forms.LinkLabel();
            this.txt_aciklama = new System.Windows.Forms.RichTextBox();
            this.lbl_baslik = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_gorsel)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Tarih
            // 
            this.lbl_Tarih.AutoSize = true;
            this.lbl_Tarih.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tarih.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_Tarih.Location = new System.Drawing.Point(70, 170);
            this.lbl_Tarih.Name = "lbl_Tarih";
            this.lbl_Tarih.Size = new System.Drawing.Size(16, 14);
            this.lbl_Tarih.TabIndex = 17;
            this.lbl_Tarih.Text = "...";
            this.lbl_Tarih.Click += new System.EventHandler(this.lbl_Tarih_Click);
            // 
            // pic_gorsel
            // 
            this.pic_gorsel.Location = new System.Drawing.Point(73, 49);
            this.pic_gorsel.Name = "pic_gorsel";
            this.pic_gorsel.Size = new System.Drawing.Size(162, 99);
            this.pic_gorsel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_gorsel.TabIndex = 16;
            this.pic_gorsel.TabStop = false;
            this.pic_gorsel.Click += new System.EventHandler(this.pic_gorsel_Click);
            // 
            // lbl_index
            // 
            this.lbl_index.AutoSize = true;
            this.lbl_index.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_index.ForeColor = System.Drawing.Color.Tomato;
            this.lbl_index.Location = new System.Drawing.Point(9, 84);
            this.lbl_index.Name = "lbl_index";
            this.lbl_index.Size = new System.Drawing.Size(31, 19);
            this.lbl_index.TabIndex = 15;
            this.lbl_index.Text = "99.";
            this.lbl_index.Click += new System.EventHandler(this.lbl_index_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(49, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(5, 200);
            this.label2.TabIndex = 13;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // link_lbl_url
            // 
            this.link_lbl_url.AutoSize = true;
            this.link_lbl_url.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.link_lbl_url.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.link_lbl_url.Location = new System.Drawing.Point(238, 169);
            this.link_lbl_url.Name = "link_lbl_url";
            this.link_lbl_url.Size = new System.Drawing.Size(16, 15);
            this.link_lbl_url.TabIndex = 11;
            this.link_lbl_url.TabStop = true;
            this.link_lbl_url.Text = "...";
            this.link_lbl_url.VisitedLinkColor = System.Drawing.Color.DeepPink;
            this.link_lbl_url.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_lbl_url_LinkClicked);
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.BackColor = System.Drawing.SystemColors.InfoText;
            this.txt_aciklama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_aciklama.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_aciklama.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_aciklama.Location = new System.Drawing.Point(241, 36);
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Size = new System.Drawing.Size(1049, 125);
            this.txt_aciklama.TabIndex = 10;
            this.txt_aciklama.Text = "";
            this.txt_aciklama.TextChanged += new System.EventHandler(this.txt_aciklama_TextChanged);
            // 
            // lbl_baslik
            // 
            this.lbl_baslik.AutoSize = true;
            this.lbl_baslik.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_baslik.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_baslik.Location = new System.Drawing.Point(70, 15);
            this.lbl_baslik.Name = "lbl_baslik";
            this.lbl_baslik.Size = new System.Drawing.Size(56, 19);
            this.lbl_baslik.TabIndex = 9;
            this.lbl_baslik.Text = "Baslık";
            this.lbl_baslik.Click += new System.EventHandler(this.lbl_baslik_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1313, 190);
            this.label1.TabIndex = 12;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RSS_TekHaber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.lbl_Tarih);
            this.Controls.Add(this.pic_gorsel);
            this.Controls.Add(this.lbl_index);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.link_lbl_url);
            this.Controls.Add(this.txt_aciklama);
            this.Controls.Add(this.lbl_baslik);
            this.Controls.Add(this.label1);
            this.Name = "RSS_TekHaber";
            this.Size = new System.Drawing.Size(1319, 200);
            ((System.ComponentModel.ISupportInitialize)(this.pic_gorsel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_Tarih;
        public System.Windows.Forms.PictureBox pic_gorsel;
        public System.Windows.Forms.Label lbl_index;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.LinkLabel link_lbl_url;
        public System.Windows.Forms.RichTextBox txt_aciklama;
        public System.Windows.Forms.Label lbl_baslik;
        private System.Windows.Forms.Label label1;
    }
}
