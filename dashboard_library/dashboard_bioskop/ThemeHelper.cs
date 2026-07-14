using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace dashboard_bioskop
{
    public static class ThemeHelper
    {
        // Warna Utama Aplikasi
        public static readonly Color BackColorDark = Color.FromArgb(18, 18, 18);
        public static readonly Color CardColorDark = Color.FromArgb(30, 30, 30);
        public static readonly Color NeonYellow = Color.FromArgb(255, 255, 0);

        // Gaya Dasar Form (Dark Mode)
        public static void ApplyFormStyle(Form form, int width = 480, int height = 850)
        {
            form.Size = new Size(width, height);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MaximizeBox = false;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.BackColor = BackColorDark;
        }

        // Gaya Tombol Utama (Kuning Neon)
        public static void ApplyButtonStyle(Button btn)
        {
            if (btn == null) return;

            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = NeonYellow;
            btn.ForeColor = Color.Black;
            btn.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;

            btn.Paint += Component_RoundCorners_Paint;
        }

        // Gaya Kotak Input / Output (TextBox)
        public static void ApplyTextBoxStyle(TextBox txt)
        {
            if (txt == null) return;

            txt.BackColor = CardColorDark;
            txt.ForeColor = Color.White;
            txt.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            txt.BorderStyle = BorderStyle.FixedSingle;
        }

        // Logika Menggambar Sudut Tumpul (Rounded)
        private static void Component_RoundCorners_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            int radius = 20;
            GraphicsPath path = new GraphicsPath();
            Control control = (Control)sender;

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);

            control.Region = new Region(path);
        }

        // Logika Menggambar Layar Bioskop Melengkung (Bebas Merah)
        public static void DrawCinemaScreen(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Mengambil ukuran asli dari komponen yang memanggil secara otomatis
            Control komponenLayar = (Control)sender;

            using (Pen neonPen = new Pen(NeonYellow, 5))
            {
                int x = 20;
                int y = 10;
                int width = komponenLayar.Width - 40; // Presisi otomatis mengikuti lebar panel3
                int height = 60;

                e.Graphics.DrawArc(neonPen, x, y, width, height, 200, 140);
            }
        }
    }
}