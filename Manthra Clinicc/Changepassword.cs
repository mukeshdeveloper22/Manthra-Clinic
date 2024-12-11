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
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;

namespace Manthra_Clinicc
{
    public partial class Changepassword : Form
    {
        public Changepassword()
        {
            InitializeComponent();
        }

        private void txt_pwdreg_TextChanged(object sender, EventArgs e)
        {

        }

        private void Changepassword_Load(object sender, EventArgs e)
        {

        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = LAPTOP-I2KO1GJH; Initial Catalog = manthraclinic; Integrated Security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_resetpass", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("@Username", SqlDbType.VarChar);
            cmd.Parameters.Add(p1).Value = cpusername.Text.Trim();
            SqlParameter p2 = new SqlParameter("@password", SqlDbType.VarChar);
            cmd.Parameters.Add(p2).Value = cppassword.Text.Trim();
            

            int i = cmd.ExecuteNonQuery();

            if (i > 0)
            {
                MessageBox.Show("Password updated Sucessfully");
                Form1 f = new Form1();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Password updation Failed");
                cpusername.Clear();
                cppassword.Clear(); 
                con.Close();
            }
        }

        private void Reset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                 cpusername.Clear();

                cppassword.Clear();    
        }
    } 
}
