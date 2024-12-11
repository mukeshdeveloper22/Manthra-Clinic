using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Manthra_Clinicc
{
    public partial class Forgot_Password : Form
    {
        string randomcode;
        public Forgot_Password()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string from, pass, messagebody,to;

            Random rand = new Random(); 
            randomcode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();    
            to = (fpemail.Text).ToString();
            from = "mukesh2297@gmail.com";
            pass = "lfcf tqjz rzlt osxq";
            messagebody = "Your OTP verification code : " + randomcode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messagebody;
            message.Subject = "verification";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from,pass);

            try
            {
                smtp.Send(message);
                MessageBox.Show("OTP Sended Sucessfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (randomcode == (txtotp.Text).ToString())
            {
                MessageBox.Show("OTP verified Successfully");
                Changepassword p = new Changepassword();
                p.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid OTP");
            }
        }
    }
}
