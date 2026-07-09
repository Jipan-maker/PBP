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
    public partial class Tabel_Transaksi : Form
    {
        MySqlConnection koneksi = new MySqlConnection("server=localhost; database=boneka; uid=root; password=;");
        private object perintah;

        public Tabel_Transaksi()
        {
            InitializeComponent();
        }

        private void Tabel_Transaksi_Load(object sender, EventArgs e)
        {
            string querySelect = "select * from transaksi";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(querySelect, koneksi);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void bukaKoneksi()
        {
            if (koneksi.State == ConnectionState.Closed)
            {
                koneksi.Open();
            }
        }
        public void tutupKoneksi()
        {
            if (koneksi.State == ConnectionState.Open)
            {
                koneksi.Close();
            }
        }

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
                    comboBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                tutupKoneksi();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MySqlDataReader baca;
            string select = "SELECT * FROM transaksi WHERE idtransaksi=" + textBox1.Text;
            perintah = new MySqlCommand(select, koneksi);
            bukaKoneksi();
            baca = perintah.ExecuteReader();
            if (baca.Read())
            {
                comboBox1.Text = baca.GetString("Namapenjual");
                textBox2.Text = baca.GetString("harga");
                textBox3.Text = baca.GetString("idBarang");
                textBox4.Text = baca.GetString("idWaktu");
                textBox5.Text = baca.GetString("jumlah");
            }
            else
            {
                MessageBox.Show("Transaksi tidak ditemukan");
            }
            tutupKoneksi();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string queryInsert = "INSERT INTO transaksi(idtransaksi,Namapenjual,idBarang,idWaktu,jumlah,harga) VALUES('" +
            textBox1.Text + "','" +
            comboBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "' ,'" + textBox5.Text + "')";
            eksekusiQuery(queryInsert);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string queryUpdate = "UPDATE transaksi set Namapenjual='" +
            comboBox1.Text + "', harga='" + textBox2.Text
            + "' , idWaktu ='" + textBox3.Text + "',jumlah='" + textBox4.Text + "',harga='" + textBox5.Text +
            "' where idtransaksi='" + int.Parse(textBox1.Text);
            eksekusiQuery(queryUpdate);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string queryDelete = "DELETE FROM transaksi WHERE idtransaksi=" + int.Parse(textBox1.Text);
            eksekusiQuery(queryDelete);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tampilan_menu m = new Tampilan_menu();
            m.ShowDialog();
        }
    }
}

