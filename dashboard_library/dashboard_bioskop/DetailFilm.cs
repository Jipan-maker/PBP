using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace dashboard_bioskop
{
    public partial class DetailFilm : Form
    {
        // 1. String koneksi database SQL Server Anda
        private string connString = @"Data Source=localhost;Initial Catalog=db_bioskop;Integrated Security=True";

        // 2. ID Film yang sedang aktif dibuka
        private int currentMovieId = 1;

        public DetailFilm()
        {
            InitializeComponent();

            // Terapkan style otomatis dari ThemeHelper
            ThemeHelper.ApplyFormStyle(this);
            ThemeHelper.ApplyButtonStyle(btnBack);

            // Periksa jika Anda memiliki button book ticket & update di designer Anda
            if (btnBookTicket != null) ThemeHelper.ApplyButtonStyle(btnBookTicket);
            if (btnUpdateFilm != null) ThemeHelper.ApplyButtonStyle(btnUpdateFilm);

            // Terapkan style untuk TextBox Rating & RichTextBox Deskripsi
            ThemeHelper.ApplyTextBoxStyle(textBox1);
            ThemeHelper.ApplyTextBoxStyle(textBox2);
            ThemeHelper.ApplyTextBoxStyle(textBox3);
            ThemeHelper.ApplyRichTextBoxStyle(rtbSinopsis); // Styling untuk RichTextBox

            // Load data film secara otomatis saat halaman dibuka
            LoadDetailFilm();
        }

        // ==========================================
        // READ: Mengambil data film dari SQL Server
        // ==========================================
        private void LoadDetailFilm()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                // Query mengambil judul, deskripsi, dan ketiga rating
                string query = "SELECT title, description, rating_imdb, rating_rotten, rating_ign FROM movies WHERE id_movie = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", currentMovieId);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // Set nilai ke komponen sesuai visual Anda
                        lblJudul.Text = reader["title"].ToString();
                        rtbSinopsis.Text = reader["description"].ToString(); // Memasukkan teks ke RichTextBox

                        textBox1.Text = reader["rating_imdb"].ToString();
                        textBox2.Text = reader["rating_rotten"].ToString();
                        textBox3.Text = reader["rating_ign"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat detail film: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ==========================================
        // UPDATE: Menyimpan hasil edit ke SQL Server
        // ==========================================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Validasi sederhana agar data tidak kosong
            if (string.IsNullOrEmpty(lblJudul.Text) || string.IsNullOrEmpty(rtbSinopsis.Text))
            {
                MessageBox.Show("Judul dan Deskripsi film tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                // Query UPDATE untuk memperbarui deskripsi dan 3 rating sekaligus
                string query = @"UPDATE movies 
                                 SET description = @desc, 
                                     rating_imdb = @imdb, 
                                     rating_rotten = @rotten, 
                                     rating_ign = @ign 
                                 WHERE id_movie = @id";

                SqlCommand cmd = new SqlCommand(query, conn);

                // Ambil nilai dari RichTextBox dan TextBox rating Anda
                cmd.Parameters.AddWithValue("@desc", rtbSinopsis.Text); // Membaca teks dari RichTextBox
                cmd.Parameters.AddWithValue("@imdb", textBox1.Text);
                cmd.Parameters.AddWithValue("@rotten", textBox2.Text);
                cmd.Parameters.AddWithValue("@ign", textBox3.Text);
                cmd.Parameters.AddWithValue("@id", currentMovieId);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data film berhasil diperbarui (UPDATE) ke database!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memperbarui data film: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            PilihKursi formKursi = new PilihKursi();
            formKursi.Show();
            this.Hide();
        }
    }
}