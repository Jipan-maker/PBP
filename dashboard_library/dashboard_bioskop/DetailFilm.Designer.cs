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
            this.pbPosterUtama = new System.Windows.Forms.PictureBox();
            this.pnlTombol = new System.Windows.Forms.Panel();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblImdb = new System.Windows.Forms.Label();
            this.lblRotten = new System.Windows.Forms.Label();
            this.lblIgn = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnBookTicket = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblCast = new System.Windows.Forms.Label();
            this.lblDeskripsi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPosterUtama)).BeginInit();
            this.pnlTombol.SuspendLayout();
            this.pnlDetail.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPosterUtama
            // 
            this.pbPosterUtama.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbPosterUtama.Location = new System.Drawing.Point(0, 0);
            this.pbPosterUtama.Name = "pbPosterUtama";
            this.pbPosterUtama.Size = new System.Drawing.Size(458, 255);
            this.pbPosterUtama.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPosterUtama.TabIndex = 1;
            this.pbPosterUtama.TabStop = false;
            // 
            // pnlTombol
            // 
            this.pnlTombol.Controls.Add(this.btnBookTicket);
            this.pnlTombol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTombol.Location = new System.Drawing.Point(0, 732);
            this.pnlTombol.Name = "pnlTombol";
            this.pnlTombol.Size = new System.Drawing.Size(458, 62);
            this.pnlTombol.TabIndex = 2;
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.lblDeskripsi);
            this.pnlDetail.Controls.Add(this.lblCast);
            this.pnlDetail.Controls.Add(this.textBox3);
            this.pnlDetail.Controls.Add(this.textBox2);
            this.pnlDetail.Controls.Add(this.textBox1);
            this.pnlDetail.Controls.Add(this.richTextBox1);
            this.pnlDetail.Controls.Add(this.lblIgn);
            this.pnlDetail.Controls.Add(this.lblRotten);
            this.pnlDetail.Controls.Add(this.lblImdb);
            this.pnlDetail.Controls.Add(this.lblJudul);
            this.pnlDetail.Controls.Add(this.flowLayoutPanel1);
            this.pnlDetail.Location = new System.Drawing.Point(0, 261);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(458, 458);
            this.pnlDetail.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBox2);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox3);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox4);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 158);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(434, 108);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(82, 33);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back\r\n";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Location = new System.Drawing.Point(13, 21);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(72, 20);
            this.lblJudul.TabIndex = 1;
            this.lblJudul.Text = "Upin Ipin\r\n";
            // 
            // lblImdb
            // 
            this.lblImdb.AutoSize = true;
            this.lblImdb.Location = new System.Drawing.Point(13, 73);
            this.lblImdb.Name = "lblImdb";
            this.lblImdb.Size = new System.Drawing.Size(52, 20);
            this.lblImdb.TabIndex = 2;
            this.lblImdb.Text = "IMDb:";
            // 
            // lblRotten
            // 
            this.lblRotten.AutoSize = true;
            this.lblRotten.Location = new System.Drawing.Point(159, 73);
            this.lblRotten.Name = "lblRotten";
            this.lblRotten.Size = new System.Drawing.Size(62, 20);
            this.lblRotten.TabIndex = 3;
            this.lblRotten.Text = "Rotten:";
            // 
            // lblIgn
            // 
            this.lblIgn.AutoSize = true;
            this.lblIgn.Location = new System.Drawing.Point(325, 73);
            this.lblIgn.Name = "lblIgn";
            this.lblIgn.Size = new System.Drawing.Size(42, 20);
            this.lblIgn.TabIndex = 4;
            this.lblIgn.Text = "IGN:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 105);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(109, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 105);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(215, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 105);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(321, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 105);
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(3, 311);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(455, 144);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // btnBookTicket
            // 
            this.btnBookTicket.Location = new System.Drawing.Point(178, 18);
            this.btnBookTicket.Name = "btnBookTicket";
            this.btnBookTicket.Size = new System.Drawing.Size(116, 32);
            this.btnBookTicket.TabIndex = 0;
            this.btnBookTicket.Text = "Book Tickets\r\n";
            this.btnBookTicket.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 26);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(227, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(81, 26);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(373, 73);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(72, 26);
            this.textBox3.TabIndex = 8;
            // 
            // lblCast
            // 
            this.lblCast.AutoSize = true;
            this.lblCast.Location = new System.Drawing.Point(12, 122);
            this.lblCast.Name = "lblCast";
            this.lblCast.Size = new System.Drawing.Size(46, 20);
            this.lblCast.TabIndex = 9;
            this.lblCast.Text = "Cast:";
            // 
            // lblDeskripsi
            // 
            this.lblDeskripsi.AutoSize = true;
            this.lblDeskripsi.Location = new System.Drawing.Point(14, 288);
            this.lblDeskripsi.Name = "lblDeskripsi";
            this.lblDeskripsi.Size = new System.Drawing.Size(93, 20);
            this.lblDeskripsi.TabIndex = 10;
            this.lblDeskripsi.Text = "Description:";
            // 
            // DetailFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 794);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlDetail);
            this.Controls.Add(this.pnlTombol);
            this.Controls.Add(this.pbPosterUtama);
            this.Name = "DetailFilm";
            this.Text = "DetailFilm";
            ((System.ComponentModel.ISupportInitialize)(this.pbPosterUtama)).EndInit();
            this.pnlTombol.ResumeLayout(false);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
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
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblIgn;
        private System.Windows.Forms.Label lblRotten;
        private System.Windows.Forms.Label lblImdb;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnBack;
    }
}