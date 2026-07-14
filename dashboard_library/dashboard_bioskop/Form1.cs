using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dashboard_bioskop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            ThemeHelper.ApplyFormStyle(this);
            ThemeHelper.ApplyButtonStyle(btnLogin);
            ThemeHelper.ApplyTextBoxStyle(txtUsername);
            ThemeHelper.ApplyTextBoxStyle(txtPassword);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "admin123")
            {
                MessageBox.Show("Login Berhasil!", "Sukses");

                // Memanggil dan membuka form Dashboard
                Dashboard formDashboard = new Dashboard();
                formDashboard.Show();

                // Menyembunyikan form Login
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password salah!", "Error");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
