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
            btnUbah.Click += new EventHandler(btnUbah_Click);   // Tambahkan baris ini
            btnHapus.Click += new EventHandler(btnHapus_Click);

            dgvFilm.SelectionChanged += new EventHandler(dgvFilm_SelectionChanged);
            txtCari.TextChanged += new EventHandler(txtCari_TextChanged);
            dgvFilm.RowTemplate.Height = 80;
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

        private void dgvFilm_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFilm.SelectedRows.Count > 0)
            {
                // Mengambil objek data Film yang sedang aktif dipilih oleh user
                Film filmTerpilih = (Film)dgvFilm.SelectedRows[0].DataBoundItem;

                if (filmTerpilih != null)
                {
                    // 1. Tampilkan sinopsis ke RichTextBox di bagian bawah
                    rtbSinopsisPreview.Text = filmTerpilih.Sinopsis;

                    // 2. Tampilkan nama sutradara ke Label di dalam panel preview
                    lblSutradaraPreview.Text = $"Sutradara : {filmTerpilih.Sutradara}";

                    // 3. Tampilkan gambar poster ke PictureBox di panel kanan (Kelihatan Full)
                    if (filmTerpilih.Poster != null)
                    {
                        pbPosterPreview.Image = filmTerpilih.Poster;
                        pbPosterPreview.SizeMode = PictureBoxSizeMode.Zoom; // Mode zoom agar gambar proporsional/tidak gepeng
                    }
                    else
                    {
                        pbPosterPreview.Image = null; // Kosongkan jika tidak ada poster
                    }
                }
            }
            else
            {
                // Reset tampilan jika tidak ada baris yang terpilih
                rtbSinopsisPreview.Text = "Detail sinopsis akan muncul disini...";
                lblSutradaraPreview.Text = "Sutradara : -";
                pbPosterPreview.Image = null;
            }
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            string kataKunci = txtCari.Text.ToLower().Trim();

            if (string.IsNullOrEmpty(kataKunci) || kataKunci == "cari judul film...")
            {
                // Jika kotak search kosong, tampilkan kembali seluruh isi database asli
                dgvFilm.DataSource = databaseFilm;
            }
            else
            {
                // Menyaring data film berdasarkan Judul yang mengandung kata kunci
                var hasilPencarian = databaseFilm.Where(f => f.Judul.ToLower().Contains(kataKunci)).ToList();

                // Set hasil pencarian ke DataGridView
                dgvFilm.DataSource = hasilPencarian;
            }

            // Tetap pelihara kerapian visual poster setelah data di-refresh oleh pencarian
            AturLayoutPosterTabel();
        }

        // Fungsi pembantu untuk memastikan kolom gambar poster di DataGridView tidak rusak
        private void AturLayoutPosterTabel()
        {
            if (dgvFilm.Columns["Poster"] != null)
            {
                DataGridViewImageColumn colGambar = (DataGridViewImageColumn)dgvFilm.Columns["Poster"];
                colGambar.ImageLayout = DataGridViewImageCellLayout.Zoom; // Menjadikan gambar di dalam cell full & rapi
                colGambar.Width = 100; // Memberikan space lebar kolom yang pas
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            // Pastikan user sudah memilih baris film yang ingin dihapus di DataGridView
            if (dgvFilm.SelectedRows.Count > 0)
            {
                // Ambil objek film dari baris yang dipilih
                Film filmTerpilih = (Film)dgvFilm.SelectedRows[0].DataBoundItem;

                // Tampilkan kotak konfirmasi biar tidak sengaja terhapus
                DialogResult konfirmasi = MessageBox.Show(
                    $"Apakah Anda yakin ingin menghapus film '{filmTerpilih.Judul}' dari koleksi?",
                    "Konfirmasi Hapus",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (konfirmasi == DialogResult.Yes)
                {
                    // Hapus data dari BindingList utama, tabel otomatis akan ter-refresh!
                    databaseFilm.Remove(filmTerpilih);

                    // Perbarui teks jumlah koleksi di pojok kanan bawah
                    lblTotalKoleksi.Text = $"Total Koleksi : {databaseFilm.Count} Film";

                    MessageBox.Show("Film berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih film yang ingin dihapus dari tabel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (dgvFilm.SelectedRows.Count > 0)
            {
                Film filmTerpilih = (Film)dgvFilm.SelectedRows[0].DataBoundItem;

                // Kita panggil FormInputFilm yang sama, tapi kali ini untuk mengedit data
                FormInputFilm formEdit = new FormInputFilm();

                // [TIPS KELOMPOK] Agar form input langsung terisi data lama film yang mau diedit:
                // Anda bisa membuat fungsi pembantu di FormInputFilm untuk menerima objek 'filmTerpilih' ini.
                // Untuk sementara, kita simulasikan membuka formnya:
                if (formEdit.ShowDialog() == DialogResult.OK)
                {
                    // Ambil indeks baris yang sedang diedit
                    int index = databaseFilm.IndexOf(filmTerpilih);

                    // Ganti data lama di indeks tersebut dengan data baru hasil ketikan user
                    databaseFilm[index] = formEdit.FilmBaru;

                    // Segarkan tampilan tabel
                    dgvFilm.Refresh();

                    MessageBox.Show("Detail film berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih film yang ingin diubah dari tabel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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