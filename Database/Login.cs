﻿using System;
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
    public partial class Login : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\source\repos\Database\Database\AppData\Tooded_DB.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader reader;
        public Login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (kasutaja_txt.Text != "" && parool_txt.Text != "")
            {
                if (kasutaja_txt.Text.Length >= 5 && parool_txt.Text.Length >= 9)
                {
                    cmd = new SqlCommand("SELECT * FROM Kasutajad", connect);
                    connect.Open();
                    reader = cmd.ExecuteReader();
                    bool kontroll = false;
                    while (reader.Read())
                    {
                        kontroll = false;
                        if (kasutaja_txt.Text == reader["Kasutajanimi"].ToString() && parool_txt.Text == reader["Parool"].ToString() && "Omanik" == reader["Rolli"].ToString())
                        {
                            kontroll = true;
                            Omanik omanik = new Omanik();
                            this.Hide();
                            omanik.Show();
                            break;
                        }
                        else if (kasutaja_txt.Text == reader["Kasutajanimi"].ToString() && parool_txt.Text == reader["Parool"].ToString() && "Müüja" == reader["Rolli"].ToString())
                        {
                            kontroll = true;
                            //Muuja muuja = new Muuja();
                            //muuja.Show();
                        }
                    }
                    connect.Close();
                    if (kontroll == false)
                    {
                        MessageBox.Show("There is no User with this data!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Fill fields!");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Registr registr = new Registr();
            registr.Show();
            
        }
    }
}
