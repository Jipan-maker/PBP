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
    public partial class FormUtama : Form
    {
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
        private List<Film> databaseFilm = new List<Film>();

        private TextBox txtCariJudul;
        private ComboBox cmbFilterGenre;
        private Button btnTambahFilm;
        private DataGridView dgvDaftarFilm;
        private PictureBox picPreviewPoster;
        private Label lblSutradaraData;
        private Button btnUbahDetail;
        private Button btnHapusFilm;
        private Label lblKoleksiTotal;
       
        public FormUtama()
        {
            InitializeComponent();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
