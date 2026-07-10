using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dashboard_bioskop
{
    public partial class PilihKursi : Form
    {
        public PilihKursi()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            // Mengaktifkan fitur Anti-Aliasing agar garis lengkung mulus dan tidak patah-patah
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Membuat kuas/pen warna kuning neon (khusus layar) dengan ketebalan 5 unit
            using (Pen neonPen = new Pen(Color.FromArgb(255, 255, 0), 5))
            {
                // Menentukan koordinat kotak imajiner sebagai dasar kelengkungan lingkaran
                // Posisi di tengah atas panel
                int x = 20;
                int y = 10;
                int width = panel3.Width - 40;
                int height = 60; // Mengatur kelengkungan parabola layar

                // Menggambar busur lengkung (Arc) dari sudut 200 derajat sejauh 140 derajat
                e.Graphics.DrawArc(neonPen, x, y, width, height, 200, 140);
            }
        }
    }
}
