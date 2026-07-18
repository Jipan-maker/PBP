namespace dashboard_bioskop
{
    partial class DetailFilm
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
            this.pnlTombol = new System.Windows.Forms.Panel();
            this.btnUpdateFilm = new System.Windows.Forms.Button();
            this.btnBookTicket = new System.Windows.Forms.Button();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.txtJudul = new System.Windows.Forms.TextBox();
            this.lblDeskripsi = new System.Windows.Forms.Label();
            this.lblCast = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rtbSinopsis = new System.Windows.Forms.RichTextBox();
            this.lblIgn = new System.Windows.Forms.Label();
            this.lblRotten = new System.Windows.Forms.Label();
            this.lblImdb = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pbCast1 = new System.Windows.Forms.PictureBox();
            this.pbCast2 = new System.Windows.Forms.PictureBox();
            this.pbCast3 = new System.Windows.Forms.PictureBox();
            this.pbCast4 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.pbPosterUtama = new System.Windows.Forms.PictureBox();
            this.pnlTombol.SuspendLayout();
            this.pnlDetail.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCast1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCast2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCast3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCast4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPosterUtama)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTombol
            // 
            this.pnlTombol.Controls.Add(this.btnUpdateFilm);
            this.pnlTombol.Controls.Add(this.btnBookTicket);
            this.pnlTombol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTombol.Location = new System.Drawing.Point(0, 735);
            this.pnlTombol.Name = "pnlTombol";
            this.pnlTombol.Size = new System.Drawing.Size(504, 62);
            this.pnlTombol.TabIndex = 2;
            // 
            // btnUpdateFilm
            // 
            this.btnUpdateFilm.Location = new System.Drawing.Point(308, 18);
            this.btnUpdateFilm.Name = "btnUpdateFilm";
            this.btnUpdateFilm.Size = new System.Drawing.Size(125, 32);
            this.btnUpdateFilm.TabIndex = 1;
            this.btnUpdateFilm.Text = "Update Film";
            this.btnUpdateFilm.UseVisualStyleBackColor = true;
            this.btnUpdateFilm.Click += new System.EventHandler(this.btnUpdateFilm_Click);
            // 
            // btnBookTicket
            // 
            this.btnBookTicket.Location = new System.Drawing.Point(35, 18);
            this.btnBookTicket.Name = "btnBookTicket";
            this.btnBookTicket.Size = new System.Drawing.Size(116, 32);
            this.btnBookTicket.TabIndex = 0;
            this.btnBookTicket.Text = "Book Tickets\r\n";
            this.btnBookTicket.UseVisualStyleBackColor = true;
            this.btnBookTicket.Click += new System.EventHandler(this.btnBookTicket_Click);
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.txtKategori);
            this.pnlDetail.Controls.Add(this.txtJudul);
            this.pnlDetail.Controls.Add(this.lblDeskripsi);
            this.pnlDetail.Controls.Add(this.lblCast);
            this.pnlDetail.Controls.Add(this.textBox3);
            this.pnlDetail.Controls.Add(this.textBox2);
            this.pnlDetail.Controls.Add(this.textBox1);
            this.pnlDetail.Controls.Add(this.rtbSinopsis);
            this.pnlDetail.Controls.Add(this.lblIgn);
            this.pnlDetail.Controls.Add(this.lblRotten);
            this.pnlDetail.Controls.Add(this.lblImdb);
            this.pnlDetail.Controls.Add(this.flowLayoutPanel1);
            this.pnlDetail.Location = new System.Drawing.Point(0, 261);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(475, 459);
            this.pnlDetail.TabIndex = 3;
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(12, 57);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(95, 26);
            this.txtKategori.TabIndex = 12;
            // 
            // txtJudul
            // 
            this.txtJudul.Location = new System.Drawing.Point(11, 11);
            this.txtJudul.Name = "txtJudul";
            this.txtJudul.Size = new System.Drawing.Size(244, 26);
            this.txtJudul.TabIndex = 11;
            // 
            // lblDeskripsi
            // 
            this.lblDeskripsi.AutoSize = true;
            this.lblDeskripsi.Location = new System.Drawing.Point(14, 294);
            this.lblDeskripsi.Name = "lblDeskripsi";
            this.lblDeskripsi.Size = new System.Drawing.Size(93, 20);
            this.lblDeskripsi.TabIndex = 10;
            this.lblDeskripsi.Text = "Description:";
            // 
            // lblCast
            // 
            this.lblCast.AutoSize = true;
            this.lblCast.Location = new System.Drawing.Point(12, 131);
            this.lblCast.Name = "lblCast";
            this.lblCast.Size = new System.Drawing.Size(46, 20);
            this.lblCast.TabIndex = 9;
            this.lblCast.Text = "Cast:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(373, 104);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(72, 26);
            this.textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(227, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(81, 26);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 26);
            this.textBox1.TabIndex = 6;
            // 
            // rtbSinopsis
            // 
            this.rtbSinopsis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbSinopsis.Location = new System.Drawing.Point(3, 320);
            this.rtbSinopsis.Name = "rtbSinopsis";
            this.rtbSinopsis.Size = new System.Drawing.Size(463, 144);
            this.rtbSinopsis.TabIndex = 5;
            this.rtbSinopsis.Text = "";
            // 
            // lblIgn
            // 
            this.lblIgn.AutoSize = true;
            this.lblIgn.Location = new System.Drawing.Point(325, 104);
            this.lblIgn.Name = "lblIgn";
            this.lblIgn.Size = new System.Drawing.Size(42, 20);
            this.lblIgn.TabIndex = 4;
            this.lblIgn.Text = "IGN:";
            // 
            // lblRotten
            // 
            this.lblRotten.AutoSize = true;
            this.lblRotten.Location = new System.Drawing.Point(159, 104);
            this.lblRotten.Name = "lblRotten";
            this.lblRotten.Size = new System.Drawing.Size(62, 20);
            this.lblRotten.TabIndex = 3;
            this.lblRotten.Text = "Rotten:";
            // 
            // lblImdb
            // 
            this.lblImdb.AutoSize = true;
            this.lblImdb.Location = new System.Drawing.Point(13, 104);
            this.lblImdb.Name = "lblImdb";
            this.lblImdb.Size = new System.Drawing.Size(52, 20);
            this.lblImdb.TabIndex = 2;
            this.lblImdb.Text = "IMDb:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pbCast1);
            this.flowLayoutPanel1.Controls.Add(this.pbCast2);
            this.flowLayoutPanel1.Controls.Add(this.pbCast3);
            this.flowLayoutPanel1.Controls.Add(this.pbCast4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 167);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(434, 108);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pbCast1
            // 
            this.pbCast1.Location = new System.Drawing.Point(3, 3);
            this.pbCast1.Name = "pbCast1";
            this.pbCast1.Size = new System.Drawing.Size(100, 105);
            this.pbCast1.TabIndex = 0;
            this.pbCast1.TabStop = false;
            // 
            // pbCast2
            // 
            this.pbCast2.Location = new System.Drawing.Point(109, 3);
            this.pbCast2.Name = "pbCast2";
            this.pbCast2.Size = new System.Drawing.Size(100, 105);
            this.pbCast2.TabIndex = 1;
            this.pbCast2.TabStop = false;
            // 
            // pbCast3
            // 
            this.pbCast3.Location = new System.Drawing.Point(215, 3);
            this.pbCast3.Name = "pbCast3";
            this.pbCast3.Size = new System.Drawing.Size(100, 105);
            this.pbCast3.TabIndex = 2;
            this.pbCast3.TabStop = false;
            // 
            // pbCast4
            // 
            this.pbCast4.Location = new System.Drawing.Point(321, 3);
            this.pbCast4.Name = "pbCast4";
            this.pbCast4.Size = new System.Drawing.Size(100, 105);
            this.pbCast4.TabIndex = 3;
            this.pbCast4.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(82, 33);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back\r\n";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pbPosterUtama
            // 
            this.pbPosterUtama.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbPosterUtama.Location = new System.Drawing.Point(0, 0);
            this.pbPosterUtama.Name = "pbPosterUtama";
            this.pbPosterUtama.Size = new System.Drawing.Size(504, 255);
            this.pbPosterUtama.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPosterUtama.TabIndex = 1;
            this.pbPosterUtama.TabStop = false;
            this.pbPosterUtama.Click += new System.EventHandler(this.pbPosterUtama_Click);
            // 
            // DetailFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(504, 797);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlDetail);
            this.Controls.Add(this.pnlTombol);
            this.Controls.Add(this.pbPosterUtama);
            this.Name = "DetailFilm";
            this.Text = "DetailFilm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DetailFilm_FormClosed);
            this.pnlTombol.ResumeLayout(false);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCast1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCast2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCast3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCast4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPosterUtama)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPosterUtama;
        private System.Windows.Forms.Panel pnlTombol;
        private System.Windows.Forms.Button btnBookTicket;
        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.Label lblDeskripsi;
        private System.Windows.Forms.Label lblCast;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox rtbSinopsis;
        private System.Windows.Forms.Label lblIgn;
        private System.Windows.Forms.Label lblRotten;
        private System.Windows.Forms.Label lblImdb;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pbCast1;
        private System.Windows.Forms.PictureBox pbCast2;
        private System.Windows.Forms.PictureBox pbCast3;
        private System.Windows.Forms.PictureBox pbCast4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdateFilm;
        private System.Windows.Forms.TextBox txtJudul;
        private System.Windows.Forms.TextBox txtKategori;
    }
}