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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

            // PANGGIL THEME HELPER UNTUK STYLE OTOMATIS BERSIH TANPA MERAH
            ThemeHelper.ApplyFormStyle(this);

            // Mewarnai FlowLayoutPanel tempat list poster film agar menyatu dengan background gelap
            if (flpKategori != null)
            {
                flpKategori.BackColor = ThemeHelper.BackColorDark;
            }

            // Mengatur style teks judul (label3) menjadi putih dan modern
            if (label3 != null)
            {
                label3.Font = new Font("Segoe UI", 16, FontStyle.Bold);
                label3.ForeColor = Color.White;
            }

            // Loop otomatis untuk mengatur semua PictureBox poster film bawaanmu
            PictureBox[] posters = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8 };
            foreach (PictureBox pic in posters)
            {
                if (pic != null)
                {
                    pic.SizeMode = PictureBoxSizeMode.StretchImage; // Gambar otomatis pas pas kotak
                    pic.BackColor = ThemeHelper.CardColorDark;     // Background abu gelap jika gambar belum di-load
                    pic.Cursor = Cursors.Hand;                     // Mengubah kursor jadi tangan saat diarahkan ke poster
                }
            }
        }

        // Fungsi pembantu terpusat untuk membuka detail film agar kodinganmu lebih ringkas
        private void BukaDetailFilm()
        {
            DetailFilm formDetail = new DetailFilm();
            formDetail.Show();

            // Menyembunyikan form Dashboard
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        // Event click bawaan kodinganmu yang sekarang memanggil fungsi BukaDetailFilm() secara rapi
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BukaDetailFilm();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            BukaDetailFilm();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            BukaDetailFilm();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            BukaDetailFilm();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            BukaDetailFilm();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            BukaDetailFilm();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            BukaDetailFilm();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            BukaDetailFilm();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}