namespace dashboard_bioskop
{
    partial class ReviewTiket
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.lblFilm = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblSeats = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCinema = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.pbBarcode = new System.Windows.Forms.PictureBox();
            this.pnlHeader.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(458, 100);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnCheckOut);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 694);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(458, 100);
            this.pnlFooter.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Tickets";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(187, 34);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(100, 35);
            this.btnCheckOut.TabIndex = 0;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.pbBarcode);
            this.pnlDetail.Controls.Add(this.textBox7);
            this.pnlDetail.Controls.Add(this.textBox6);
            this.pnlDetail.Controls.Add(this.textBox5);
            this.pnlDetail.Controls.Add(this.textBox4);
            this.pnlDetail.Controls.Add(this.textBox3);
            this.pnlDetail.Controls.Add(this.textBox2);
            this.pnlDetail.Controls.Add(this.textBox1);
            this.pnlDetail.Controls.Add(this.lblOrder);
            this.pnlDetail.Controls.Add(this.lblCinema);
            this.pnlDetail.Controls.Add(this.lblPrice);
            this.pnlDetail.Controls.Add(this.lblSeats);
            this.pnlDetail.Controls.Add(this.lblTime);
            this.pnlDetail.Controls.Add(this.lblDate);
            this.pnlDetail.Controls.Add(this.lblFilm);
            this.pnlDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetail.Location = new System.Drawing.Point(0, 100);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Padding = new System.Windows.Forms.Padding(30, 30, 20, 20);
            this.pnlDetail.Size = new System.Drawing.Size(458, 594);
            this.pnlDetail.TabIndex = 2;
            // 
            // lblFilm
            // 
            this.lblFilm.AutoSize = true;
            this.lblFilm.Location = new System.Drawing.Point(55, 64);
            this.lblFilm.Name = "lblFilm";
            this.lblFilm.Size = new System.Drawing.Size(38, 20);
            this.lblFilm.TabIndex = 0;
            this.lblFilm.Text = "Film";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(55, 120);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 20);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(55, 176);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(43, 20);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Time";
            // 
            // lblSeats
            // 
            this.lblSeats.AutoSize = true;
            this.lblSeats.Location = new System.Drawing.Point(55, 232);
            this.lblSeats.Name = "lblSeats";
            this.lblSeats.Size = new System.Drawing.Size(51, 20);
            this.lblSeats.TabIndex = 3;
            this.lblSeats.Text = "Seats";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(55, 288);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 20);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // lblCinema
            // 
            this.lblCinema.AutoSize = true;
            this.lblCinema.Location = new System.Drawing.Point(55, 344);
            this.lblCinema.Name = "lblCinema";
            this.lblCinema.Size = new System.Drawing.Size(63, 20);
            this.lblCinema.TabIndex = 5;
            this.lblCinema.Text = "Cinema";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(55, 400);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(49, 20);
            this.lblOrder.TabIndex = 6;
            this.lblOrder.Text = "Order";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 26);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(172, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(115, 26);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(172, 172);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(115, 26);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(172, 226);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(115, 26);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(172, 280);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(115, 26);
            this.textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(172, 334);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(115, 26);
            this.textBox6.TabIndex = 12;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(172, 388);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(115, 26);
            this.textBox7.TabIndex = 13;
            // 
            // pbBarcode
            // 
            this.pbBarcode.Location = new System.Drawing.Point(59, 459);
            this.pbBarcode.Name = "pbBarcode";
            this.pbBarcode.Size = new System.Drawing.Size(337, 67);
            this.pbBarcode.TabIndex = 14;
            this.pbBarcode.TabStop = false;
            // 
            // ReviewTiket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 794);
            this.Controls.Add(this.pnlDetail);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Name = "ReviewTiket";
            this.Text = "ReviewTiket";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarcode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.PictureBox pbBarcode;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblCinema;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSeats;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblFilm;
    }
}