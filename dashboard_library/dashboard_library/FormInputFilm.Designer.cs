namespace dashboard_library
{
    partial class FormInputFilm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtJudul = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbGenreInput = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudTahun = new System.Windows.Forms.NumericUpDown();
            this.nudRating = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSutradara = new System.Windows.Forms.TextBox();
            this.rtbSinopsisInput = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.pbPosterInput = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudTahun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPosterInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Judul Film";
            // 
            // txtJudul
            // 
            this.txtJudul.Location = new System.Drawing.Point(26, 47);
            this.txtJudul.Name = "txtJudul";
            this.txtJudul.Size = new System.Drawing.Size(151, 26);
            this.txtJudul.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Genre";
            // 
            // cbGenreInput
            // 
            this.cbGenreInput.FormattingEnabled = true;
            this.cbGenreInput.Items.AddRange(new object[] {
            "Action",
            "Drama",
            "Romance",
            "Sci-fi",
            "Horror",
            "Thriller",
            "Comedy"});
            this.cbGenreInput.Location = new System.Drawing.Point(26, 147);
            this.cbGenreInput.Name = "cbGenreInput";
            this.cbGenreInput.Size = new System.Drawing.Size(151, 28);
            this.cbGenreInput.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tahun Rilis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Rating (1-10)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // nudTahun
            // 
            this.nudTahun.Location = new System.Drawing.Point(26, 237);
            this.nudTahun.Maximum = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            this.nudTahun.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudTahun.Name = "nudTahun";
            this.nudTahun.Size = new System.Drawing.Size(151, 26);
            this.nudTahun.TabIndex = 6;
            this.nudTahun.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // nudRating
            // 
            this.nudRating.DecimalPlaces = 1;
            this.nudRating.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudRating.Location = new System.Drawing.Point(207, 237);
            this.nudRating.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudRating.Name = "nudRating";
            this.nudRating.Size = new System.Drawing.Size(139, 26);
            this.nudRating.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sutradara";
            // 
            // txtSutradara
            // 
            this.txtSutradara.Location = new System.Drawing.Point(26, 330);
            this.txtSutradara.Name = "txtSutradara";
            this.txtSutradara.Size = new System.Drawing.Size(320, 26);
            this.txtSutradara.TabIndex = 9;
            // 
            // rtbSinopsisInput
            // 
            this.rtbSinopsisInput.Location = new System.Drawing.Point(26, 428);
            this.rtbSinopsisInput.Name = "rtbSinopsisInput";
            this.rtbSinopsisInput.Size = new System.Drawing.Size(524, 96);
            this.rtbSinopsisInput.TabIndex = 10;
            this.rtbSinopsisInput.Text = "";
            this.rtbSinopsisInput.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sinopsis Cerita";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(261, 567);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(127, 35);
            this.btnSimpan.TabIndex = 12;
            this.btnSimpan.Text = "Simpan Data";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(463, 567);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(87, 35);
            this.btnBatal.TabIndex = 13;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // pbPosterInput
            // 
            this.pbPosterInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPosterInput.Location = new System.Drawing.Point(374, 23);
            this.pbPosterInput.Name = "pbPosterInput";
            this.pbPosterInput.Size = new System.Drawing.Size(176, 251);
            this.pbPosterInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPosterInput.TabIndex = 14;
            this.pbPosterInput.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(374, 289);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(176, 35);
            this.btnBrowse.TabIndex = 15;
            this.btnBrowse.Text = "Pilih Gambar / Poster";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // FormInputFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 647);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.pbPosterInput);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtbSinopsisInput);
            this.Controls.Add(this.txtSutradara);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudRating);
            this.Controls.Add(this.nudTahun);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbGenreInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtJudul);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormInputFilm";
            this.Text = "Kelola Data Film";
            ((System.ComponentModel.ISupportInitialize)(this.nudTahun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPosterInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJudul;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbGenreInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudTahun;
        private System.Windows.Forms.NumericUpDown nudRating;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSutradara;
        private System.Windows.Forms.RichTextBox rtbSinopsisInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.PictureBox pbPosterInput;
        private System.Windows.Forms.Button btnBrowse;
    }
}