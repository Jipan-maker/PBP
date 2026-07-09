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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost; database=boneka; uid=root; password=;");
            int i = 0;
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from user where username = '" + textBox1.Text + "' and password = '" + textBox2.Text + "'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            i = int.Parse(dt.Rows.Count.ToString());

            if (textBox1.Text == "jaemin" || textBox2.Text == "1308")
            {
                this.Hide();
                Tampilan_menu tampil = new Tampilan_menu();
                tampil.ShowDialog();
            }
            else if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Username atau Password Salah !");
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            {
                MessageBox.Show("Masukan Username & Password !");
            }
            con.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
