using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace dashboard_bioskop
{
    public partial class PilihKursi : Form
    {
        int hargaPerTiket = 35000;
        int totalBelanja = 0;
        List<string> listKursi = new List<string>();
        string tanggalPilihan = "";
        string waktuPilihan = "";
                  
        string judulFilmTerpilih = "";

        public PilihKursi(string judulDariDetail)
        {
            InitializeComponent();

            judulFilmTerpilih = judulDariDetail;

            ThemeHelper.ApplyFormStyle(this);
            if (btnA1 != null) ThemeHelper.ApplyButtonStyle(btnA1);
            if (btnA2 != null) ThemeHelper.ApplyButtonStyle(btnA2);
            if (btnA3 != null) ThemeHelper.ApplyButtonStyle(btnA3);
            if (btnA4 != null) ThemeHelper.ApplyButtonStyle(btnA4);
            if (btnA5 != null) ThemeHelper.ApplyButtonStyle(btnA5);
            if (btnA6 != null) ThemeHelper.ApplyButtonStyle(btnA6);
            if (btnB1 != null) ThemeHelper.ApplyButtonStyle(btnB1);
            if (btnB2 != null) ThemeHelper.ApplyButtonStyle(btnB2);
            if (btnB3 != null) ThemeHelper.ApplyButtonStyle(btnB3);
            if (btnB4 != null) ThemeHelper.ApplyButtonStyle(btnB4);
            if (btnB5 != null) ThemeHelper.ApplyButtonStyle(btnB5);
            if (btnB6 != null) ThemeHelper.ApplyButtonStyle(btnB6);
            if (btnC1 != null) ThemeHelper.ApplyButtonStyle(btnC1);
            if (btnC2 != null) ThemeHelper.ApplyButtonStyle(btnC2);
            if (btnC3 != null) ThemeHelper.ApplyButtonStyle(btnC3);
            if (btnC4 != null) ThemeHelper.ApplyButtonStyle(btnC4);
            if (btnC5 != null) ThemeHelper.ApplyButtonStyle(btnC5);
            if (btnC6 != null) ThemeHelper.ApplyButtonStyle(btnC6);
            if (btnD1 != null) ThemeHelper.ApplyButtonStyle(btnD1);
            if (btnD2 != null) ThemeHelper.ApplyButtonStyle(btnD2);
            if (btnD3 != null) ThemeHelper.ApplyButtonStyle(btnD3);
            if (btnD4 != null) ThemeHelper.ApplyButtonStyle(btnD4);
            if (btnD5 != null) ThemeHelper.ApplyButtonStyle(btnD5);
            if (btnD6 != null) ThemeHelper.ApplyButtonStyle(btnD6);
            if (btnBuyTickets != null) ThemeHelper.ApplyButtonStyle(btnBuyTickets);

            if (flowLayoutPanel1 != null) flowLayoutPanel1.BackColor = ThemeHelper.BackColorLight;
            if (flowLayoutPanel2 != null) flowLayoutPanel2.BackColor = ThemeHelper.BackColorLight;
        }

        private void label2_Click(object sender, EventArgs e) { }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (Pen neonPen = new Pen(Color.FromArgb(255, 255, 0), 5))
            {
                int x = 20;
                int y = 10;
                if (pnlLayarBioskop != null)
                {
                    int width = pnlLayarBioskop.Width - 40;
                    int height = 60;
                    e.Graphics.DrawArc(neonPen, x, y, width, height, 200, 140);
                }
            }
        }

        private void Kursi_Click(object sender, EventArgs e)
        {
            Button kursiYangDiklik = (Button)sender;

            if (kursiYangDiklik.BackColor != Color.LightGreen)
            {
                kursiYangDiklik.BackColor = Color.LightGreen;
                totalBelanja += hargaPerTiket;
                listKursi.Add(kursiYangDiklik.Text);
            }
            else
            {
                kursiYangDiklik.BackColor = SystemColors.ControlLight;
                totalBelanja -= hargaPerTiket;
                listKursi.Remove(kursiYangDiklik.Text);
            }

            if (textBox1 != null) textBox1.Text = "Rp " + totalBelanja.ToString("N0");
        }

        private void Tanggal_Click(object sender, EventArgs e)
        {
            Button tombolTanggal = (Button)sender;
            tanggalPilihan = tombolTanggal.Text;
            MessageBox.Show("Tanggal dipilih: " + tanggalPilihan, "Info Tanggal");
        }

        private void Waktu_Click(object sender, EventArgs e)
        {
            Button tombolWaktu = (Button)sender;
            waktuPilihan = tombolWaktu.Text;
            MessageBox.Show("Waktu dipilih: " + waktuPilihan, "Info Waktu");
        }

        private void btnBuyTickets_Click(object sender, EventArgs e)
        {
            if (tanggalPilihan == "" || waktuPilihan == "" || listKursi.Count == 0)
            {
                MessageBox.Show("Mohon pilih Tanggal, Waktu, dan minimal 1 Kursi terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string gabunganKursi = string.Join(", ", listKursi);
            ReviewTiket formReview = new ReviewTiket(judulFilmTerpilih, tanggalPilihan, waktuPilihan, gabunganKursi, totalBelanja.ToString());
            formReview.Show();
            this.Hide();
        }
    }
}