using Aspose.Pdf;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
    public partial class Registr : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\source\repos\TARpv21_Urm\Database\Database\AppData\Tooded_DB.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader reader;
        public Registr()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (muuja_rbt.Checked || omanik_rbt.Checked)
            {
                if (nimi_txt.Text != "" && perenimi_txt.Text != "" && kasutaja_txt.Text != "" && parool_txt.Text != "")
                {
                    if (kasutaja_txt.Text.Length >= 5 && parool_txt.Text.Length >= 9)
                    {
                        bool isInt = kasutaja_txt.Text.All(char.IsDigit);
                        if (isInt == false)
                        {
                            if (parool_txt.Text == parool2_txt.Text)
                            {
                                bool containsInt1 = nimi_txt.Text.Any(char.IsDigit);
                                bool containsInt2 = perenimi_txt.Text.Any(char.IsDigit);
                                if (containsInt1 == false && containsInt2 == false)
                                {
                                    cmd = new SqlCommand("SELECT * FROM Kasutajad", connect);
                                    connect.Open();
                                    reader = cmd.ExecuteReader();
                                    bool kontroll = false;
                                    while (reader.Read())
                                    {
                                        kontroll = false;
                                        if (kasutaja_txt.Text != reader["Kasutajanimi"].ToString())
                                        {
                                            kontroll = true;
                                        }
                                    }
                                    connect.Close();
                                    if (kontroll)
                                    {
                                        cmd = new SqlCommand("INSERT INTO Kasutajad (Nimi,Perekonnanimi,Kasutajanimi,Parool,Rolli) VALUES (@nimi,@perenimi,@kasutaja,@parool,@rolli)", connect);
                                        
                                        connect.Open();
                                        cmd.Parameters.AddWithValue("@nimi", nimi_txt.Text);
                                        cmd.Parameters.AddWithValue("@perenimi", perenimi_txt.Text);
                                        cmd.Parameters.AddWithValue("@kasutaja", kasutaja_txt.Text);
                                        cmd.Parameters.AddWithValue("@parool", parool_txt.Text);
                                        if (muuja_rbt.Checked == true)
                                        {
                                            cmd.Parameters.AddWithValue("@rolli", "Müüja");
                                        }
                                        else if (omanik_rbt.Checked == true)
                                        {
                                            cmd.Parameters.AddWithValue("@rolli", "Omanik");
                                        }
                                        cmd.ExecuteNonQuery();
                                        
                                        connect.Close();
                                        MessageBox.Show("Kasutaja registreeritud!");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Username already exists!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No numbers in name and surname!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Passwords are not the same!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("User name must contain letters!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Not enough length!\nUsername atleast 5 symbols\nPassword atleast 9 symbols");
                    }
                }
                else
                {
                    MessageBox.Show("Fill all fields!");
                }
            }
            else
            {
                MessageBox.Show("Choose role!");
            }
        }
    }
}
