namespace Apk_Billing
{
    partial class Billing
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.detik = new System.Windows.Forms.Label();
            this.menit = new System.Windows.Forms.Label();
            this.jam = new System.Windows.Forms.Label();
            this.harga = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Waktu Anda :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Harga    :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "S";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "M";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "H";
            // 
            // detik
            // 
            this.detik.AutoSize = true;
            this.detik.Location = new System.Drawing.Point(139, 87);
            this.detik.Name = "detik";
            this.detik.Size = new System.Drawing.Size(18, 20);
            this.detik.TabIndex = 5;
            this.detik.Text = "0";
            // 
            // menit
            // 
            this.menit.AutoSize = true;
            this.menit.Location = new System.Drawing.Point(233, 87);
            this.menit.Name = "menit";
            this.menit.Size = new System.Drawing.Size(18, 20);
            this.menit.TabIndex = 6;
            this.menit.Text = "0";
            // 
            // jam
            // 
            this.jam.AutoSize = true;
            this.jam.Location = new System.Drawing.Point(322, 87);
            this.jam.Name = "jam";
            this.jam.Size = new System.Drawing.Size(18, 20);
            this.jam.TabIndex = 7;
            this.jam.Text = "0";
            // 
            // harga
            // 
            this.harga.AutoSize = true;
            this.harga.Location = new System.Drawing.Point(139, 130);
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(18, 20);
            this.harga.TabIndex = 8;
            this.harga.Text = "0";
            this.harga.Click += new System.EventHandler(this.label9_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "Selesai";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(442, 241);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.harga);
            this.Controls.Add(this.jam);
            this.Controls.Add(this.menit);
            this.Controls.Add(this.detik);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Billing";
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.Billing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label detik;
        private System.Windows.Forms.Label menit;
        private System.Windows.Forms.Label jam;
        private System.Windows.Forms.Label harga;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}