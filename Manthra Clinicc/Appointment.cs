using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manthra_Clinicc
{
    public partial class Appointment : Form
    {
        public Appointment()
        {
            InitializeComponent();
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                MessageBox.Show("Logout Sucessfully");
                Form1 f = new Form1();
                f.Show();
                this.Hide();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = LAPTOP-I2KO1GJH; Initial Catalog = manthraclinic; Integrated Security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_add", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("@pat_id", SqlDbType.VarChar);
            cmd.Parameters.Add(p1).Value = ptid.Text.Trim();
            SqlParameter p2 = new SqlParameter("@pat_name", SqlDbType.VarChar);
            cmd.Parameters.Add(p2).Value = ptname.Text.Trim();
            SqlParameter p3 = new SqlParameter("@pat_age", SqlDbType.Int);
            cmd.Parameters.Add(p3).Value = ptage.Text.Trim();
            SqlParameter p4 = new SqlParameter("@treatment", SqlDbType.VarChar);
            cmd.Parameters.Add(p4).Value = pttreat.SelectedItem.ToString();
            SqlParameter p5 = new SqlParameter("@mobile_num", SqlDbType.VarChar);
            cmd.Parameters.Add(p5).Value = patmob.Text.Trim();
            SqlParameter p6 = new SqlParameter("@date", SqlDbType.Date);
            cmd.Parameters.Add(p6).Value = ptdate.Text;

            int i = cmd.ExecuteNonQuery();

            if (i > 0)
            {
                MessageBox.Show("Details Added Sucessfully");
            }
            else
            {
                MessageBox.Show("Failed");
                con.Close();
            }
        }

        private void patmob_TextChanged(object sender, EventArgs e)
        {

        }

        private void fetchbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = LAPTOP-I2KO1GJH; Initial Catalog = manthraclinic; Integrated Security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_fetch", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure want to Delete?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection("Data Source = LAPTOP-I2KO1GJH; Initial Catalog = manthraclinic; Integrated Security = True");
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_delete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1 = new SqlParameter("pat_id", SqlDbType.VarChar);
                cmd.Parameters.Add(p1).Value = ptsearch.Text;
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show("Deleted Sucessfully");
                }
                con.Close();
                

            }
            
            
        }

        private void serbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = LAPTOP-I2KO1GJH; Initial Catalog = manthraclinic; Integrated Security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_search", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("@searchdata", SqlDbType.VarChar);
            cmd.Parameters.Add(p1).Value = ptsearch.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source = LAPTOP-I2KO1GJH; Initial Catalog = manthraclinic; Integrated Security = True");
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_update", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p1 = new SqlParameter("@pat_id", SqlDbType.VarChar);
                cmd.Parameters.Add(p1).Value = ptid.Text.Trim();
                SqlParameter p2 = new SqlParameter("@pat_name", SqlDbType.VarChar);
                cmd.Parameters.Add(p2).Value = ptname.Text.Trim();
                SqlParameter p3 = new SqlParameter("@pat_age", SqlDbType.Int);
                cmd.Parameters.Add(p3).Value = ptage.Text.Trim();
                SqlParameter p4 = new SqlParameter("@treatment", SqlDbType.VarChar);
                cmd.Parameters.Add(p4).Value = pttreat.SelectedItem.ToString();
                SqlParameter p5 = new SqlParameter("@mobile_num", SqlDbType.VarChar);
                cmd.Parameters.Add(p5).Value = patmob.Text.Trim();
                SqlParameter p6 = new SqlParameter("@date", SqlDbType.Date);
                cmd.Parameters.Add(p6).Value = ptdate.Text;

                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show("Details updated Sucessfully");
                }
                else
                {
                    MessageBox.Show("updation Failed");
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ptid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                ptname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                ptage.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                pttreat.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                patmob.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                ptdate.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Manthra Dental Clinic", new Font("Arial",20,FontStyle.Bold),Brushes.Red,new Point(250,10));

            e.Graphics.DrawString("Dental Surgen", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(300, 60));

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(50, 80));

            e.Graphics.DrawString("Date : " + ptdate.Text.Trim(),new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(45, 160));

            e.Graphics.DrawString("Patient Id : " + ptid.Text.Trim(),new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(45,240));

            e.Graphics.DrawString("Patient Name : " + ptname.Text.Trim(), new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(400, 160));

            e.Graphics.DrawString("Mobile Number : " + patmob.Text.Trim(),  new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(400, 240));

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(50, 300));


        }

        private void printbtn_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            ptid.Clear();
            ptname.Clear();
            ptage.Clear();
            patmob.Clear();
            
        }
    }
    
}
