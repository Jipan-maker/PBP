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

        // --- KODE UNTUK TOMBOL CHECK ORDER ---
        private void btnCheckOrder_Click(object sender, EventArgs e)
        {
            // Karena kita belum membuat halaman riwayat pesanan (History), 
            // kita gunakan MessageBox sebagai simulasi bahwa tiket berhasil dicetak.
            MessageBox.Show("Tiket elektronik Anda telah berhasil diterbitkan dan dikirim ke Email!\n\nSilakan tunjukkan tiket ini pada petugas di bioskop.",
                            "Cek Pesanan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // --- KODE UNTUK TOMBOL BACK TO HOME ---
        private void btnBackToHome_Click(object sender, EventArgs e)
        {
            // Memanggil dan membuka kembali halaman awal (Dashboard)
            Dashboard formDashboard = new Dashboard();
            formDashboard.Show();

            // Menyembunyikan halaman sukses ini
            this.Hide();
        }
    }
}