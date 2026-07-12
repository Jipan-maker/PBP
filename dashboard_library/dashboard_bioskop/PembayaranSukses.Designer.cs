namespace dashboard_bioskop
{
    partial class PembayaranSukses
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
            this.pnlFill = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCheckOrder = new System.Windows.Forms.Button();
            this.btnBackToHome = new System.Windows.Forms.Button();
            this.pbemoji = new System.Windows.Forms.PictureBox();
            this.pnlFill.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbemoji)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFill
            // 
            this.pnlFill.Controls.Add(this.flowLayoutPanel1);
            this.pnlFill.Controls.Add(this.label2);
            this.pnlFill.Controls.Add(this.label1);
            this.pnlFill.Controls.Add(this.pbemoji);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(0, 0);
            this.pnlFill.Margin = new System.Windows.Forms.Padding(30);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(458, 794);
            this.pnlFill.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Payment Successful";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 52);
            this.label2.TabIndex = 2;
            this.label2.Text = "Congratulations,\r\nYour payment has been successful.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCheckOrder);
            this.flowLayoutPanel1.Controls.Add(this.btnBackToHome);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 694);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(458, 100);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // btnCheckOrder
            // 
            this.btnCheckOrder.Location = new System.Drawing.Point(3, 3);
            this.btnCheckOrder.Name = "btnCheckOrder";
            this.btnCheckOrder.Size = new System.Drawing.Size(147, 42);
            this.btnCheckOrder.TabIndex = 0;
            this.btnCheckOrder.Text = "Check Order";
            this.btnCheckOrder.UseVisualStyleBackColor = true;
            // 
            // btnBackToHome
            // 
            this.btnBackToHome.Location = new System.Drawing.Point(3, 51);
            this.btnBackToHome.Name = "btnBackToHome";
            this.btnBackToHome.Size = new System.Drawing.Size(147, 46);
            this.btnBackToHome.TabIndex = 1;
            this.btnBackToHome.Text = "Back To Home";
            this.btnBackToHome.UseVisualStyleBackColor = true;
            // 
            // pbemoji
            // 
            this.pbemoji.Location = new System.Drawing.Point(152, 151);
            this.pbemoji.Name = "pbemoji";
            this.pbemoji.Size = new System.Drawing.Size(160, 96);
            this.pbemoji.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbemoji.TabIndex = 0;
            this.pbemoji.TabStop = false;
            // 
            // PembayaranSukses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 794);
            this.Controls.Add(this.pnlFill);
            this.Name = "PembayaranSukses";
            this.Text = "PembayaranSukses";
            this.pnlFill.ResumeLayout(false);
            this.pnlFill.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbemoji)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFill;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCheckOrder;
        private System.Windows.Forms.Button btnBackToHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbemoji;
    }
}