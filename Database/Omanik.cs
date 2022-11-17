using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class Omanik : Form
    {
        public Omanik()
        {
            InitializeComponent();
            admin_pbx.ImageLocation = @"..\..\Images\Admin.png";
            ladu_pbx.ImageLocation = @"..\..\Images\Ladu.png";
            kassa_pbx.ImageLocation = @"..\..\Images\Kassa.png";
            logout_pbx.ImageLocation = @"..\..\Images\Logout.png";
            RoundImage(admin_pbx);
            RoundImage(ladu_pbx);
            RoundImage(kassa_pbx);
        }
        private void RoundImage(PictureBox pbx)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pbx.Width - 3, pbx.Height - 3);
            Region rg = new Region(gp);
            pbx.Region = rg;
        }

        private void kassa_pbx_Click(object sender, EventArgs e)
        {
            Kassa kassa = new Kassa();
            kassa.Show();
        }

        private void ladu_pbx_Click(object sender, EventArgs e)
        {
            Warehouse warehouse = new Warehouse();
            warehouse.Show();
        }

        private void admin_pbx_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
        }

        private void logout_pbx_Click(object sender, EventArgs e)
        {
            Login myNewForm = new Login();

            myNewForm.Visible = true;

            this.Hide();
        }
    }
}
