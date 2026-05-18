using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dashboard_library
{
    public partial class FormInputFilm : Form
    {
        // Ini adalah "kurir" untuk membawa data kembali ke FormUtama
        public Film FilmBaru { get; set; }

        public FormInputFilm()
        {
            InitializeComponent();

            // Menyambungkan tombol Pilih Gambar secara manual lewat kode
            btnBrowse.Click += new EventHandler(btnBrowse_Click);
        }

        // Fungsi yang berjalan ketika tombol Simpan Data diklik
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Membuat tempat kosong untuk film baru
                FilmBaru = new Film();

                // Membuat ID unik acak sepanjang 5 karakter
                FilmBaru.ID = Guid.NewGuid().ToString().Substring(0, 5);

                // Mengambil isi inputan dari komponen UI sesuai nama di file Designer
                FilmBaru.Judul = txtJudul.Text;
                FilmBaru.Genre = cbGenreInput.Text;
                FilmBaru.Tahun = nudTahun.Value.ToString();
                FilmBaru.Rating = nudRating.Value.ToString();
                FilmBaru.Sutradara = txtSutradara.Text;
                FilmBaru.Sinopsis = rtbSinopsisInput.Text;

                // Menarik gambar dari kotak preview pbPosterInput untuk disimpan ke objek Film
                FilmBaru.Poster = pbPosterInput.Image;

                // Memberi tahu FormUtama bahwa data sukses diisi, lalu tutup jendela ini
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menyimpan data: " + ex.Message);
            }
        }

        // Fungsi ketika tombol "Pilih Gambar / Poster" diklik
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // Membuka jendela penjelajah file Windows
            OpenFileDialog dialogBukaFile = new OpenFileDialog();

            // Membatasi format agar hanya file gambar yang bisa dipilih
            dialogBukaFile.Filter = "File Gambar|*.jpg;*.jpeg;*.png;*.bmp";

            // Jika pengguna sudah memilih file gambar dan mengeklik OK
            if (dialogBukaFile.ShowDialog() == DialogResult.OK)
            {
                // Tampilkan file gambar tersebut ke kotak PictureBox di form input
                pbPosterInput.Image = Image.FromFile(dialogBukaFile.FileName);
            }
        }

        // Fungsi bawaan designer yang bisa dibiarkan kosong
        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}