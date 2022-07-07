
namespace DataBase
{
    partial class Employee
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Show_Requests = new System.Windows.Forms.Button();
            this.Show_Reports = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport21 = new DataBase.CrystalReport2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.Refuse = new System.Windows.Forms.Button();
            this.Accept = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Show_req = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Show = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Update_Renter_Vehicle = new System.Windows.Forms.Button();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.Show_RVehicle = new System.Windows.Forms.Button();
            this.Update_Lessor_Vehicle = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.Show_Lvehicles = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Delete_Lessor = new System.Windows.Forms.Button();
            this.Delete_Renter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Update);
            this.panel1.Controls.Add(this.Show_Requests);
            this.panel1.Controls.Add(this.Show_Reports);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 605);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(56, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 43);
            this.button2.TabIndex = 6;
            this.button2.Text = "Log Out";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "Show Statistics";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(56, 231);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(159, 53);
            this.Update.TabIndex = 4;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Show_Requests
            // 
            this.Show_Requests.Location = new System.Drawing.Point(56, 139);
            this.Show_Requests.Name = "Show_Requests";
            this.Show_Requests.Size = new System.Drawing.Size(159, 53);
            this.Show_Requests.TabIndex = 2;
            this.Show_Requests.Text = "Show Requests";
            this.Show_Requests.UseVisualStyleBackColor = true;
            this.Show_Requests.Click += new System.EventHandler(this.Show_Requests_Click);
            // 
            // Show_Reports
            // 
            this.Show_Reports.Location = new System.Drawing.Point(56, 43);
            this.Show_Reports.Name = "Show_Reports";
            this.Show_Reports.Size = new System.Drawing.Size(159, 56);
            this.Show_Reports.TabIndex = 0;
            this.Show_Reports.Text = "Show Reports";
            this.Show_Reports.UseVisualStyleBackColor = true;
            this.Show_Reports.Click += new System.EventHandler(this.Show_Reports_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.crystalReportViewer1);
            this.panel5.Location = new System.Drawing.Point(286, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1216, 604);
            this.panel5.TabIndex = 6;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer1.AutoSize = true;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.CrystalReport21;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1213, 604);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.BackgroundImage = global::DataBase.Properties.Resources.Background;
            this.panel3.Controls.Add(this.comboBox3);
            this.panel3.Controls.Add(this.Refuse);
            this.panel3.Controls.Add(this.Accept);
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Controls.Add(this.Show_req);
            this.panel3.Location = new System.Drawing.Point(289, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1208, 605);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(953, 64);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(138, 24);
            this.comboBox3.TabIndex = 4;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // Refuse
            // 
            this.Refuse.Location = new System.Drawing.Point(1102, 95);
            this.Refuse.Name = "Refuse";
            this.Refuse.Size = new System.Drawing.Size(97, 35);
            this.Refuse.TabIndex = 3;
            this.Refuse.Text = "Refuse";
            this.Refuse.UseVisualStyleBackColor = true;
            this.Refuse.Click += new System.EventHandler(this.Refuse_Click);
            // 
            // Accept
            // 
            this.Accept.Location = new System.Drawing.Point(1102, 16);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(97, 35);
            this.Accept.TabIndex = 2;
            this.Accept.Text = "Accept";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(127, 43);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 26;
            this.dataGridView2.Size = new System.Drawing.Size(820, 422);
            this.dataGridView2.TabIndex = 1;
            // 
            // Show_req
            // 
            this.Show_req.Location = new System.Drawing.Point(21, 43);
            this.Show_req.Name = "Show_req";
            this.Show_req.Size = new System.Drawing.Size(99, 45);
            this.Show_req.TabIndex = 0;
            this.Show_req.Text = "Show req";
            this.Show_req.UseVisualStyleBackColor = true;
            this.Show_req.Click += new System.EventHandler(this.Show_req_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.BackgroundImage = global::DataBase.Properties.Resources.Background;
            this.panel2.Controls.Add(this.Show);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(286, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1212, 605);
            this.panel2.TabIndex = 1;
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(39, 43);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(118, 43);
            this.Show.TabIndex = 1;
            this.Show.Text = "Show";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(207, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(382, 256);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.Info;
            this.panel4.BackgroundImage = global::DataBase.Properties.Resources.Background;
            this.panel4.Controls.Add(this.Update_Renter_Vehicle);
            this.panel4.Controls.Add(this.comboBox5);
            this.panel4.Controls.Add(this.dataGridView4);
            this.panel4.Controls.Add(this.Show_RVehicle);
            this.panel4.Controls.Add(this.Update_Lessor_Vehicle);
            this.panel4.Controls.Add(this.dataGridView3);
            this.panel4.Controls.Add(this.comboBox4);
            this.panel4.Controls.Add(this.Show_Lvehicles);
            this.panel4.Controls.Add(this.comboBox2);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.Delete_Lessor);
            this.panel4.Controls.Add(this.Delete_Renter);
            this.panel4.Location = new System.Drawing.Point(286, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1208, 605);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint_1);
            // 
            // Update_Renter_Vehicle
            // 
            this.Update_Renter_Vehicle.Location = new System.Drawing.Point(490, 382);
            this.Update_Renter_Vehicle.Name = "Update_Renter_Vehicle";
            this.Update_Renter_Vehicle.Size = new System.Drawing.Size(189, 43);
            this.Update_Renter_Vehicle.TabIndex = 12;
            this.Update_Renter_Vehicle.Text = "Update_Renter_Vehicle";
            this.Update_Renter_Vehicle.UseVisualStyleBackColor = true;
            this.Update_Renter_Vehicle.Click += new System.EventHandler(this.Update_Renter_Vehicle_Click);
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(686, 392);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(138, 24);
            this.comboBox5.TabIndex = 11;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(207, 347);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 26;
            this.dataGridView4.Size = new System.Drawing.Size(274, 150);
            this.dataGridView4.TabIndex = 10;
            // 
            // Show_RVehicle
            // 
            this.Show_RVehicle.Location = new System.Drawing.Point(24, 392);
            this.Show_RVehicle.Name = "Show_RVehicle";
            this.Show_RVehicle.Size = new System.Drawing.Size(176, 43);
            this.Show_RVehicle.TabIndex = 9;
            this.Show_RVehicle.Text = "Show Renter_vehicles";
            this.Show_RVehicle.UseVisualStyleBackColor = true;
            this.Show_RVehicle.Click += new System.EventHandler(this.Show_RVehicle_Click);
            // 
            // Update_Lessor_Vehicle
            // 
            this.Update_Lessor_Vehicle.Location = new System.Drawing.Point(490, 207);
            this.Update_Lessor_Vehicle.Name = "Update_Lessor_Vehicle";
            this.Update_Lessor_Vehicle.Size = new System.Drawing.Size(178, 46);
            this.Update_Lessor_Vehicle.TabIndex = 8;
            this.Update_Lessor_Vehicle.Text = "Update_Lessor_Vehicle";
            this.Update_Lessor_Vehicle.UseVisualStyleBackColor = true;
            this.Update_Lessor_Vehicle.Click += new System.EventHandler(this.Update_Vehicle_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(207, 160);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 26;
            this.dataGridView3.Size = new System.Drawing.Size(274, 150);
            this.dataGridView3.TabIndex = 7;
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(675, 217);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(138, 24);
            this.comboBox4.TabIndex = 6;
            // 
            // Show_Lvehicles
            // 
            this.Show_Lvehicles.Location = new System.Drawing.Point(24, 175);
            this.Show_Lvehicles.Name = "Show_Lvehicles";
            this.Show_Lvehicles.Size = new System.Drawing.Size(176, 43);
            this.Show_Lvehicles.TabIndex = 5;
            this.Show_Lvehicles.Text = "Show Lessor_vehicles";
            this.Show_Lvehicles.UseVisualStyleBackColor = true;
            this.Show_Lvehicles.Click += new System.EventHandler(this.Show_Cars_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(207, 106);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(138, 24);
            this.comboBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(207, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // Delete_Lessor
            // 
            this.Delete_Lessor.Location = new System.Drawing.Point(24, 92);
            this.Delete_Lessor.Name = "Delete_Lessor";
            this.Delete_Lessor.Size = new System.Drawing.Size(158, 43);
            this.Delete_Lessor.TabIndex = 2;
            this.Delete_Lessor.Text = "Delete Lessor";
            this.Delete_Lessor.UseVisualStyleBackColor = true;
            this.Delete_Lessor.Click += new System.EventHandler(this.Delete_Lessor_Click);
            // 
            // Delete_Renter
            // 
            this.Delete_Renter.Location = new System.Drawing.Point(24, 12);
            this.Delete_Renter.Name = "Delete_Renter";
            this.Delete_Renter.Size = new System.Drawing.Size(158, 43);
            this.Delete_Renter.TabIndex = 1;
            this.Delete_Renter.Text = "Delete Renter";
            this.Delete_Renter.UseVisualStyleBackColor = true;
            this.Delete_Renter.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 605);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Name = "Employee";
            this.Text = "Employee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Employee_FormClosing);
            this.Load += new System.EventHandler(this.Employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Show_Requests;
        private System.Windows.Forms.Button Show_Reports;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Refuse;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Show_req;
        private System.Windows.Forms.Button Delete_Renter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Delete_Lessor;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button Show_Lvehicles;
        private System.Windows.Forms.Button Update_Lessor_Vehicle;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button Show_RVehicle;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button Update_Renter_Vehicle;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel5;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalReport2 CrystalReport21;
        private System.Windows.Forms.Button button2;
    }
}