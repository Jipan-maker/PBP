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
    public partial class ReviewTiket : Form
    {
        // Menangkap 4 data dari form PilihKursi
        public ReviewTiket(string tanggal, string waktu, string kursi, string harga)
        {
            InitializeComponent();

            // --- MENGISI TEXTBOX SESUAI URUTAN GAMBARMU ---

            // 1. textBox1 untuk Film 
            // (Kita isi manual dulu karena belum dibawa dari awal Dashboard)
            textBox1.Text = "Upin Ipin";

            // 2. textBox2 untuk Date (Tanggal)
            textBox2.Text = tanggal;

            // 3. textBox3 untuk Time (Waktu)
            textBox3.Text = waktu;

            // 4. textBox4 untuk Seats (Kursi)
            textBox4.Text = kursi;

            // 5. textBox5 untuk Price (Harga)
            // Tambahkan tulisan Rp agar rapi
            textBox5.Text = "Rp " + harga;

            // 6. textBox6 untuk Cinema (Bioskop)
            textBox6.Text = "Bioskop CGV Pusat";

            // 7. textBox7 untuk Order (Nomor Pesanan)
            // Kita buatkan nomor pesanan acak biar seperti struk asli!
            Random acak = new Random();
            textBox7.Text = "TIX-" + acak.Next(10000, 99999).ToString();
        }

        // --- KODE UNTUK TOMBOL CHECK OUT ---
        // (Pastikan kamu sudah double-click tombol Check Out di layar desain)
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            // Lanjut ke form Pembayaran
            Pembayaran formBayar = new Pembayaran();
            formBayar.Show();
            this.Hide();
        }
    }
}