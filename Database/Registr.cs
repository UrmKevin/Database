using Aspose.Pdf;
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
        SqlDataAdapter adapter, adapter_kat;
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
                    if (kasutaja_txt.Text.Length >= 4 && parool_txt.Text.Length >= 9)
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
                                    //
                                    if (true/*if kasutajanimi already exists*/)
                                    {
                                        cmd = new SqlCommand("INSERT INTO Kasutajad (Nimi,Perekonnanimi,Kasutajanimi,Parool) VALUES (@nimi,@perenimi,@kasutaja,@parool)", connect);
                                        connect.Open();
                                        cmd.Parameters.AddWithValue("@nimi", nimi_txt.Text);
                                        cmd.Parameters.AddWithValue("@perenimi", perenimi_txt.Text);
                                        cmd.Parameters.AddWithValue("@kasutaja", kasutaja_txt.Text);
                                        cmd.Parameters.AddWithValue("@parool", parool_txt.Text);
                                        cmd.ExecuteNonQuery();
                                        connect.Close();
                                        MessageBox.Show("Õige!");
                                    }
                                    else
                                    {
                                        MessageBox.Show("already exists");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("digits");
                                }
                            }
                            else
                            {
                                MessageBox.Show("parool");
                            }
                        }
                        else
                        {
                            MessageBox.Show("all is digit");
                        }
                    }
                    else
                    {
                        MessageBox.Show("length");
                    }
                }
                else
                {
                    MessageBox.Show("not all fields");
                }
            }
            else
            {
                MessageBox.Show("choose role!");
            }
        }
    }
}
//// 1. declare command object with parameter
//SqlCommand cmd = new SqlCommand("SELECT COUNT([Guarantee]) FROM [tablename] 

//    WHERE[Guarantee] = @Guarantee", conn);

//   // 2. define parameters used in command object
//SqlParameter param = new SqlParameter();
//param.ParameterName = "@Guarantee";
//param.Value = User;

//// 3. add new parameter to command object
//cmd.Parameters.Add(param);

////Execute your code
