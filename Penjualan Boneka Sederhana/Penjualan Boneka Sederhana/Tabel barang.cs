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

namespace Penjualan_Boneka_Sederhana
{
    public partial class Tabel_barang : Form
    {
        MySqlConnection koneksi = new MySqlConnection("server=localhost; database=boneka; uid=root; password=;");
        MySqlCommand perintah;

        private void bukaKoneksi() { if (koneksi.State == System.Data.ConnectionState.Closed) koneksi.Open(); }
        private void tutupKoneksi() { if (koneksi.State == System.Data.ConnectionState.Open) koneksi.Close(); }

        public void eksekusiQuery(string query)
        {
            try
            {
                bukaKoneksi();
                perintah = new MySqlCommand(query, koneksi);
                if (perintah.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query, koneksi");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    comboBox1.Text = "";
                }
            }
            catch (Exception error) { MessageBox.Show(error.Message); }
            finally { tutupKoneksi(); }
        }
        public Tabel_barang()
        {
            InitializeComponent();
        }

        private void Tabel_barang_Load(object sender, EventArgs e)
        {
            string querySelect = "select * from barang";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(querySelect, koneksi);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
           
        }
   

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO barang(idBarang,Namabarang,jenisbarang) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "')";
            eksekusiQuery(query);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string queryUpdate = "UPDATE barang set Namabarang='" +
            textBox2.Text + "', jenisbarang='" + comboBox1.Text
            + "' where idBarang=" + int.Parse(textBox1.Text);
            eksekusiQuery(queryUpdate);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string queryDelete = "DELETE FROM barang WHERE idBarang=" + int.Parse(textBox1.Text);
            eksekusiQuery(queryDelete);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlDataReader baca;
            string select = "SELECT * FROM barang WHERE idBarang=" + textBox1.Text;
            perintah = new MySqlCommand(select, koneksi);
            bukaKoneksi();
            baca = perintah.ExecuteReader();
            if (baca.Read())
            {
                textBox2.Text = baca.GetString("Namabarang");
                comboBox1.Text = baca.GetString("jenisbarang");
            }
            else
            {
                MessageBox.Show("Barang tidak ditemukan");
            }
            tutupKoneksi();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tampilan_menu m = new Tampilan_menu();
            m.ShowDialog();

        }
    }
}
