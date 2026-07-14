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
        }

        // --- KODE UNTUK TOMBOL PAY ---
        // PENTING: Pastikan kamu sudah men-double-click tombol Pay di layar desain
        // Jika blok kodenya bernama button1_Click, ganti nama di bawah ini menjadi button1_Click
        private void btnPay_Click(object sender, EventArgs e)
        {
            // Mengecek apakah ada minimal satu pilihan metode pembayaran yang dicentang
            // (Pastikan nama RadioButton sesuai dengan di desainmu, misal: radioButton1)
            if (rdb1.Checked || rdb2.Checked || rdb3.Checked || rdb4.Checked)
            {
                // Menampilkan dialog seolah-olah sistem sedang memproses
                MessageBox.Show("Pembayaran sedang diproses...", "Mohon Tunggu", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Lanjut buka form Pembayaran Sukses
                PembayaranSukses formSukses = new PembayaranSukses();
                formSukses.Show();
                this.Hide();
            }
            else
            {
                // Mencegah user lanjut jika belum memilih metode pembayaran
                MessageBox.Show("Mohon pilih salah satu metode pembayaran terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}