using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apk_Billing
{
    public partial class Form1 : Form
    {
        public Billing f2;
        string a, b;
        private MessageBoxButtons r;

        public Form1()
        {
            InitializeComponent();
        }

        public string Fasilitas { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (r1.Checked)
            {
                a = r1.Text;
                b = minuman.Text;
                MessageBox.Show("anda teleh memilih paket \r" + a + "\rdenganFasilitas \r" + b + "");
                Billing f2 = new Billing(); f2.Text = a;
                f2.Show();

                this.Hide();
            }
            else if (r2.Checked)
            {
                a = r2.Text;
                b = minuman.Text;
                MessageBox.Show("anda telah memilih paket \r" + a + "\r dengan " +
                "Fasilitas \r" + b);
                Billing f2 = new Billing();
                f2.Text = a;
                f2.Show();
                this.Hide();
            }
            else if (r3.Checked)
            {
                a = r3.Text;
                b = minuman.Text;
                MessageBox.Show("anda telah memilih paket \r" + a + "\r dengan " +
                "Fasilitas \r" + b);
                Billing f2 = new Billing();
                f2.Text = a;
                f2.Show();
                this.Hide();
            }
            else if (r4.Checked)
            {
                a = r4.Text;
                b = minuman.Text;
                MessageBox.Show("anda telah memilih paket \r" + a + "\r dengan " +
                "Fasilitas \r" + b);
                Billing f2 = new Billing();
                f2.Text = a;
                f2.Show();
                this.Hide();
            }
            else if (r5.Checked)
            {
                a = r5.Text;
                b = minuman.Text;
                MessageBox.Show("anda telah memilih paket \r" + a + "\r dengan " +
                "Fasilitas \r" + b);
                Billing f2 = new Billing();
                f2.Text = a;
                f2.Show();
                this.Hide();
            }
            else if (r6.Checked)
            {
                a = r6.Text;
                b = minuman.Text;
                MessageBox.Show("anda telah memilih paket \r" + a + "\r dengan " +
                "Fasilitas \r" + b);
                Billing f2 = new Billing();
                f2.Text = a;
                f2.Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
