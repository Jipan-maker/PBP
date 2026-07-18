using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace dashboard_bioskop
{
    public partial class Dashboard : Form
    {
        private string connString = "server=localhost;database=db_bioskop;uid=root;pwd=;";

        public Dashboard()
        {
            InitializeComponent();

            // ==========================================
            // DESAIN UI
            // ==========================================
            ThemeHelper.ApplyFormStyle(this);
            if (btnAction != null) ThemeHelper.ApplyButtonStyle(btnAction);
            if (btnBookmark != null) ThemeHelper.ApplyButtonStyle(btnBookmark);
            if (btnDrama != null) ThemeHelper.ApplyButtonStyle(btnDrama);
            if (btnFantasy != null) ThemeHelper.ApplyButtonStyle(btnFantasy);
            if (btnHome != null) ThemeHelper.ApplyButtonStyle(btnHome);
            if (btnProfile != null) ThemeHelper.ApplyButtonStyle(btnProfile);
            if (btnRoman != null) ThemeHelper.ApplyButtonStyle(btnRoman);
            if (btnSearch != null) ThemeHelper.ApplyButtonStyle(btnSearch);
            if (btnThriller != null) ThemeHelper.ApplyButtonStyle(btnThriller);
            if (btnTicket != null) ThemeHelper.ApplyButtonStyle(btnTicket);

            if (flpKategori != null) flpKategori.BackColor = ThemeHelper.BackColorLight;
            if (label3 != null) { label3.Font = new Font("Segoe UI", 16, FontStyle.Bold); label3.ForeColor = Color.Black; }
            if (label2 != null) { label2.Font = new Font("Segoe UI", 16, FontStyle.Bold); label2.ForeColor = Color.Black; }
            
            LoadPosters();
        }

        // ==========================================
        // CETAK POSTER
        // ==========================================
        private void LoadPosters()
        {
            if (flpNowincinemas != null) flpNowincinemas.Controls.Clear();
            if (flpPopularMovie != null) flpPopularMovie.Controls.Clear();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = "SELECT id_film, judul, file_poster, kategori FROM tb_film";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                try
                {
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int idFilm = Convert.ToInt32(reader["id_film"]);
                        string lokasiPoster = reader["file_poster"].ToString();
                        string kategoriFilm = reader["kategori"].ToString();

                        PictureBox picPoster = new PictureBox();
                        picPoster.Width = 85;
                        picPoster.Height = 125;
                        picPoster.SizeMode = PictureBoxSizeMode.StretchImage;
                        picPoster.Margin = new Padding(5);
                        picPoster.BackColor = Color.LightGray;
                        picPoster.Cursor = Cursors.Hand;

                        picPoster.Tag = idFilm;

                        if (contextMenuStrip1 != null)
                        {
                            picPoster.ContextMenuStrip = contextMenuStrip1;
                        }

                        if (!string.IsNullOrEmpty(lokasiPoster) && File.Exists(lokasiPoster))
                        {
                            picPoster.Image = Image.FromFile(lokasiPoster);
                        }

                        picPoster.Click += Poster_Click;

                        if (kategoriFilm.ToLower() == "popular" && flpPopularMovie != null)
                        {
                            flpPopularMovie.Controls.Add(picPoster);
                        }
                        else if (flpNowincinemas != null)
                        {
                            flpNowincinemas.Controls.Add(picPoster);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat poster: " + ex.Message);
                }
            }
        }

        // ==========================================
        // DETAIL FILM
        // ==========================================
        private void Poster_Click(object sender, EventArgs e)
        {
            PictureBox poster = (PictureBox)sender;
            int idTerpilih = Convert.ToInt32(poster.Tag);
            DetailFilm formDetail = new DetailFilm(idTerpilih);
            formDetail.Show();
            this.Hide();
        }

        // ==========================================
        // TAMBAH FILM
        // ==========================================
        private void btnBookmark_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                string query = @"INSERT INTO tb_film (judul, deskripsi, rating_imdb, rating_rotten, rating_ign, file_poster, kategori) 
                                 VALUES ('Judul Baru', '', '0', '0', '0', '', 'Now')";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    int idBaru = Convert.ToInt32(cmd.LastInsertedId);

                    DetailFilm formDetail = new DetailFilm(idBaru);
                    formDetail.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menambahkan film baru: " + ex.Message);
                }
            }
        }

        // ==========================================
        // HAPUS FILM DARI DATABASE 
        // ==========================================
        private void hapusFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContextMenuStrip menu = null;

            if (sender is ToolStripMenuItem)
            {
                ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
                menu = (ContextMenuStrip)menuItem.Owner;
            }
            else if (sender is ContextMenuStrip)
            {
                menu = (ContextMenuStrip)sender;
            }

            if (menu != null)
            {

                PictureBox posterYangDihapus = menu.SourceControl as PictureBox;

                if (posterYangDihapus != null && posterYangDihapus.Tag != null)
                {
                    int idTerpilih = Convert.ToInt32(posterYangDihapus.Tag);

                    DialogResult dialog = MessageBox.Show("Yakin ingin menghapus film ini secara permanen?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialog == DialogResult.Yes)
                    {
                        using (MySqlConnection conn = new MySqlConnection(connString))
                        {
                            string query = "DELETE FROM tb_film WHERE id_film = @id";
                            MySqlCommand cmd = new MySqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@id", idTerpilih);

                            try
                            {
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Film berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                LoadPosters();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Gagal menghapus film: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e) { }
        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e) { }
        private void Dashboard_Load(object sender, EventArgs e) { }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e) { }
        private void flpKategori_Paint(object sender, PaintEventArgs e) { }
    }
}