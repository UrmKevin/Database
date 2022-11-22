using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class Admin : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\source\repos\Database\Database\AppData\Tooded_DB.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter, adapter_kat;
        public Admin()
        {
            InitializeComponent();
            Naita_Andmed();
        }
        public void Naita_Andmed()
        {
            connect.Open();

            DataTable dt_toodes = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM Kliendid", connect);
            adapter.Fill(dt_toodes);
            dataGridView1.DataSource = dt_toodes;

            connect.Close();
        }
        public void Kustuta_Andmed()
        {
            nimi_txt.Text = "";
            pere_txt.Text = "";
            tele_txt.Text = "";
            mail_txt.Text = "";
            bronze_rbn.Checked = false;
            silver_rbn.Checked = false;
            gold_rbn.Checked = false;
        }
        private void Lisa_btn_Click(object sender, EventArgs e)
        {
            if (nimi_txt.Text.Trim() != string.Empty && pere_txt.Text.Trim() != string.Empty && tele_txt.Text.All(char.IsDigit) == true && mail_txt.Text.Trim() != string.Empty)
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO Kliendid (Nimi,Perenimi,Mail,Telefoninumber,Kliendikaart) VALUES (@nimi,@pere,@mail,@tele,@kaart)", connect);
                    connect.Open();
                    cmd.Parameters.AddWithValue("@nimi", nimi_txt.Text);
                    cmd.Parameters.AddWithValue("@pere", pere_txt.Text);
                    cmd.Parameters.AddWithValue("@mail", mail_txt.Text);
                    cmd.Parameters.AddWithValue("@tele", tele_txt.Text);
                    if (bronze_rbn.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@kaart", "Bronze");
                    }
                    else if (silver_rbn.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@kaart", "Silver");
                    }
                    else if (gold_rbn.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@kaart", "Gold");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@kaart", "Ei ole");
                    }
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
                MessageBox.Show("Viga");
            }
        }

        private void Kustuta_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            string sql = "DELETE FROM Kliendid WHERE Id = @rowID";

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

        private void Uuenda_btn_Click_1(object sender, EventArgs e)
        {
            if (nimi_txt.Text != "" && pere_txt.Text != "" && tele_txt.Text != "")
            {
                try
                {
                    cmd = new SqlCommand("UPDATE Kliendid SET Nimi=@nimi,Perenimi=@pere,Mail=@mail,telefoninumber=@tele,Kliendikaart=@kaart WHERE Id=@id", connect);
                    connect.Open();
                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.Parameters.AddWithValue("@nimi", nimi_txt.Text);
                    cmd.Parameters.AddWithValue("@pere", pere_txt.Text);
                    cmd.Parameters.AddWithValue("@mail", mail_txt.Text);
                    cmd.Parameters.AddWithValue("@tele", tele_txt.Text);
                    if (bronze_rbn.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@kaart", "Bronze");
                    }
                    else if (silver_rbn.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@kaart", "Silver");
                    }
                    else if (gold_rbn.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@kaart", "Gold");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@kaart", "ei ole");
                    }
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    Naita_Andmed();
                    Kustuta_Andmed();
                }
                catch (Exception)
                {
                    MessageBox.Show("Andmebaasiga viga!");
                }
            }
            else
            {
                MessageBox.Show("Viga");
            }
        }
        int Id;
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = (int)(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            nimi_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            pere_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            mail_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            tele_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
