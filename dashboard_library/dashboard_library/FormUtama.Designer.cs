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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUtama));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnTambah = new System.Windows.Forms.Button();
            this.cbGenreFilter = new System.Windows.Forms.ComboBox();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.lblTotalKoleksi = new System.Windows.Forms.Label();
            this.rtbSinopsisPreview = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSutradaraPreview = new System.Windows.Forms.Label();
            this.pbPosterPreview = new System.Windows.Forms.PictureBox();
            this.dgvFilm = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPosterPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Lavender;
            this.pnlHeader.Controls.Add(this.btnTambah);
            this.pnlHeader.Controls.Add(this.cbGenreFilter);
            this.pnlHeader.Controls.Add(this.txtCari);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1576, 68);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // btnTambah
            // 
            this.btnTambah.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTambah.Location = new System.Drawing.Point(1221, 14);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(296, 40);
            this.btnTambah.TabIndex = 2;
            this.btnTambah.Text = "+ Tambah Film Baru";
            this.btnTambah.UseVisualStyleBackColor = true;
            // 
            // cbGenreFilter
            // 
            this.cbGenreFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenreFilter.FormattingEnabled = true;
            this.cbGenreFilter.Location = new System.Drawing.Point(696, 18);
            this.cbGenreFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbGenreFilter.Name = "cbGenreFilter";
            this.cbGenreFilter.Size = new System.Drawing.Size(423, 31);
            this.cbGenreFilter.TabIndex = 1;
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(39, 20);
            this.txtCari.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(471, 30);
            this.txtCari.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FloralWhite;
            this.pnlMain.Controls.Add(this.pnlFooter);
            this.pnlMain.Controls.Add(this.groupBox1);
            this.pnlMain.Controls.Add(this.dgvFilm);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 68);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1576, 903);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(203)))), ((int)(((byte)(139)))));
            this.pnlFooter.Controls.Add(this.btnHapus);
            this.pnlFooter.Controls.Add(this.btnUbah);
            this.pnlFooter.Controls.Add(this.lblTotalKoleksi);
            this.pnlFooter.Controls.Add(this.rtbSinopsisPreview);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 695);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1576, 208);
            this.pnlFooter.TabIndex = 2;
            // 
            // btnHapus
            // 
            this.btnHapus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHapus.Location = new System.Drawing.Point(460, 153);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(83, 41);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus Film";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnUbah
            // 
            this.btnUbah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUbah.Location = new System.Drawing.Point(53, 153);
            this.btnUbah.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(83, 41);
            this.btnUbah.TabIndex = 2;
            this.btnUbah.Text = "Ubah Detail";
            this.btnUbah.UseVisualStyleBackColor = true;
            // 
            // lblTotalKoleksi
            // 
            this.lblTotalKoleksi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalKoleksi.AutoSize = true;
            this.lblTotalKoleksi.Location = new System.Drawing.Point(1343, 153);
            this.lblTotalKoleksi.Name = "lblTotalKoleksi";
            this.lblTotalKoleksi.Size = new System.Drawing.Size(167, 23);
            this.lblTotalKoleksi.TabIndex = 1;
            this.lblTotalKoleksi.Text = "Total Koleksi : 0 Film";
            this.lblTotalKoleksi.Click += new System.EventHandler(this.label1_Click);
            // 
            // rtbSinopsisPreview
            // 
            this.rtbSinopsisPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbSinopsisPreview.Location = new System.Drawing.Point(13, 17);
            this.rtbSinopsisPreview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbSinopsisPreview.Name = "rtbSinopsisPreview";
            this.rtbSinopsisPreview.ReadOnly = true;
            this.rtbSinopsisPreview.Size = new System.Drawing.Size(1548, 108);
            this.rtbSinopsisPreview.TabIndex = 0;
            this.rtbSinopsisPreview.Text = "Detail sinopsis akan muncul disini...";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblSutradaraPreview);
            this.groupBox1.Controls.Add(this.pbPosterPreview);
            this.groupBox1.Location = new System.Drawing.Point(976, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(552, 671);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preview Film";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblSutradaraPreview
            // 
            this.lblSutradaraPreview.AutoSize = true;
            this.lblSutradaraPreview.Location = new System.Drawing.Point(36, 615);
            this.lblSutradaraPreview.Name = "lblSutradaraPreview";
            this.lblSutradaraPreview.Size = new System.Drawing.Size(107, 23);
            this.lblSutradaraPreview.TabIndex = 1;
            this.lblSutradaraPreview.Text = "Sutradara : -";
            // 
            // pbPosterPreview
            // 
            this.pbPosterPreview.Location = new System.Drawing.Point(27, 40);
            this.pbPosterPreview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbPosterPreview.Name = "pbPosterPreview";
            this.pbPosterPreview.Size = new System.Drawing.Size(503, 539);
            this.pbPosterPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPosterPreview.TabIndex = 0;
            this.pbPosterPreview.TabStop = false;
            // 
            // dgvFilm
            // 
            this.dgvFilm.AllowUserToAddRows = false;
            this.dgvFilm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFilm.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgvFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilm.Location = new System.Drawing.Point(13, 6);
            this.dgvFilm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvFilm.MultiSelect = false;
            this.dgvFilm.Name = "dgvFilm";
            this.dgvFilm.RowTemplate.Height = 28;
            this.dgvFilm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilm.Size = new System.Drawing.Size(913, 650);
            this.dgvFilm.TabIndex = 0;
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 971);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormUtama";
            this.Text = "Home";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPosterPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.ComboBox cbGenreFilter;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSutradaraPreview;
        private System.Windows.Forms.PictureBox pbPosterPreview;
        private System.Windows.Forms.DataGridView dgvFilm;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblTotalKoleksi;
        private System.Windows.Forms.RichTextBox rtbSinopsisPreview;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
    }
}

