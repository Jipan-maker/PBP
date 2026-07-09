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

namespace Data_Mahasiswa
{
    public partial class Form1 : Form
    {
        string database = "server = localhost; database=sekolah; uid=root; pwd=''";
        public MySqlConnection koneksi;
        public MySqlCommand cmd;
        public MySqlDataAdapter adp;
        private MySqlCommand command;
        public Form1()
        {
            InitializeComponent();
        }
        public void konek()
        {
            koneksi = new MySqlConnection(database);
            koneksi.Open();
        }
        public void disconek()
        {
            koneksi = new MySqlConnection(database);
            koneksi.Close();
        }
        public DataTable baca()
        {
            string sql = "select * from siswa";
            DataTable dt = new DataTable();
            try
            {
                konek();
                cmd = new MySqlCommand(sql, koneksi);
                adp = new MySqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ali)
            {
                MessageBox.Show(ali.Message);
            }
            disconek();
            return dt;
        }
        public void query()
        {
            try
            {
                koneksi = new MySqlConnection(database);
                koneksi.Open();
                string update = "UPDATE siswa SET nama='" + textBox2.Text + "',jenkel ='" + textBox3.Text + "',alamat='" + textBox4.Text + "',kelas='" + textBox5.Text + "'WHERE nomor_induk='" + textBox1.Text + "'";
                command = new MySqlCommand(update, koneksi);
                command.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Update Sukses", "informasi", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void delete()
        {
            try
            {
                koneksi = new MySqlConnection(database);
                koneksi.Open();
                string del = "delete from siswa WHERE nomor_induk='" + textBox1.Text + "'";
                command = new MySqlCommand(del, koneksi);
                command.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Delete Sukses", "informasi", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Query(string query)
        {
            koneksi = new MySqlConnection(database);
            try
            {
                koneksi.Open();
                cmd = new MySqlCommand(query, koneksi);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ali)
            {
                MessageBox.Show(ali.Message);
            }
            finally
            {
                koneksi.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            baca();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            query();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Query("insert into siswa values('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text + "','" + this.textBox4.Text + "','" + this.textBox5.Text + "')");
            MessageBox.Show("Insert data berhasil");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
