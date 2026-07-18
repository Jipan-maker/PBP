using System;
using System.Windows.Forms;

namespace dashboard_bioskop
{
    public partial class ReviewTiket : Form
    {
        public ReviewTiket(string judul, string tanggal, string waktu, string kursi, string harga)
        {
            InitializeComponent();
            ThemeHelper.ApplyFormStyle(this);
            if (btnCheckOut != null) ThemeHelper.ApplyButtonStyle(btnCheckOut);
            if (pnlHeader != null) pnlHeader.BackColor = ThemeHelper.BackColorLight;

            if (textBox1 != null) textBox1.Text = judul;

            if (textBox2 != null) textBox2.Text = tanggal;

            if (textBox3 != null) textBox3.Text = waktu;

            if (textBox4 != null) textBox4.Text = kursi;

            if (textBox5 != null) textBox5.Text = "Rp " + harga;

            if (textBox6 != null) textBox6.Text = "Bioskop CGV Pusat";

            Random acak = new Random();
            if (textBox7 != null) textBox7.Text = "TIX-" + acak.Next(10000, 99999).ToString();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Pembayaran formBayar = new Pembayaran();
            formBayar.Show();
            this.Hide();
        }
    }
}