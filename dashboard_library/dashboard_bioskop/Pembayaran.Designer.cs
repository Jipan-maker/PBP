namespace dashboard_bioskop
{
    partial class Pembayaran
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
            this.lblPayment = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnPayNow = new System.Windows.Forms.Button();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.tlPOpsi = new System.Windows.Forms.TableLayoutPanel();
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.rdb3 = new System.Windows.Forms.RadioButton();
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.pnlHeader.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlFill.SuspendLayout();
            this.tlPOpsi.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblPayment);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(458, 82);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Location = new System.Drawing.Point(165, 31);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(129, 20);
            this.lblPayment.TabIndex = 0;
            this.lblPayment.Text = "Payment Method\r\n";
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnPayNow);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 694);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(458, 100);
            this.pnlBottom.TabIndex = 1;
            // 
            // btnPayNow
            // 
            this.btnPayNow.Location = new System.Drawing.Point(187, 30);
            this.btnPayNow.Name = "btnPayNow";
            this.btnPayNow.Size = new System.Drawing.Size(79, 34);
            this.btnPayNow.TabIndex = 0;
            this.btnPayNow.Text = "Pay Now";
            this.btnPayNow.UseVisualStyleBackColor = true;
            this.btnPayNow.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // pnlFill
            // 
            this.pnlFill.Controls.Add(this.tlPOpsi);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(0, 82);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(458, 612);
            this.pnlFill.TabIndex = 2;
            // 
            // tlPOpsi
            // 
            this.tlPOpsi.ColumnCount = 1;
            this.tlPOpsi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPOpsi.Controls.Add(this.rdb2, 0, 0);
            this.tlPOpsi.Controls.Add(this.rdb3, 0, 2);
            this.tlPOpsi.Controls.Add(this.rdb1, 0, 1);
            this.tlPOpsi.Location = new System.Drawing.Point(136, 174);
            this.tlPOpsi.Name = "tlPOpsi";
            this.tlPOpsi.RowCount = 3;
            this.tlPOpsi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlPOpsi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlPOpsi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlPOpsi.Size = new System.Drawing.Size(275, 258);
            this.tlPOpsi.TabIndex = 0;
            // 
            // rdb2
            // 
            this.rdb2.AutoSize = true;
            this.rdb2.Location = new System.Drawing.Point(3, 3);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(134, 24);
            this.rdb2.TabIndex = 0;
            this.rdb2.TabStop = true;
            this.rdb2.Text = "Transfer Bank";
            this.rdb2.UseVisualStyleBackColor = true;
            // 
            // rdb3
            // 
            this.rdb3.AutoSize = true;
            this.rdb3.Location = new System.Drawing.Point(3, 175);
            this.rdb3.Name = "rdb3";
            this.rdb3.Size = new System.Drawing.Size(94, 24);
            this.rdb3.TabIndex = 0;
            this.rdb3.TabStop = true;
            this.rdb3.Text = "E-Wallet";
            this.rdb3.UseVisualStyleBackColor = true;
            // 
            // rdb1
            // 
            this.rdb1.AutoSize = true;
            this.rdb1.Location = new System.Drawing.Point(3, 89);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(74, 24);
            this.rdb1.TabIndex = 0;
            this.rdb1.TabStop = true;
            this.rdb1.Text = "QRIS";
            this.rdb1.UseVisualStyleBackColor = true;
            // 
            // Pembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 794);
            this.Controls.Add(this.pnlFill);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlHeader);
            this.Name = "Pembayaran";
            this.Text = "Pembayaran";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlFill.ResumeLayout(false);
            this.tlPOpsi.ResumeLayout(false);
            this.tlPOpsi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnPayNow;
        private System.Windows.Forms.Panel pnlFill;
        private System.Windows.Forms.TableLayoutPanel tlPOpsi;
        private System.Windows.Forms.RadioButton rdb2;
        private System.Windows.Forms.RadioButton rdb3;
        private System.Windows.Forms.RadioButton rdb1;
    }
}