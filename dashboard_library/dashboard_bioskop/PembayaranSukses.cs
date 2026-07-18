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
    public partial class PembayaranSukses : Form
    {
        public PembayaranSukses()
        {
            InitializeComponent();
            ThemeHelper.ApplyFormStyle(this);
            ThemeHelper.ApplyButtonStyle(btnBackToHome);
            ThemeHelper.ApplyButtonStyle(btnCheckOrder);
        }

        private void btnCheckOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tiket elektronik Anda telah berhasil diterbitkan dan dikirim ke Email!\n\nSilakan tunjukkan tiket ini pada petugas di bioskop.",
                            "Cek Pesanan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBackToHome_Click(object sender, EventArgs e)
        {
            Dashboard formDashboard = new Dashboard();
            formDashboard.Show();

            this.Hide();
        }
    }
}