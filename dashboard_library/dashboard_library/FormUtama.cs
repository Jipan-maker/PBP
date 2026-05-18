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
    // FORM UTAMA HARUS DI ATAS AGAR DESIGNER VISUAL STUDIO BISA DIBUKA
    public partial class FormUtama : Form
    {
        // Menggunakan BindingList agar tabel otomatis update saat data ditambah
        private BindingList<Film> databaseFilm = new BindingList<Film>();

        public FormUtama()
        {
            InitializeComponent();

            // Menyambungkan tabel (dgvFilm) ke penyimpan data (databaseFilm)
            dgvFilm.DataSource = databaseFilm;

            // Menyambungkan tombol tambah ke fungsinya
            btnTambah.Click += new EventHandler(btnTambah_Click);
        }

        // Fungsi ketika tombol "+ Tambah Film Baru" diklik
        private void btnTambah_Click(object sender, EventArgs e)
        {
            FormInputFilm formInput = new FormInputFilm();

            // Jika di form input user klik Simpan (dan mengirim status OK)
            if (formInput.ShowDialog() == DialogResult.OK)
            {
                // Tarik data film yang baru diketik, lalu masukkan ke tabel dashboard
                databaseFilm.Add(formInput.FilmBaru);

                // Update teks jumlah koleksi film di pojok kanan bawah
                lblTotalKoleksi.Text = $"Total Koleksi : {databaseFilm.Count} Film";
            }
        }

        // Fungsi bawaan designer yang bisa dibiarkan kosong
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }

    // =========================================================
    // CLASS FILM DIPINDAH KE BAWAH SINI (DI LUAR FORM UTAMA)
    // =========================================================
    public class Film
    {
        public string ID { get; set; }
        public string Judul { get; set; }
        public string Genre { get; set; }
        public string Tahun { get; set; }
        public string Rating { get; set; }
        public string Sutradara { get; set; }
        public string Sinopsis { get; set; }
        public Image Poster { get; set; }
    }
}