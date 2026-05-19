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
        public Film FilmBaru { get; set; }
        private bool isModeEdit = false; // Penanda apakah ini mode edit atau bukan

        // Pintu Masuk 1: Untuk TAMBAH FILM BARU (Bawaan)
        public FormInputFilm()
        {
            InitializeComponent();
            btnBrowse.Click += new EventHandler(btnBrowse_Click);
        }

        // Pintu Masuk 2: Untuk UBAH FILM (Kita tambahkan baru)
        // Menerima data film lama dari FormUtama
        public FormInputFilm(Film filmYangMauDiubah)
        {
            InitializeComponent();
            btnBrowse.Click += new EventHandler(btnBrowse_Click);

            isModeEdit = true;
            FilmBaru = filmYangMauDiubah; // Pegang referensi data aslinya

            // Isi kotak form dengan data lama agar user tidak mengetik dari awal
            txtJudul.Text = filmYangMauDiubah.Judul;
            cbGenreInput.Text = filmYangMauDiubah.Genre;
            nudTahun.Value = Convert.ToDecimal(filmYangMauDiubah.Tahun);
            nudRating.Value = Convert.ToDecimal(filmYangMauDiubah.Rating);
            txtSutradara.Text = filmYangMauDiubah.Sutradara;
            rtbSinopsisInput.Text = filmYangMauDiubah.Sinopsis;
            pbPosterInput.Image = filmYangMauDiubah.Poster;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // JIKA BUKAN MODE EDIT, baru bikin ID dan wadah baru
                if (isModeEdit == false)
                {
                    FilmBaru = new Film();
                    FilmBaru.ID = Guid.NewGuid().ToString().Substring(0, 5);
                }

                // Masukkan teks yang ada di form (baik itu baru atau hasil ubahan)
                FilmBaru.Judul = txtJudul.Text;
                FilmBaru.Genre = cbGenreInput.Text;
                FilmBaru.Tahun = nudTahun.Value.ToString();
                FilmBaru.Rating = nudRating.Value.ToString();
                FilmBaru.Sutradara = txtSutradara.Text;
                FilmBaru.Sinopsis = rtbSinopsisInput.Text;
                FilmBaru.Poster = pbPosterInput.Image;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogBukaFile = new OpenFileDialog();
            dialogBukaFile.Filter = "File Gambar|*.jpg;*.jpeg;*.png;*.bmp";
            if (dialogBukaFile.ShowDialog() == DialogResult.OK)
            {
                pbPosterInput.Image = Image.FromFile(dialogBukaFile.FileName);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}