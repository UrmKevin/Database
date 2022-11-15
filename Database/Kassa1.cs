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
    public partial class Kassa1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\source\repos\TARpv21_Urm\Database\Database\AppData\Tooded_DB.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter, adapter_kat;
        List<string> Tooded_list = new List<string>();
        string tooded = "";
        double total = 0;
        public Kassa1()
        {
            InitializeComponent();
            Naita_Andmed();
            Toode_pbx.Image = System.Drawing.Image.FromFile(@"..\..\Images\about.png");
        }
        public void Naita_Andmed()
        {
            connect.Open();

            DataTable dt_toodes = new DataTable();
            adapter = new SqlDataAdapter("SELECT Id,Toodenimetus,Kogus,Hind FROM Toodetable", connect);
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
            Kogus_txt.Value = 1;
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
        }
        Document document;
        private void Osta_btn_Click(object sender, EventArgs e)
        {
            document = new Document();
            var page = document.Pages.Add();
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("ARVE\n\nKoguhind: " + total.ToString() + "€\n"));
            foreach (var toode in Tooded_list)
            {
                page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(toode));
            }
            tooded = "";
            total = 0;
            KõikHind_lbl.Text = "";
            Korv_lbx.Items.Clear();
            values.Clear();
            korv.Clear();
            document.Save(@"..\..\Arved\Arve_.pdf");
            document.Dispose();
        }
        List<string> korv = new List<string>();
        List<string> values = new List<string>();
        private void Lisa_btn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentCell.OwningRow;
            string value = row.Cells["Kogus"].Value.ToString();
            int val = Int32.Parse(value);
            int valinud = Int32.Parse(Kogus_txt.Text);
            if (valinud <= val)
            {
                cmd = new SqlCommand("UPDATE Toodetable SET Kogus=@kogus WHERE Id=@id", connect);

                connect.Open();
                cmd.Parameters.AddWithValue("@kogus", val - Int32.Parse(Kogus_txt.Text));
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.ExecuteNonQuery();
                connect.Close();

                values.Add(Toode_txt.Text.ToString());
                values.Add(Kogus_txt.Text.ToString());
                values.Add(Hind_txt.Text.ToString());
                values.Add(Kat_cbx.Text.ToString());
                for (int i = 0; i < 4; i++)
                {
                    string string1 = values[i];
                    korv.Add(string1);
                }
                if (Toode_txt.Text != "")
                {
                    int kogus = Int32.Parse(korv[1]);
                    double hind = Convert.ToDouble(korv[2]);
                    double summ = hind * kogus;
                    total += summ;
                    tooded = $"{korv[0]}: {korv[1]} - {summ}€";
                    KõikHind_lbl.Text = total.ToString();
                    Korv_lbx.Items.Add(tooded);
                    Tooded_list.Add(tooded);
                    values.Clear();
                    korv.Clear();
                }
                else
                {
                    MessageBox.Show("valida toode");
                }
            }
            else
            {
                MessageBox.Show("Meil pole nii palju toodet");
            }
            
        }

        private void Arve_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Siin on sinu arve");
            Process.Start(@"..\..\Arved\Arve_.pdf");
        }
    }
}
