namespace dashboard_library
{
    partial class FormUtama
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.cbGenreFilter = new System.Windows.Forms.ComboBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvFilm = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbPosterPreview = new System.Windows.Forms.PictureBox();
            this.lblSutradaraPreview = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rtbSinopsisPreview = new System.Windows.Forms.RichTextBox();
            this.lblTotalKoleksi = new System.Windows.Forms.Label();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilm)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPosterPreview)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTambah);
            this.panel1.Controls.Add(this.cbGenreFilter);
            this.panel1.Controls.Add(this.txtCari);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1418, 59);
            this.panel1.TabIndex = 0;
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(32, 13);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(424, 26);
            this.txtCari.TabIndex = 0;
            // 
            // cbGenreFilter
            // 
            this.cbGenreFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenreFilter.FormattingEnabled = true;
            this.cbGenreFilter.Location = new System.Drawing.Point(626, 16);
            this.cbGenreFilter.Name = "cbGenreFilter";
            this.cbGenreFilter.Size = new System.Drawing.Size(381, 28);
            this.cbGenreFilter.TabIndex = 1;
            // 
            // btnTambah
            // 
            this.btnTambah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTambah.Location = new System.Drawing.Point(1099, 12);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(266, 35);
            this.btnTambah.TabIndex = 2;
            this.btnTambah.Text = "+ Tambah Film Baru";
            this.btnTambah.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.dgvFilm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1418, 785);
            this.panel2.TabIndex = 1;
            // 
            // dgvFilm
            // 
            this.dgvFilm.AllowUserToAddRows = false;
            this.dgvFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilm.Location = new System.Drawing.Point(12, 6);
            this.dgvFilm.MultiSelect = false;
            this.dgvFilm.Name = "dgvFilm";
            this.dgvFilm.RowTemplate.Height = 28;
            this.dgvFilm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilm.Size = new System.Drawing.Size(822, 565);
            this.dgvFilm.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSutradaraPreview);
            this.groupBox1.Controls.Add(this.pbPosterPreview);
            this.groupBox1.Location = new System.Drawing.Point(878, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 582);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preview Film";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pbPosterPreview
            // 
            this.pbPosterPreview.Location = new System.Drawing.Point(24, 35);
            this.pbPosterPreview.Name = "pbPosterPreview";
            this.pbPosterPreview.Size = new System.Drawing.Size(453, 469);
            this.pbPosterPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPosterPreview.TabIndex = 0;
            this.pbPosterPreview.TabStop = false;
            // 
            // lblSutradaraPreview
            // 
            this.lblSutradaraPreview.AutoSize = true;
            this.lblSutradaraPreview.Location = new System.Drawing.Point(32, 535);
            this.lblSutradaraPreview.Name = "lblSutradaraPreview";
            this.lblSutradaraPreview.Size = new System.Drawing.Size(97, 20);
            this.lblSutradaraPreview.TabIndex = 1;
            this.lblSutradaraPreview.Text = "Sutradara : -";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnHapus);
            this.panel3.Controls.Add(this.btnUbah);
            this.panel3.Controls.Add(this.lblTotalKoleksi);
            this.panel3.Controls.Add(this.rtbSinopsisPreview);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 604);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1418, 181);
            this.panel3.TabIndex = 2;
            // 
            // rtbSinopsisPreview
            // 
            this.rtbSinopsisPreview.Location = new System.Drawing.Point(12, 15);
            this.rtbSinopsisPreview.Name = "rtbSinopsisPreview";
            this.rtbSinopsisPreview.ReadOnly = true;
            this.rtbSinopsisPreview.Size = new System.Drawing.Size(1394, 94);
            this.rtbSinopsisPreview.TabIndex = 0;
            this.rtbSinopsisPreview.Text = "Detail sinopsis akan muncul disini...";
            // 
            // lblTotalKoleksi
            // 
            this.lblTotalKoleksi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalKoleksi.AutoSize = true;
            this.lblTotalKoleksi.Location = new System.Drawing.Point(1209, 133);
            this.lblTotalKoleksi.Name = "lblTotalKoleksi";
            this.lblTotalKoleksi.Size = new System.Drawing.Size(152, 20);
            this.lblTotalKoleksi.TabIndex = 1;
            this.lblTotalKoleksi.Text = "Total Koleksi : 0 Film";
            this.lblTotalKoleksi.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(48, 133);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(75, 23);
            this.btnUbah.TabIndex = 2;
            this.btnUbah.Text = "Ubah Detail";
            this.btnUbah.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(414, 133);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus Film";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 844);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormUtama";
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilm)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPosterPreview)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.ComboBox cbGenreFilter;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSutradaraPreview;
        private System.Windows.Forms.PictureBox pbPosterPreview;
        private System.Windows.Forms.DataGridView dgvFilm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalKoleksi;
        private System.Windows.Forms.RichTextBox rtbSinopsisPreview;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
    }
}

