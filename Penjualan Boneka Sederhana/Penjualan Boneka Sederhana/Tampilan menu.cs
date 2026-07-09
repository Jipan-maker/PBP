using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Penjualan_Boneka_Sederhana
{
    public partial class Tampilan_menu : Form
    {
        public Tampilan_menu()
        {
            InitializeComponent();
        }

        private void Tampilan_menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tabel_barang br = new Tabel_barang();
            br.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tabel_waktu wk = new Tabel_waktu();
            wk.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tabel_Transaksi tr = new Tabel_Transaksi();
            tr.ShowDialog();
        }
    }
}
