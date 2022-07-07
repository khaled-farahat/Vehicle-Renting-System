
namespace DataBase
{
    partial class Interface
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Phone_No = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.TextBox();
            this.Log_In = new System.Windows.Forms.Button();
            this.Sign_Up = new System.Windows.Forms.Button();
            this.User = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.change = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.nowchange = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImageKey = "(none)";
            this.label1.Location = new System.Drawing.Point(312, 164);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(351, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // Phone_No
            // 
            this.Phone_No.Location = new System.Drawing.Point(464, 161);
            this.Phone_No.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Phone_No.Name = "Phone_No";
            this.Phone_No.Size = new System.Drawing.Size(197, 22);
            this.Phone_No.TabIndex = 2;
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(464, 206);
            this.Pass.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Pass.Name = "Pass";
            this.Pass.PasswordChar = '*';
            this.Pass.Size = new System.Drawing.Size(197, 22);
            this.Pass.TabIndex = 3;
            // 
            // Log_In
            // 
            this.Log_In.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Log_In.Location = new System.Drawing.Point(464, 356);
            this.Log_In.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Log_In.Name = "Log_In";
            this.Log_In.Size = new System.Drawing.Size(92, 31);
            this.Log_In.TabIndex = 4;
            this.Log_In.Text = "Log In";
            this.Log_In.UseVisualStyleBackColor = false;
            this.Log_In.Click += new System.EventHandler(this.Log_In_Click);
            // 
            // Sign_Up
            // 
            this.Sign_Up.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Sign_Up.Location = new System.Drawing.Point(572, 356);
            this.Sign_Up.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Sign_Up.Name = "Sign_Up";
            this.Sign_Up.Size = new System.Drawing.Size(91, 31);
            this.Sign_Up.TabIndex = 5;
            this.Sign_Up.Text = "Sign Up";
            this.Sign_Up.UseVisualStyleBackColor = false;
            this.Sign_Up.Click += new System.EventHandler(this.Sign_Up_Click);
            // 
            // User
            // 
            this.User.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.User.FormattingEnabled = true;
            this.User.Items.AddRange(new object[] {
            "Employee",
            "Renter",
            "Lessor",
            "Admin"});
            this.User.Location = new System.Drawing.Point(464, 247);
            this.User.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(197, 24);
            this.User.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(387, 250);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "User";
            // 
            // change
            // 
            this.change.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.change.Location = new System.Drawing.Point(499, 393);
            this.change.Margin = new System.Windows.Forms.Padding(4);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(128, 49);
            this.change.TabIndex = 8;
            this.change.Text = "Change Password";
            this.change.UseVisualStyleBackColor = false;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.Location = new System.Drawing.Point(760, 467);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(177, 22);
            this.textBox1.TabIndex = 9;
            this.textBox1.Visible = false;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox2.Location = new System.Drawing.Point(760, 534);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(177, 22);
            this.textBox2.TabIndex = 10;
            this.textBox2.Visible = false;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // nowchange
            // 
            this.nowchange.Location = new System.Drawing.Point(947, 494);
            this.nowchange.Margin = new System.Windows.Forms.Padding(4);
            this.nowchange.Name = "nowchange";
            this.nowchange.Size = new System.Drawing.Size(141, 26);
            this.nowchange.TabIndex = 11;
            this.nowchange.Text = "Change";
            this.nowchange.UseVisualStyleBackColor = true;
            this.nowchange.Visible = false;
            this.nowchange.Click += new System.EventHandler(this.nowchange_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(603, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Current Password";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(603, 539);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "New Password";
            this.label5.Visible = false;
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DataBase.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1381, 593);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nowchange);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.change);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.User);
            this.Controls.Add(this.Sign_Up);
            this.Controls.Add(this.Log_In);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.Phone_No);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Interface";
            this.Text = "Interface";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Interface_FormClosing);
            this.Load += new System.EventHandler(this.Interface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Phone_No;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.Button Log_In;
        private System.Windows.Forms.Button Sign_Up;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox User;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button nowchange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

