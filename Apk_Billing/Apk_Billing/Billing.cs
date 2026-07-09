using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Apk_Billing
{
    public partial class Billing : Form
    {
        private string text = "";
        string p, q, r, h;
        int s, t, u, i;
        public new string Text
        {
            get { return this.text; }
            set { this.text = value; }
        }

        public Billing()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Billing_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true; harga.Text = text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime jamku = DateTime.Now;
            h = harga.Text;
            i = Convert.ToInt16(h);
            detik.Text = jamku.Second.ToString();
            menit.Text = jamku.Minute.ToString();
            jam.Text = jamku.Hour.ToString();
            p = detik.Text;
            q = menit.Text; r = jam.Text;
            if ((i) == (1500))
            {
                s = Convert.ToInt16(p); t = Convert.ToInt16(q); u = Convert.ToInt16(r); while (t == 30)
                {
                    s = 0;
                    DialogResult di = MessageBox.Show("paket anda sudah habis, " +
                    "Ingin Tambah Paket Lagi ???",
                    "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (di == DialogResult.Yes)
                    {
                        Form1 form = new Form1(); form.Focus(); form.Visible = true; this.Hide();
                    }
                    else
                    {
                        Process.Start("shutdown", "/s /t 0");
                    }
                }
            }
            else if ((i) == (3000))
            {
                s = Convert.ToInt16(p); t = Convert.ToInt16(q); u = Convert.ToInt16(r);
                while (u == 1)
                {
                    t = 0;
                    s = 0;
                    DialogResult di = MessageBox.Show("paket anda sudah habis, " +
                    "Ingin Tambah Paket Lagi ???",
                    "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    if (di == DialogResult.Yes)
                    {
                        Form1 form = new Form1();
                        form.Focus(); form.Visible = true; this.Hide();
                    }
                    else
                    {
                        Process.Start("shutdown", "/s /t 0");
                    }
                }
            }
            else if ((i) == (6000))
            {
                s = Convert.ToInt16(p); t = Convert.ToInt16(q); u = Convert.ToInt16(r);
                while (u == 2)
                {
                    t = 0;
                    s = 0;
                    DialogResult di = MessageBox.Show("paket anda sudah habis, " +
                    "Ingin Tambah Paket Lagi ???",
                    "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    if (di == DialogResult.Yes)
                    {
                        Form1 form = new Form1(); form.Focus(); form.Visible = true; this.Hide();
                    }
                    else
                    {
                        Process.Start("shutdown", "/s /t 0");
                    }
                }
            }
            else if ((i) == (8000))
            {
                s = Convert.ToInt16(p); t = Convert.ToInt16(q); u = Convert.ToInt16(r);
                while (u == 3)
                {
                    t = 0;
                    s = 0;
                    DialogResult di = MessageBox.Show("paket anda sudah habis, " +
                    "Ingin Tambah Paket Lagi ???",
                    "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (di == DialogResult.No)
                    {
                        Form1 form = new Form1(); form.Focus(); form.Visible = true; this.Hide();
                    }
                    else
                    {
                        Process.Start("shutdown", "/s /t 0");
                    }
                }
            }
            else if ((i) == (11000))
            {
                s = Convert.ToInt16(p); t = Convert.ToInt16(q); u = Convert.ToInt16(r);
                while (u == 4)
                {
                    t = 0;
                    s = 0;
                    DialogResult di = MessageBox.Show("paket anda sudah habis, " +
                    "Ingin Tambah Paket Lagi ???",
                    "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (di == DialogResult.Yes)
                    {
                        Form1 form = new Form1(); form.Focus(); form.Visible = true; this.Hide();
                    }
                    else
                    {
                        Process.Start("shutdown", "/s /t 0");
                    }
                }
            }
            else if ((i) == (13000))
            {
                s = Convert.ToInt16(p); t = Convert.ToInt16(q); u = Convert.ToInt16(r);
                while (u == 5)
                {
                    t = 0;
                    s = 0;
                    DialogResult di = MessageBox.Show("paket anda sudah habis, " +
                    "Ingin Tambah Paket Lagi ???",
                    "Important", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    if (di == DialogResult.Yes)
                    {
                        Form1 form = new Form1(); form.Focus(); form.Visible = true; this.Hide();
                    }
                    else
                    {
                        Process.Start("shutdown", "/s /t 0");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult di = MessageBox.Show("Yakinmaukeluar???", "Important",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1);

            if (di == DialogResult.No)
            {
                Form1 form = new Form1(); form.Focus(); form.Visible = true; this.Hide();
            }
            else
            {
                Process.Start("shutdown", "/s /t 0");
            }
        }
    }
}
