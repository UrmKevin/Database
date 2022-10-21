﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class Form1 : Form
    {
        //SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AppData\Tooded_DB.mdf;Integrated Security=True");
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\source\repos\TARpv21_Urm\Database\Database\AppData\Tooded_DB.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter, adapter_kat;
        public Form1()
        {
            InitializeComponent();
            Naita_Andmed();
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
        public void Naita_Andmed()
        {
            connect.Open();

            DataTable dt_toodes = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM Toodetable", connect);
            adapter.Fill(dt_toodes);
            dataGridView1.DataSource = dt_toodes;
            Toode_pbx.Image = Image.FromFile("../../Images/about.png");
            connect.Close();
            Naita_Kat();

            connect.Close();
        }
        public void Kustuta_Andmed()
        {
            Toode_txt.Text = "";
            Hind_txt.Text = "";
            Kogus_txt.Text = "";
            Kat_cbx.Items.Clear();
        }

        private void Lisa_kat_lbl_Click(object sender, EventArgs e)
        {
            Lisa_kat_lbl.ForeColor = Color.Black;
            Lisa_kat_lbl.BackColor = Color.White;

            connect.Open();

            cmd = new SqlCommand("INSERT INTO Kategooria (Kategooria_nimetus) VALUES (@kat)",connect);
            cmd.Parameters.AddWithValue("@kat",Kat_cbx.Text);
            cmd.ExecuteNonQuery();

            connect.Close();
            Kustuta_Andmed();
            Naita_Andmed();
        }
        private void Lisa_Andmed(object sender, EventArgs e)
        {
            if (Toode_txt.Text.Trim() != string.Empty && Kogus_txt.Text.Trim() != string.Empty && Hind_txt.Text.Trim() != string.Empty && Kat_cbx.SelectedItem != null)
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO Toodetable (Toodenimetus,Kogus,Hind,Pilt,Kategooria_Id) VALUES (@toode,@kogus,@hind,@pilt,@kat)", connect);
                    connect.Open();
                    cmd.Parameters.AddWithValue("@toode", Toode_txt.Text);
                    cmd.Parameters.AddWithValue("@kogus", Kogus_txt.Text);
                    cmd.Parameters.AddWithValue("@hind", Hind_txt.Text);//format andmebaasis ja vormis võrtsed(sarnased)
                    cmd.Parameters.AddWithValue("@pilt", Toode_txt.Text + ".jpg");//format?
                    cmd.Parameters.AddWithValue("@kat", Kat_cbx.SelectedIndex + 1);//Id andmebaasist võtta
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    Kustuta_Andmed();
                    Naita_Andmed();
                }
                catch (Exception)
                {

                    MessageBox.Show("Andmebaasiga viga!");
                }
            }
            else
            {
                MessageBox.Show("Fill fields");
            }
        }
        private void Kustuta_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            string sql = "DELETE FROM Toodetable WHERE Id = @rowID";

            using (SqlCommand deleteRecord = new SqlCommand(sql, connect))
            {
                connect.Open();

                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                int rowID = Convert.ToInt32(dataGridView1[0, selectedIndex].Value);

                deleteRecord.Parameters.Add("@rowID", SqlDbType.Int).Value = rowID;
                deleteRecord.ExecuteNonQuery();

                dataGridView1.Rows.RemoveAt(selectedIndex);

                connect.Close();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            connect.Open();
            if (Kat_cbx.Text == "") return;

            string sql = "DELETE FROM Kategooria WHERE Kategooria_nimetus = @kat";
            using (SqlCommand deleteRecord = new SqlCommand(sql, connect))
            {
                deleteRecord.Parameters.AddWithValue("@kat", Kat_cbx.Text);
                deleteRecord.ExecuteNonQuery();
            }
            Kat_cbx.SelectedIndex = -1;
            connect.Close();
            Kustuta_Andmed();
            Naita_Kat();
        }
        private void Lisa_kat_lbl_MouseEnter(object sender, EventArgs e)
        {
            Lisa_kat_lbl.ForeColor = Color.White;
            Lisa_kat_lbl.BackColor = Color.Gray;
        }

        private void KogusPic_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Toode_pbx.Load(ofd.FileName);
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.png;*.jpg";
            sfd.Title = "Salvesta pilt";
            sfd.FileName = ".png";
            ImageFormat format = ImageFormat.Png;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string ext = Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                }
                Toode_pbx.Image.Save(sfd.FileName, format);
            }
        }

        private void Lisa_kat_lbl_MouseLeave(object sender, EventArgs e)
        {
            Lisa_kat_lbl.ForeColor = Color.Black;
            Lisa_kat_lbl.BackColor = Color.White;
        }
    }
}
