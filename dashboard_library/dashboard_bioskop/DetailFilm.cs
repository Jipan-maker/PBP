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
    public partial class DetailFilm : Form
    {
        public DetailFilm()
        {
            InitializeComponent();
            ThemeHelper.ApplyFormStyle(this);
            ThemeHelper.ApplyButtonStyle(btnBack);
            ThemeHelper.ApplyButtonStyle(btnBookTicket);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard formDashboard = new Dashboard();
            formDashboard.Show();
            this.Hide();
        }

        private void btnBookTicket_Click(object sender, EventArgs e)
        {
            PilihKursi formKursi = new PilihKursi();
            formKursi.Show();
            this.Hide();
        }
    }
}
