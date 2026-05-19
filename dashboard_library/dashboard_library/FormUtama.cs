using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace dashboard_library
{
    public partial class FormUtama : Form
    {
        private BindingList<Film> databaseFilm = new BindingList<Film>();
        private string namaFileDatabase = "DataKoleksiFilm.txt";

        public FormUtama()
        {
            InitializeComponent();

            // Setup DataGridView
            dgvFilm.DataSource = databaseFilm;
            dgvFilm.RowTemplate.Height = 80;

            // Sambungkan event klik dan sensor perubahan teks
            btnTambah.Click += new EventHandler(btnTambah_Click);
            btnUbah.Click += new EventHandler(btnUbah_Click);
            btnHapus.Click += new EventHandler(btnHapus_Click);
            dgvFilm.SelectionChanged += new EventHandler(dgvFilm_SelectionChanged);
            txtCari.TextChanged += new EventHandler(txtCari_TextChanged);

            // Isi ComboBox Filter
            cbGenreFilter.Items.Add("Semua Genre");
            cbGenreFilter.Items.Add("Action");
            cbGenreFilter.Items.Add("Drama");
            cbGenreFilter.Items.Add("Romance");
            cbGenreFilter.Items.Add("Sci-fi");
            cbGenreFilter.Items.Add("Horror");
            cbGenreFilter.Items.Add("Comedy");
            cbGenreFilter.SelectedIndex = 0;
            cbGenreFilter.SelectedIndexChanged += new EventHandler(CbGenreFilter_SelectedIndexChanged);

            // ====================================================
            // MEMANGGIL FUNGSI MUAT DATA SAAT APLIKASI BARU DIBUKA
            // ====================================================
            MuatDataDariFile();

            // ====================================================
            // FIX ERROR: Perintah merapikan gambar dipindah ke saat Load
            // ====================================================
            this.Load += new EventHandler(FormUtama_Load);
        }

        // Fungsi Load: Berjalan otomatis saat aplikasi sudah berwujud di layar
        private void FormUtama_Load(object sender, EventArgs e)
        {
            AturLayoutPosterTabel();
        }

        // =======================================================
        // FITUR: MENYIMPAN DATA KE FILE TXT
        // =======================================================
        private void SimpanDataKeFile()
        {
            List<string> barisData = new List<string>();
            foreach (Film f in databaseFilm)
            {
                string teksPoster = "";
                if (f.Poster != null)
                {
                    teksPoster = UbahGambarKeTeks(f.Poster);
                }

                // Gabungkan semua data dipisah dengan tanda "|||"
                string baris = $"{f.ID}|||{f.Judul}|||{f.Genre}|||{f.Tahun}|||{f.Rating}|||{f.Sutradara}|||{f.Sinopsis}|||{teksPoster}";
                barisData.Add(baris);
            }
            File.WriteAllLines(namaFileDatabase, barisData);
        }

        // =======================================================
        // FITUR: MEMBACA DATA DARI FILE TXT
        // =======================================================
        private void MuatDataDariFile()
        {
            if (File.Exists(namaFileDatabase))
            {
                string[] barisData = File.ReadAllLines(namaFileDatabase);
                foreach (string baris in barisData)
                {
                    string[] kolom = baris.Split(new string[] { "|||" }, StringSplitOptions.None);

                    if (kolom.Length == 8)
                    {
                        Film f = new Film();
                        f.ID = kolom[0];
                        f.Judul = kolom[1];
                        f.Genre = kolom[2];
                        f.Tahun = kolom[3];
                        f.Rating = kolom[4];
                        f.Sutradara = kolom[5];
                        f.Sinopsis = kolom[6];

                        if (!string.IsNullOrEmpty(kolom[7]))
                        {
                            f.Poster = UbahTeksKeGambar(kolom[7]);
                        }

                        databaseFilm.Add(f);
                    }
                }
                lblTotalKoleksi.Text = $"Total Koleksi : {databaseFilm.Count} Film";
            }
        }

        // Fungsi Pembantu: Gambar -> Teks
        private string UbahGambarKeTeks(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return Convert.ToBase64String(ms.ToArray());
            }
        }

        // Fungsi Pembantu: Teks -> Gambar
        private Image UbahTeksKeGambar(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms);
            }
        }

        // =======================================================
        // FUNGSI UTAMA (CRUD & PENCARIAN)
        // =======================================================
        private void btnTambah_Click(object sender, EventArgs e)
        {
            FormInputFilm formInput = new FormInputFilm();
            if (formInput.ShowDialog() == DialogResult.OK)
            {
                databaseFilm.Add(formInput.FilmBaru);
                lblTotalKoleksi.Text = $"Total Koleksi : {databaseFilm.Count} Film";
                SimpanDataKeFile();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (dgvFilm.SelectedRows.Count > 0)
            {
                Film filmTerpilih = (Film)dgvFilm.SelectedRows[0].DataBoundItem;
                FormInputFilm formEdit = new FormInputFilm(filmTerpilih);

                if (formEdit.ShowDialog() == DialogResult.OK)
                {
                    int index = databaseFilm.IndexOf(filmTerpilih);
                    databaseFilm[index] = formEdit.FilmBaru;
                    dgvFilm.Refresh();
                    SimpanDataKeFile();
                    MessageBox.Show("Detail film berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Pilih film yang ingin diubah terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvFilm.SelectedRows.Count > 0)
            {
                Film filmTerpilih = (Film)dgvFilm.SelectedRows[0].DataBoundItem;
                DialogResult konfirmasi = MessageBox.Show($"Hapus film '{filmTerpilih.Judul}'?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (konfirmasi == DialogResult.Yes)
                {
                    databaseFilm.Remove(filmTerpilih);
                    lblTotalKoleksi.Text = $"Total Koleksi : {databaseFilm.Count} Film";
                    SimpanDataKeFile();
                    MessageBox.Show("Film berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Pilih film yang ingin dihapus terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvFilm_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFilm.SelectedRows.Count > 0)
            {
                Film filmTerpilih = (Film)dgvFilm.SelectedRows[0].DataBoundItem;
                if (filmTerpilih != null)
                {
                    rtbSinopsisPreview.Text = filmTerpilih.Sinopsis;
                    lblSutradaraPreview.Text = $"Sutradara : {filmTerpilih.Sutradara}";
                    if (filmTerpilih.Poster != null)
                    {
                        pbPosterPreview.Image = filmTerpilih.Poster;
                        // Pastikan di Designer SizeMode-nya sudah Zoom
                        pbPosterPreview.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    else pbPosterPreview.Image = null;
                }
            }
            else
            {
                rtbSinopsisPreview.Text = "Detail sinopsis akan muncul disini...";
                lblSutradaraPreview.Text = "Sutradara : -";
                pbPosterPreview.Image = null;
            }
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            string kataKunci = txtCari.Text.ToLower().Trim();
            if (string.IsNullOrEmpty(kataKunci) || kataKunci == "cari judul film...")
                dgvFilm.DataSource = databaseFilm;
            else
            {
                var hasilPencarian = databaseFilm.Where(f => f.Judul.ToLower().Contains(kataKunci)).ToList();
                dgvFilm.DataSource = hasilPencarian;
            }
            AturLayoutPosterTabel();
        }

        private void CbGenreFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string genrePilihan = cbGenreFilter.Text;
            if (genrePilihan == "Semua Genre")
                dgvFilm.DataSource = databaseFilm;
            else
            {
                var dataTersaring = new BindingList<Film>(databaseFilm.Where(f => f.Genre == genrePilihan).ToList());
                dgvFilm.DataSource = dataTersaring;
            }
            AturLayoutPosterTabel();
        }

        // =======================================================
        // FUNGSI ANTI-ERROR UNTUK MERAPIKAN GAMBAR POSTER
        // =======================================================
        private void AturLayoutPosterTabel()
        {
            try
            {
                // Cek apakah kolomnya ada dan siap
                if (dgvFilm.Columns["Poster"] != null)
                {
                    DataGridViewImageColumn colGambar = dgvFilm.Columns["Poster"] as DataGridViewImageColumn;
                    if (colGambar != null)
                    {
                        colGambar.ImageLayout = DataGridViewImageCellLayout.Zoom;
                        colGambar.Width = 100;
                    }
                }
            }
            catch (Exception)
            {
                // Abaikan jika tabel masih loading agar tidak crash
            }
        }

        // =======================================================
        // EVENT KOSONG BAWAAN DESIGNER (JANGAN DIHAPUS)
        // =======================================================
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void pnlHeader_Paint(object sender, PaintEventArgs e) { }
        private void pbPosterPreview_Click(object sender, EventArgs e) { }
    }

    // =========================================================
    // CLASS FILM
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