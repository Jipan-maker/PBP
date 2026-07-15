using System;
using System.Drawing;
using System.Windows.Forms;

namespace dashboard_bioskop
{
    public static class ThemeHelper
    {
        // Palet Warna Light Mode yang Terang dan Bersih
        public static readonly Color BackColorLight = Color.FromArgb(245, 245, 247);  // Latar belakang form terang (Off-White)
        public static readonly Color CardColorLight = Color.FromArgb(255, 255, 255);  // Putih bersih untuk kontainer/panel
        public static readonly Color AccentColor = Color.FromArgb(0, 122, 255);       // Biru Modern untuk tombol & fokus
        public static readonly Color TextDark = Color.FromArgb(29, 29, 31);           // Abu-abu sangat gelap untuk teks utama (bukan hitam pekat)
        public static readonly Color TextSecondary = Color.FromArgb(134, 134, 139);   // Abu-abu sedang untuk teks keterangan/sub-judul

        /// <summary>
        /// Mengatur gaya dasar Form agar menjadi Light Mode yang cerah
        /// </summary>
        public static void ApplyFormStyle(Form form)
        {
            form.StartPosition = FormStartPosition.CenterScreen;
            form.BackColor = BackColorLight;
            form.ForeColor = TextDark; // Mengubah warna default teks form menjadi gelap
        }

        /// <summary>
        /// Mengatur gaya tombol agar teksnya terlihat jelas (Gaya Transparan-Biru)
        /// </summary>
        public static void ApplyButtonStyle(Button btn)
        {
            if (btn == null) return;

            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = AccentColor; // Garis tepi biru
            btn.BackColor = CardColorLight;               // Latar belakang putih bersih
            btn.ForeColor = AccentColor;                  // Teks biru

            // 1. Amankan tinggi tombol (Jika tingginya di bawah 35, kita paksa jadi 35 agar tidak terpotong)
            if (btn.Height < 35)
            {
                btn.Height = 35;
            }

            // 2. Gunakan ukuran font yang sedikit lebih fleksibel (9pt)
            btn.Font = new Font("Segoe UI", 9f, FontStyle.Bold);

            // 3. Pastikan teks berada tepat di tengah-tengah tombol secara vertikal & horizontal
            btn.TextAlign = ContentAlignment.MiddleCenter;

            // 4. Buang semua padding dalam tombol yang bisa memotong teks
            btn.Padding = new Padding(0);

            btn.Cursor = Cursors.Hand;
        }

        /// <summary>
        /// Mengatur gaya kotak input TextBox agar rapi di tema terang
        /// </summary>
        public static void ApplyTextBoxStyle(TextBox txt)
        {
            if (txt == null) return;

            txt.BackColor = CardColorLight;
            txt.ForeColor = TextDark;
            txt.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            txt.BorderStyle = BorderStyle.FixedSingle;
        }

        /// <summary>
        /// Menggambar layar bioskop melengkung dengan warna biru cerah
        /// </summary>
        public static void DrawCinemaScreen(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Control komponenLayar = (Control)sender;

            using (Pen bluePen = new Pen(AccentColor, 4))
            {
                int x = 30;
                int y = 15;
                int width = komponenLayar.Width - 60;
                int height = 50;

                e.Graphics.DrawArc(bluePen, x, y, width, height, 200, 140);
            }
        }

        /// <summary>
        /// Mengatur gaya kotak input RichTextBox agar rapi di tema terang
        /// </summary>
        public static void ApplyRichTextBoxStyle(RichTextBox rtb)
        {
            if (rtb == null) return;

            rtb.BackColor = CardColorLight;
            rtb.ForeColor = TextDark;
            rtb.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            rtb.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}