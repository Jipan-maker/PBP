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

namespace SIPegawai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string nip;
        MySqlConnection koneksi = new MySqlConnection("server=localhost;database=c#;uid=root;pwd=;");

        private void Form1_Load(object sender, EventArgs e)
        {
            lihatData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            MySqlCommand cmd;
            cmd = koneksi.CreateCommand();
            cmd.CommandText = "insert into pegawai (nip,nama,jabatan,gaji) values (@nip,@nama,@jabatan,@gaji)";
            cmd.Parameters.AddWithValue("@nip", textBox1.Text);
            cmd.Parameters.AddWithValue("@nama", textBox2.Text);
            cmd.Parameters.AddWithValue("@jabatan", textBox3.Text);
            cmd.Parameters.AddWithValue("@gaji", textBox4.Text);
            MessageBox.Show("sukses");
            cmd.ExecuteNonQuery();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            lihatData();
            koneksi.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        public void lihatData()
        {
            MySqlCommand cmd;
            cmd = koneksi.CreateCommand();
            cmd.CommandText = "select * from pegawai";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            nip = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            MySqlCommand cmd;
            cmd = koneksi.CreateCommand();
            cmd.CommandText = "update pegawai set nip=@nip,nama=@nama,jabatan=@jabatan,gaji=@gaji WHERE nip='" + nip + "' ";
            cmd.Parameters.AddWithValue("@nip", textBox1.Text);
            cmd.Parameters.AddWithValue("@nama", textBox2.Text);
            cmd.Parameters.AddWithValue("@jabatan", textBox3.Text);
            cmd.Parameters.AddWithValue("@gaji", textBox4.Text);
            MessageBox.Show("Data sukses diupdate");
            cmd.ExecuteNonQuery();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            lihatData();
            koneksi.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            MySqlCommand cmd;
            cmd = koneksi.CreateCommand();
            cmd.CommandText = "DELETE FROM pegawai WHERE nip='" + nip + "' ";
            cmd.Parameters.AddWithValue("@nip", textBox1.Text);
            MessageBox.Show("Data telah dihapus");
            cmd.ExecuteNonQuery();
            lihatData();
            koneksi.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            cmd = koneksi.CreateCommand();
            cmd.CommandText = "select * from pegawai where nip=@nip";
            cmd.Parameters.AddWithValue("@nip", textBox1.Text);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
