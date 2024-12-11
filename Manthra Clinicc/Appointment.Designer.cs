namespace Manthra_Clinicc
{
    partial class Appointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointment));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.ptid = new System.Windows.Forms.TextBox();
            this.ptname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ptage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.patmob = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pttreat = new System.Windows.Forms.ComboBox();
            this.ptdate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.ptsearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.serbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.fetchbtn = new System.Windows.Forms.Button();
            this.printbtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btn_clr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Location = new System.Drawing.Point(12, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 532);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(143, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(762, 276);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Patient Id";
            // 
            // ptid
            // 
            this.ptid.Location = new System.Drawing.Point(257, 64);
            this.ptid.Name = "ptid";
            this.ptid.Size = new System.Drawing.Size(100, 22);
            this.ptid.TabIndex = 5;
            // 
            // ptname
            // 
            this.ptname.Location = new System.Drawing.Point(520, 64);
            this.ptname.Name = "ptname";
            this.ptname.Size = new System.Drawing.Size(100, 22);
            this.ptname.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Patient Name";
            // 
            // ptage
            // 
            this.ptage.Location = new System.Drawing.Point(754, 64);
            this.ptage.Name = "ptage";
            this.ptage.Size = new System.Drawing.Size(100, 22);
            this.ptage.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(633, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Patient Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(151, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Treatment";
            // 
            // patmob
            // 
            this.patmob.Location = new System.Drawing.Point(520, 104);
            this.patmob.Name = "patmob";
            this.patmob.Size = new System.Drawing.Size(100, 22);
            this.patmob.TabIndex = 13;
            this.patmob.TextChanged += new System.EventHandler(this.patmob_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(365, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mobile Number";
            // 
            // pttreat
            // 
            this.pttreat.FormattingEnabled = true;
            this.pttreat.Items.AddRange(new object[] {
            "Filling",
            "Root Canal Treatment",
            "Extraction",
            "Consultation",
            "Tooth Removal",
            "Scaling"});
            this.pttreat.Location = new System.Drawing.Point(257, 102);
            this.pttreat.Name = "pttreat";
            this.pttreat.Size = new System.Drawing.Size(102, 24);
            this.pttreat.TabIndex = 14;
            // 
            // ptdate
            // 
            this.ptdate.Location = new System.Drawing.Point(730, 108);
            this.ptdate.Name = "ptdate";
            this.ptdate.Size = new System.Drawing.Size(151, 22);
            this.ptdate.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(633, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Datetime";
            // 
            // ptsearch
            // 
            this.ptsearch.Location = new System.Drawing.Point(481, 150);
            this.ptsearch.Name = "ptsearch";
            this.ptsearch.Size = new System.Drawing.Size(100, 22);
            this.ptsearch.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(345, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Search Patient";
            // 
            // serbtn
            // 
            this.serbtn.Location = new System.Drawing.Point(587, 150);
            this.serbtn.Name = "serbtn";
            this.serbtn.Size = new System.Drawing.Size(75, 23);
            this.serbtn.TabIndex = 19;
            this.serbtn.Text = "Search";
            this.serbtn.UseVisualStyleBackColor = true;
            this.serbtn.Click += new System.EventHandler(this.serbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(157, 479);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(99, 40);
            this.addbtn.TabIndex = 20;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // fetchbtn
            // 
            this.fetchbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fetchbtn.Location = new System.Drawing.Point(283, 479);
            this.fetchbtn.Name = "fetchbtn";
            this.fetchbtn.Size = new System.Drawing.Size(99, 40);
            this.fetchbtn.TabIndex = 21;
            this.fetchbtn.Text = "Fetch";
            this.fetchbtn.UseVisualStyleBackColor = true;
            this.fetchbtn.Click += new System.EventHandler(this.fetchbtn_Click);
            // 
            // printbtn
            // 
            this.printbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printbtn.Location = new System.Drawing.Point(532, 479);
            this.printbtn.Name = "printbtn";
            this.printbtn.Size = new System.Drawing.Size(99, 40);
            this.printbtn.TabIndex = 22;
            this.printbtn.Text = "Print";
            this.printbtn.UseVisualStyleBackColor = true;
            this.printbtn.Click += new System.EventHandler(this.printbtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.Location = new System.Drawing.Point(408, 479);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(99, 40);
            this.updatebtn.TabIndex = 23;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.Location = new System.Drawing.Point(652, 479);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(99, 40);
            this.deletebtn.TabIndex = 24;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(381, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "Appointment";
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logoutbtn.Location = new System.Drawing.Point(781, 12);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Size = new System.Drawing.Size(100, 34);
            this.Logoutbtn.TabIndex = 25;
            this.Logoutbtn.Text = "Log out";
            this.Logoutbtn.UseVisualStyleBackColor = true;
            this.Logoutbtn.Click += new System.EventHandler(this.Logoutbtn_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btn_clr
            // 
            this.btn_clr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clr.Location = new System.Drawing.Point(781, 479);
            this.btn_clr.Name = "btn_clr";
            this.btn_clr.Size = new System.Drawing.Size(99, 40);
            this.btn_clr.TabIndex = 27;
            this.btn_clr.Text = "Clear";
            this.btn_clr.UseVisualStyleBackColor = true;
            this.btn_clr.Click += new System.EventHandler(this.btn_clr_Click);
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(903, 531);
            this.Controls.Add(this.btn_clr);
            this.Controls.Add(this.Logoutbtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.printbtn);
            this.Controls.Add(this.fetchbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.serbtn);
            this.Controls.Add(this.ptsearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ptdate);
            this.Controls.Add(this.pttreat);
            this.Controls.Add(this.patmob);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ptage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ptname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ptid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Appointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ptid;
        private System.Windows.Forms.TextBox ptname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ptage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox patmob;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox pttreat;
        private System.Windows.Forms.DateTimePicker ptdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ptsearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button serbtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button fetchbtn;
        private System.Windows.Forms.Button printbtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Logoutbtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btn_clr;
    }
}