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

namespace Manthra_Clinicc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registercs rs = new Registercs();
            rs.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you want to exit?","Confirmation Message",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check  == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_username.Text.Trim() == "" || txt_pwd.Text.Trim() == "")
                {
                    MessageBox.Show("Fill all the details");
                }
                else if (txt_username.Text.Trim() == "admin" || txt_pwd.Text.Trim() == "12345")
                {
                    MessageBox.Show("Welcome Admin");
                    Dashboardcs d = new Dashboardcs();
                    d.Show();
                    this.Hide();
                }
                else
                {
                    SqlConnection con = new SqlConnection("Data Source = LAPTOP-I2KO1GJH; Initial Catalog = manthraclinic; Integrated Security = True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_login", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p1 = new SqlParameter("@Username", SqlDbType.VarChar);
                    cmd.Parameters.Add(p1).Value = txt_username.Text.Trim();
                    SqlParameter p2 = new SqlParameter("@Password", SqlDbType.VarChar);
                    cmd.Parameters.Add(p2).Value = txt_pwd.Text.Trim();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    int a = Convert.ToInt32(ds.Tables[0].Rows.Count);
                    if (a > 0)
                    {
                        MessageBox.Show($"Welcome {txt_username.Text}");
                        Appointment ap = new Appointment();
                        ap.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("invalid User");
                    }
                    con.Close();
                }
                
                
                
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Reset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txt_username.Clear();
            txt_pwd.Clear();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_pwd.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgot_Password f = new Forgot_Password();
            f.Show();
            this.Hide();
        }
    }
}
