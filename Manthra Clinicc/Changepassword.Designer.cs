namespace Manthra_Clinicc
{
    partial class Changepassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Changepassword));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Reset = new System.Windows.Forms.LinkLabel();
            this.btnreg = new System.Windows.Forms.Button();
            this.cpusername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cppassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(42, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 543);
            this.panel1.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dental Clinic Management";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 340);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Reset
            // 
            this.Reset.AutoSize = true;
            this.Reset.Location = new System.Drawing.Point(773, 253);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(43, 16);
            this.Reset.TabIndex = 40;
            this.Reset.TabStop = true;
            this.Reset.Text = "Reset";
            this.Reset.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Reset_LinkClicked);
            // 
            // btnreg
            // 
            this.btnreg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreg.Location = new System.Drawing.Point(563, 299);
            this.btnreg.Name = "btnreg";
            this.btnreg.Size = new System.Drawing.Size(187, 40);
            this.btnreg.TabIndex = 33;
            this.btnreg.Text = "Set Password";
            this.btnreg.UseVisualStyleBackColor = true;
            this.btnreg.Click += new System.EventHandler(this.btnreg_Click);
            // 
            // cpusername
            // 
            this.cpusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpusername.Location = new System.Drawing.Point(630, 198);
            this.cpusername.Name = "cpusername";
            this.cpusername.Size = new System.Drawing.Size(120, 22);
            this.cpusername.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(488, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(511, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 35);
            this.label2.TabIndex = 28;
            this.label2.Text = "Change password";
            // 
            // cppassword
            // 
            this.cppassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cppassword.Location = new System.Drawing.Point(630, 249);
            this.cppassword.Name = "cppassword";
            this.cppassword.Size = new System.Drawing.Size(120, 22);
            this.cppassword.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(415, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 25);
            this.label6.TabIndex = 41;
            this.label6.Text = "Confirm password";
            // 
            // Changepassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(832, 540);
            this.Controls.Add(this.cppassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.btnreg);
            this.Controls.Add(this.cpusername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Changepassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Changepassword";
            this.Load += new System.EventHandler(this.Changepassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel Reset;
        private System.Windows.Forms.Button btnreg;
        private System.Windows.Forms.TextBox cpusername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cppassword;
        private System.Windows.Forms.Label label6;
    }
}