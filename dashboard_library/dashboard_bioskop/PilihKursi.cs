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
    public partial class PilihKursi : Form
    {
        // 1. Variabel untuk menyimpan "ingatan" aplikasi
        int hargaPerTiket = 35000;
        int totalBelanja = 0;
        List<string> listKursi = new List<string>(); // Ingat kursi yang dipilih
        string tanggalPilihan = "";                  // Ingat tanggal
        string waktuPilihan = "";                    // Ingat waktu

        public PilihKursi()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // 2. Kode ASLI milikmu untuk menggambar layar melengkung
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (Pen neonPen = new Pen(Color.FromArgb(255, 255, 0), 5))
            {
                int x = 20;
                int y = 10;
                // Pastikan nama panelnya sesuai dengan desainmu (misal: pnlLayarBioskop atau panel3)
                int width = pnlLayarBioskop.Width - 40;
                int height = 60;

                e.Graphics.DrawArc(neonPen, x, y, width, height, 200, 140);
            }
        }

        // 3. Kode untuk mengubah warna Kursi dan menghitung harga
        private void Kursi_Click(object sender, EventArgs e)
        {
            Button kursiYangDiklik = (Button)sender;

            if (kursiYangDiklik.BackColor != Color.LightGreen)
            {
                kursiYangDiklik.BackColor = Color.LightGreen;
                totalBelanja += hargaPerTiket;
                listKursi.Add(kursiYangDiklik.Text);
            }
            else
            {
                kursiYangDiklik.BackColor = SystemColors.ControlLight;
                totalBelanja -= hargaPerTiket;
                listKursi.Remove(kursiYangDiklik.Text);
            }

            // CATATAN: Ubah "textBox1" menjadi nama TextBox Total Price milikmu jika berbeda
            textBox1.Text = "Rp " + totalBelanja.ToString("N0");
        }

        // 4. Kode untuk mencatat Tanggal yang diklik
        private void Tanggal_Click(object sender, EventArgs e)
        {
            Button tombolTanggal = (Button)sender;
            tanggalPilihan = tombolTanggal.Text;
            MessageBox.Show("Tanggal dipilih: " + tanggalPilihan, "Info Tanggal");
        }

        // 5. Kode untuk mencatat Waktu yang diklik
        private void Waktu_Click(object sender, EventArgs e)
        {
            Button tombolWaktu = (Button)sender;
            waktuPilihan = tombolWaktu.Text;
            MessageBox.Show("Waktu dipilih: " + waktuPilihan, "Info Waktu");
        }

        // 6. Kode untuk Tombol Buy Tickets
        private void btnBuyTickets_Click(object sender, EventArgs e)
        {
            // Cek apakah user sudah melengkapi pilihan
            if (tanggalPilihan == "" || waktuPilihan == "" || listKursi.Count == 0)
            {
                MessageBox.Show("Mohon pilih Tanggal, Waktu, dan minimal 1 Kursi terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gabungkan list kursi dari [A1, A2] menjadi teks "A1, A2"
            string gabunganKursi = string.Join(", ", listKursi);

            // Buka form Review Tiket dan LEMPAR datanya
            ReviewTiket formReview = new ReviewTiket(tanggalPilihan, waktuPilihan, gabunganKursi, totalBelanja.ToString());
            formReview.Show();
            this.Hide();
        }
    }
}