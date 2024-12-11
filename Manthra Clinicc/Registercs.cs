using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Manthra_Clinicc
{
    public partial class Registercs : Form
    {
        public Registercs()
        {
            InitializeComponent();
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_username.Text.Trim() != "" && txt_pwdreg.Text.Trim() != "" && txt_emailreg.Text.Trim() != "" && txtmobreg.Text.Trim() != "")
                {
                    if (txt_pwdreg.Text.Trim().Length >= 8)
                    {
                        SqlConnection con = new SqlConnection("Data Source = LAPTOP-I2KO1GJH; Initial Catalog = manthraclinic; Integrated Security = True");
                        con.Open();
                        SqlCommand cmd = new SqlCommand("sp_register", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter p1 = new SqlParameter("@Username", SqlDbType.VarChar);
                        cmd.Parameters.Add(p1).Value = txt_username.Text.Trim();
                        SqlParameter p2 = new SqlParameter("@Password", SqlDbType.VarChar);
                        cmd.Parameters.Add(p2).Value = txt_pwdreg.Text.Trim();
                        SqlParameter p3 = new SqlParameter("@Email", SqlDbType.VarChar);
                        cmd.Parameters.Add(p3).Value = txt_emailreg.Text.Trim();
                        SqlParameter p4 = new SqlParameter("@Mobilenumber", SqlDbType.VarChar);
                        cmd.Parameters.Add(p4).Value = txtmobreg.Text.Trim();

                        int i = cmd.ExecuteNonQuery();

                        if (i > 0)
                        {
                            MessageBox.Show("Registered Successfully");
                        }
                        else
                        {
                            MessageBox.Show("Error");
                            con.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Must have 8 digits");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Fill all the datas");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();

            f.Show();
            this.Hide();
        }

        private void Reset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txt_username.Clear();
            txt_pwdreg.Clear();
            txt_emailreg.Clear();
            txtmobreg.Clear();
        }
    }
}
