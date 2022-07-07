using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    public partial class AdminForm : Form
    {
        Controller controllerObj;
        Validation v1;
        public AdminForm()
        {
            InitializeComponent();
            panel2.Visible = false;
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            v1 = new Validation();
        }
        private void Sign_Up_Click(object sender, EventArgs e)
        {
            if (v1.Check_Phone_Number(Phone_No.Text) && v1._validatePassword(Pass.Text) && v1.validatePositiveNumber(SSN.Text) && v1.validateString(Fname.Text) && v1.validateString(LName.Text) && v1.validatePositiveNumber(SalBox.Text))
            {
                int result = controllerObj.insertEmployee(Fname.Text, Minit.Text, LName.Text, SSN.Text, Phone_No.Text, Pass.Text, Address.Text, Gender.Text[0],SalBox.Text);
                if (result == 1)
                {
                    MessageBox.Show("Welcome Employee");
                  
                }
                else
                {
                    MessageBox.Show("Check SSN AND Phone Number");
                }
            }

        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Interface Form = new Interface();
            Form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible=false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }
    }
}
