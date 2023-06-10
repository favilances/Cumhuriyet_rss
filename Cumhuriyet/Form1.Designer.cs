
namespace Cumhuriyet
{
    partial class Form1
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gundembutton = new Guna.UI2.WinForms.Guna2Button();
            this.kultursanatbutton = new Guna.UI2.WinForms.Guna2Button();
            this.cevrebutton = new Guna.UI2.WinForms.Guna2Button();
            this.magazinbutton = new Guna.UI2.WinForms.Guna2Button();
            this.yasambutton = new Guna.UI2.WinForms.Guna2Button();
            this.saglikbutton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.saglikbutton);
            this.panel1.Controls.Add(this.yasambutton);
            this.panel1.Controls.Add(this.magazinbutton);
            this.panel1.Controls.Add(this.cevrebutton);
            this.panel1.Controls.Add(this.kultursanatbutton);
            this.panel1.Controls.Add(this.gundembutton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1336, 53);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // gundembutton
            // 
            this.gundembutton.BorderRadius = 20;
            this.gundembutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gundembutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gundembutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gundembutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gundembutton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gundembutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gundembutton.ForeColor = System.Drawing.Color.White;
            this.gundembutton.Location = new System.Drawing.Point(172, 10);
            this.gundembutton.Name = "gundembutton";
            this.gundembutton.Size = new System.Drawing.Size(95, 36);
            this.gundembutton.TabIndex = 1;
            this.gundembutton.Text = "Gündem";
            this.gundembutton.Click += new System.EventHandler(this.gundembutton_Click);
            // 
            // kultursanatbutton
            // 
            this.kultursanatbutton.BorderRadius = 20;
            this.kultursanatbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.kultursanatbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.kultursanatbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.kultursanatbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.kultursanatbutton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.kultursanatbutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kultursanatbutton.ForeColor = System.Drawing.Color.White;
            this.kultursanatbutton.Location = new System.Drawing.Point(273, 10);
            this.kultursanatbutton.Name = "kultursanatbutton";
            this.kultursanatbutton.Size = new System.Drawing.Size(95, 36);
            this.kultursanatbutton.TabIndex = 2;
            this.kultursanatbutton.Text = "Kültür-Sanat";
            this.kultursanatbutton.Click += new System.EventHandler(this.kultursanatbutton_Click);
            // 
            // cevrebutton
            // 
            this.cevrebutton.BorderRadius = 20;
            this.cevrebutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cevrebutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cevrebutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cevrebutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cevrebutton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cevrebutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cevrebutton.ForeColor = System.Drawing.Color.White;
            this.cevrebutton.Location = new System.Drawing.Point(374, 10);
            this.cevrebutton.Name = "cevrebutton";
            this.cevrebutton.Size = new System.Drawing.Size(95, 36);
            this.cevrebutton.TabIndex = 3;
            this.cevrebutton.Text = "Çevre";
            this.cevrebutton.Click += new System.EventHandler(this.cevrebutton_Click);
            // 
            // magazinbutton
            // 
            this.magazinbutton.BorderRadius = 20;
            this.magazinbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.magazinbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.magazinbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.magazinbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.magazinbutton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.magazinbutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.magazinbutton.ForeColor = System.Drawing.Color.White;
            this.magazinbutton.Location = new System.Drawing.Point(475, 10);
            this.magazinbutton.Name = "magazinbutton";
            this.magazinbutton.Size = new System.Drawing.Size(95, 36);
            this.magazinbutton.TabIndex = 4;
            this.magazinbutton.Text = "Magazin";
            this.magazinbutton.Click += new System.EventHandler(this.magazinbutton_Click);
            // 
            // yasambutton
            // 
            this.yasambutton.BorderRadius = 20;
            this.yasambutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.yasambutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.yasambutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.yasambutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.yasambutton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.yasambutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.yasambutton.ForeColor = System.Drawing.Color.White;
            this.yasambutton.Location = new System.Drawing.Point(576, 10);
            this.yasambutton.Name = "yasambutton";
            this.yasambutton.Size = new System.Drawing.Size(95, 36);
            this.yasambutton.TabIndex = 5;
            this.yasambutton.Text = "Yaşam";
            this.yasambutton.Click += new System.EventHandler(this.yasambutton_Click);
            // 
            // saglikbutton
            // 
            this.saglikbutton.BorderRadius = 20;
            this.saglikbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saglikbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saglikbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saglikbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saglikbutton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.saglikbutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saglikbutton.ForeColor = System.Drawing.Color.White;
            this.saglikbutton.Location = new System.Drawing.Point(677, 10);
            this.saglikbutton.Name = "saglikbutton";
            this.saglikbutton.Size = new System.Drawing.Size(95, 36);
            this.saglikbutton.TabIndex = 6;
            this.saglikbutton.Text = "Sağlık";
            this.saglikbutton.Click += new System.EventHandler(this.saglikbutton_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(778, 10);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(127, 36);
            this.guna2Button1.TabIndex = 7;
            this.guna2Button1.Text = "Bilim - Teknoloji";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-2, 54);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1327, 704);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Cumhuriyet.Properties.Resources.mazew;
            this.pictureBox2.Location = new System.Drawing.Point(1244, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cumhuriyet.Properties.Resources.logo_cumhuriyet_gazetesi;
            this.pictureBox1.Location = new System.Drawing.Point(0, -18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1326, 755);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1342, 794);
            this.MinimumSize = new System.Drawing.Size(1342, 794);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cumhuriyet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button gundembutton;
        private Guna.UI2.WinForms.Guna2Button kultursanatbutton;
        private Guna.UI2.WinForms.Guna2Button cevrebutton;
        private Guna.UI2.WinForms.Guna2Button magazinbutton;
        private Guna.UI2.WinForms.Guna2Button yasambutton;
        private Guna.UI2.WinForms.Guna2Button saglikbutton;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

