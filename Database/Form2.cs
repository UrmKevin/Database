using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Aspose.Pdf;

namespace Database
{
    public partial class Form2 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\source\repos\TARpv21_Urm\Database\Database\AppData\Tooded_DB.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter, adapter_kat;
        List<string> Tooded_list = new List<string>();
        public Form2()
        {
            InitializeComponent();
            Naita_Andmed();
            Toode_pbx.Image = System.Drawing.Image.FromFile(@"..\..\Images\about.png");
        }
        public void Naita_Andmed()
        {
            connect.Open();

            DataTable dt_toodes = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM Toodetable", connect);
            adapter.Fill(dt_toodes);
            dataGridView1.DataSource = dt_toodes;
            connect.Close();
            Naita_Kat();

            connect.Close();
        }
        public void Naita_Kat()
        {
            connect.Open();

            adapter_kat = new SqlDataAdapter("SELECT Kategooria_nimetus FROM Kategooria", connect);
            DataTable dt_kat = new DataTable();
            adapter_kat.Fill(dt_kat);
            foreach (DataRow nimetus in dt_kat.Rows)
            {
                Kat_cbx.Items.Add(nimetus["Kategooria_nimetus"]);
            }

            connect.Close();
        }
        public void Kustuta_Andmed()
        {
            Toode_txt.Text = "";
            Hind_txt.Text = "";
            Kogus_txt.Text = "";
            Kat_cbx.Items.Clear();
        }
        int Id;
        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = (int)(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            Toode_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Kogus_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Hind_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            try
            {
                Toode_pbx.Image = System.Drawing.Image.FromFile(@"..\..\Images\" + dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch (Exception)
            {
                Toode_pbx.Image = System.Drawing.Image.FromFile(@"..\..\Images\about.png");
                //MessageBox.Show("Fail puudub");
            }
            string v = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            Kat_cbx.SelectedIndex = Int32.Parse(v) - 1;
        }
        Document document;
        private void Lisa_Click(object sender, EventArgs e)
        {
            document = new Document();
            var page = document.Pages.Add();
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(". . ."));
            foreach (var toode in Tooded_list)
            {
                page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(toode));
            }

            document.Save(@"..\..\Arved\Arve_.pdf");
            document.Dispose();
        }
        private void Arve_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Siin on sinu arve");
            Process.Start(@"..\..\Arved\Arve_.pdf");
        }
    }
}
