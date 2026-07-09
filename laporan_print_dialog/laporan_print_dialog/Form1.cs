using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace laporan_print_dialog
{
    public partial class Form1 : Form
    {
        public string databases = "server=localhost; database=sekolah; uid=root; pwd=''";
        public MySqlConnection koneksi;
        public MySqlCommand command;
        public MySqlDataAdapter adp; public MySqlDataReader rdr;
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        public DataTable tampil()
        {
            string sql = "select * from siswa";
            DataTable dt = new DataTable();
            try
            {
                koneksi = new MySqlConnection(databases); koneksi.Open();
                command = new MySqlCommand(sql, koneksi);
                adp = new MySqlDataAdapter(command);
                adp.Fill(dt); command.ExecuteNonQuery();
                bindingSource1.DataSource = dt;
                dataGridView1.DataSource = bindingSource1;
                bindingNavigator1.BindingSource = bindingSource1;
            }
            catch (Exception ali)
            {
                MessageBox.Show(ali.Message);
            }
            koneksi.Close();

            return dt;
        }

        public void pindahketextbox()
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["nomor induk"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["nama"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["jenkel"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["alamat"].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells["kelas"].Value.ToString();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tampil();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            pindahketextbox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1.PrinterSettings.DefaultPageSettings.Landscape = false;
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var font = new Font("Khmer UI", 12); e.Graphics.DrawString("\t\t\t Data Siswa - Siswi\n\n\n", font, Brushes.Black, 25, 10);
            e.Graphics.DrawString("NIM \t:" + textBox1.Text + "\n\n", font, Brushes.Black, 20, 30);
            e.Graphics.DrawString("NAMA \t:" + textBox2.Text + "\n\n", font, Brushes.Black, 20, 50);
            e.Graphics.DrawString("Jenis Kelamin \t:" + textBox3.Text + "\n\n", font, Brushes.Black, 20, 80);
            e.Graphics.DrawString("Alamat \t:" + textBox4.Text + "\n\n", font, Brushes.Black, 20, 110);
            e.Graphics.DrawString("Kelas \t:" + textBox5.Text + "\n\n", font, Brushes.Black, 20, 130); 
        }
    }
}
