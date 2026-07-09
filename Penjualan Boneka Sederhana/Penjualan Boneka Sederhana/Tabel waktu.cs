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
    public partial class Tabel_waktu : Form
    {
        MySqlConnection koneksi = new MySqlConnection("server=localhost; database=boneka; uid=root; password=;");
        MySqlCommand perintah;
        public Tabel_waktu()
        {
            InitializeComponent();
        }

        private void Tabel_waktu_Load(object sender, EventArgs e)
        {
            string querySelect = "select * from waktu order by idWaktu";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(querySelect, koneksi);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            // TODO: This line of code loads data into the 'dataSet1.waktu' table. You can move, or remove it, as needed.
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlDataReader baca;
            string select = "SELECT * FROM waktu WHERE idWaktu" + textBox1.Text;
            perintah = new MySqlCommand(select, koneksi);
            bukaKoneksi();
            baca = perintah.ExecuteReader();
            if (baca.Read())
            {
                textBox2.Text = baca.GetString("garansi");

            }
            else
            {
                MessageBox.Show("Waktu tidak ditemukan");
            }
            tutupKoneksi();

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
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
                    textBox2.Text = "";


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

        private void button2_Click(object sender, EventArgs e)
        {
            string queryInsert = "INSERT INTO waktu(idWaktu,garansi) VALUES('" +
            textBox1.Text + "','" + textBox2.Text + "')";
            eksekusiQuery(queryInsert);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string queryUpdate = "UPDATE waktu set garansi='" +
            textBox2.Text + "' where idWaktu=" + int.Parse(textBox1.Text);
            eksekusiQuery(queryUpdate);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string queryDelete = "DELETE FROM waktu WHERE idWaktu=" + int.Parse(textBox1.Text);
            eksekusiQuery(queryDelete);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tampilan_menu m = new Tampilan_menu();
            m.ShowDialog();
        }
    }
}
