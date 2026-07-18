using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace dashboard_bioskop
{
    public partial class DetailFilm : Form
    {
        private string connString = "server=localhost;database=db_bioskop;uid=root;pwd=;";
        private int currentMovieId;
        private string lokasiPoster = "";

        public DetailFilm(int idDariDashboard)
        {
            InitializeComponent();
            currentMovieId = idDariDashboard;

            ThemeHelper.ApplyFormStyle(this);
            if (btnBack != null) ThemeHelper.ApplyButtonStyle(btnBack);
            if (btnBookTicket != null) ThemeHelper.ApplyButtonStyle(btnBookTicket);
            if (btnUpdateFilm != null) ThemeHelper.ApplyButtonStyle(btnUpdateFilm);

            if (textBox1 != null) ThemeHelper.ApplyTextBoxStyle(textBox1);
            if (textBox2 != null) ThemeHelper.ApplyTextBoxStyle(textBox2);
            if (textBox3 != null) ThemeHelper.ApplyTextBoxStyle(textBox3);
            if (txtJudul != null) ThemeHelper.ApplyTextBoxStyle(txtJudul);
            if (txtKategori != null) ThemeHelper.ApplyTextBoxStyle(txtKategori);
            if (rtbSinopsis != null) ThemeHelper.ApplyRichTextBoxStyle(rtbSinopsis);

            LoadDetailFilm();
        }

        private void LoadDetailFilm()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = "SELECT judul, deskripsi, rating_imdb, rating_rotten, rating_ign, file_poster, kategori FROM tb_film WHERE id_film = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", currentMovieId);

                try
                {
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        if (txtJudul != null) txtJudul.Text = reader["judul"].ToString();
                        if (rtbSinopsis != null) rtbSinopsis.Text = reader["deskripsi"].ToString();
                        if (textBox1 != null) textBox1.Text = reader["rating_imdb"].ToString();
                        if (textBox2 != null) textBox2.Text = reader["rating_rotten"].ToString();
                        if (textBox3 != null) textBox3.Text = reader["rating_ign"].ToString();
                        if (txtKategori != null) txtKategori.Text = reader["kategori"].ToString();

                        lokasiPoster = reader["file_poster"].ToString();

                        if (!string.IsNullOrEmpty(lokasiPoster) && File.Exists(lokasiPoster))
                        {
                            pbPosterUtama.Image = Image.FromFile(lokasiPoster);
                            pbPosterUtama.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                        else
                        {
                            pbPosterUtama.Image = null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat detail film: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pbPosterUtama_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Pilih Gambar Poster";
            ofd.Filter = "Image Files(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lokasiPoster = ofd.FileName;
                pbPosterUtama.Image = Image.FromFile(lokasiPoster);
                pbPosterUtama.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnUpdateFilm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtJudul.Text) || string.IsNullOrEmpty(rtbSinopsis.Text))
            {
                MessageBox.Show("Judul dan Deskripsi tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = @"UPDATE tb_film 
                                 SET judul = @judul, deskripsi = @desc, rating_imdb = @imdb, rating_rotten = @rotten, rating_ign = @ign, file_poster = @poster, kategori = @kategori
                                 WHERE id_film = @id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@judul", txtJudul.Text);
                cmd.Parameters.AddWithValue("@desc", rtbSinopsis.Text);
                cmd.Parameters.AddWithValue("@imdb", textBox1.Text);
                cmd.Parameters.AddWithValue("@rotten", textBox2.Text);
                cmd.Parameters.AddWithValue("@ign", textBox3.Text);
                cmd.Parameters.AddWithValue("@poster", lokasiPoster);
                cmd.Parameters.AddWithValue("@kategori", txtKategori.Text);
                cmd.Parameters.AddWithValue("@id", currentMovieId);

                try
                {
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0) MessageBox.Show("Data, Kategori & Poster Berhasil Diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex) { MessageBox.Show("Gagal Update: " + ex.Message); }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard formDashboard = new Dashboard();
            formDashboard.Show();
            this.Hide();
        }

        private void btnBookTicket_Click(object sender, EventArgs e)
        {
            string judulFilm = txtJudul != null ? txtJudul.Text : "Judul Tidak Diketahui";
            PilihKursi formKursi = new PilihKursi(judulFilm);
            formKursi.Show();
            this.Hide();
        }

        private void DetailFilm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}