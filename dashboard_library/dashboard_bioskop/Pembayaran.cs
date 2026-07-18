using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dashboard_bioskop
{
    public partial class Pembayaran : Form
    {
        public Pembayaran()
        {
            InitializeComponent();
            ThemeHelper.ApplyFormStyle(this);
            ThemeHelper.ApplyButtonStyle(btnPayNow);
            ThemeHelper.ApplyRadioButtonStyle(rdb1);
            ThemeHelper.ApplyRadioButtonStyle(rdb2);
            ThemeHelper.ApplyRadioButtonStyle(rdb3);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            string metodePilihan = "";
            if (rdb1.Checked)
            {
                metodePilihan = "QRIS";
            }
            else if (rdb2.Checked)
            {
                metodePilihan = "Transfer Bank";
            }
            else if (rdb3.Checked)
            {
                metodePilihan = "E-Wallet";
            }
            else
            {
                MessageBox.Show("Silakan pilih metode pembayaran terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Pembayaran menggunakan " + metodePilihan + " berhasil! Tiket Anda sedang dicetak.", "Pembayaran Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Dashboard formDashboard = new Dashboard();
            formDashboard.Show();
            this.Hide();
        }
    }
}