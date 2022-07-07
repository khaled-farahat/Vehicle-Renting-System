namespace DataBase
{
    partial class AdminForm
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
            this.Sign_Up = new System.Windows.Forms.Button();
            this.Address = new System.Windows.Forms.TextBox();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.SSN = new System.Windows.Forms.TextBox();
            this.LName = new System.Windows.Forms.TextBox();
            this.Minit = new System.Windows.Forms.TextBox();
            this.Fname = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.TextBox();
            this.Phone_No = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport31 = new DataBase.CrystalReport3();
            this.SalBox = new System.Windows.Forms.TextBox();
            this.Salary = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sign_Up
            // 
            this.Sign_Up.Location = new System.Drawing.Point(359, 547);
            this.Sign_Up.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Sign_Up.Name = "Sign_Up";
            this.Sign_Up.Size = new System.Drawing.Size(120, 44);
            this.Sign_Up.TabIndex = 40;
            this.Sign_Up.Text = "Sign Up";
            this.Sign_Up.UseVisualStyleBackColor = true;
            this.Sign_Up.Click += new System.EventHandler(this.Sign_Up_Click);
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(359, 425);
            this.Address.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(113, 22);
            this.Address.TabIndex = 37;
            // 
            // Gender
            // 
            this.Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "Male\t",
            "Female"});
            this.Gender.Location = new System.Drawing.Point(359, 353);
            this.Gender.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(137, 24);
            this.Gender.TabIndex = 36;
            // 
            // SSN
            // 
            this.SSN.Location = new System.Drawing.Point(357, 278);
            this.SSN.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.SSN.Name = "SSN";
            this.SSN.Size = new System.Drawing.Size(113, 22);
            this.SSN.TabIndex = 35;
            // 
            // LName
            // 
            this.LName.Location = new System.Drawing.Point(582, 197);
            this.LName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(105, 22);
            this.LName.TabIndex = 34;
            // 
            // Minit
            // 
            this.Minit.Location = new System.Drawing.Point(470, 197);
            this.Minit.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Minit.Name = "Minit";
            this.Minit.Size = new System.Drawing.Size(104, 22);
            this.Minit.TabIndex = 33;
            // 
            // Fname
            // 
            this.Fname.Location = new System.Drawing.Point(357, 197);
            this.Fname.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(105, 22);
            this.Fname.TabIndex = 32;
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(357, 120);
            this.Pass.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Pass.Name = "Pass";
            this.Pass.PasswordChar = '*';
            this.Pass.Size = new System.Drawing.Size(113, 22);
            this.Pass.TabIndex = 31;
            this.Pass.UseSystemPasswordChar = true;
            // 
            // Phone_No
            // 
            this.Phone_No.Location = new System.Drawing.Point(357, 48);
            this.Phone_No.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Phone_No.Name = "Phone_No";
            this.Phone_No.Size = new System.Drawing.Size(113, 22);
            this.Phone_No.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Location = new System.Drawing.Point(359, 396);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(357, 249);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "SSN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(598, 169);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "LName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(498, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Minit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(357, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Fname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(359, 325);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(357, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(357, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Phone Number";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 602);
            this.panel1.TabIndex = 41;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(37, 169);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "Show Employees";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Log Out";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Employees";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.crystalReportViewer1);
            this.panel2.Location = new System.Drawing.Point(226, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(921, 614);
            this.panel2.TabIndex = 3;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.CrystalReport31;
            this.crystalReportViewer1.Size = new System.Drawing.Size(921, 614);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // SalBox
            // 
            this.SalBox.Location = new System.Drawing.Point(357, 503);
            this.SalBox.Name = "SalBox";
            this.SalBox.Size = new System.Drawing.Size(100, 22);
            this.SalBox.TabIndex = 42;
            // 
            // Salary
            // 
            this.Salary.AutoSize = true;
            this.Salary.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Salary.Location = new System.Drawing.Point(362, 467);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(48, 17);
            this.Salary.TabIndex = 43;
            this.Salary.Text = "Salary";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DataBase.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1144, 602);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Sign_Up);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.SalBox);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.SSN);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.Minit);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.Phone_No);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sign_Up;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.TextBox SSN;
        private System.Windows.Forms.TextBox LName;
        private System.Windows.Forms.TextBox Minit;
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.TextBox Phone_No;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalReport3 CrystalReport31;
        private System.Windows.Forms.TextBox SalBox;
        private System.Windows.Forms.Label Salary;
    }
}