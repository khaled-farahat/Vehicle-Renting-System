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
    public partial class Interface : Form
    {
        Controller controllerObj;
        Validation v1;
        public Interface()
        {
            InitializeComponent();
        }

        private void Interface_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            v1 = new Validation();
        }

        private void Log_In_Click(object sender, EventArgs e)
        {
            if (User.Text == "Employee")
            {
                if (v1._validateEmployeePhoneExist(Phone_No.Text) && v1._validateEmployeePassword(Phone_No.Text, Pass.Text))
                {
                    this.Hide();
                    Employee Form = new Employee();
                    Form.Show();
                }
            }
            else if (User.Text == "Lessor")
            {
                if (v1._validateLessorPhoneExist(Phone_No.Text) && v1._validateLessorPassword(Phone_No.Text, Pass.Text))
                {
                    this.Hide();
                    Lessor Form = new Lessor(controllerObj.RetrieveLessorSSN(Phone_No.Text));
                    Form.Show();
                }
            }
            else if (User.Text == "Renter")
            {
                if (v1._validateRenterPhoneExist(Phone_No.Text) && v1._validateRenterPassword(Phone_No.Text, Pass.Text))
                {
                    this.Hide();
                    Renter Form = new Renter(controllerObj.RetrieveRenterSSN(Phone_No.Text));
                    Form.Show();
                }
            }
            else if(User.Text == "Admin")
            {
                if(v1._validateAdmin("01055565660",Pass.Text))
                {
                    this.Hide();
                    AdminForm Form = new AdminForm();
                    Form.Show();
                }
            }
            else
            {
                MessageBox.Show("Enter The USER");

            }

        }

        private void Sign_Up_Click(object sender, EventArgs e)
        {
            this.Hide();
            Interface_Sign_Up Form = new Interface_Sign_Up();
            Form.Show();
        }

        private void change_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            nowchange.Visible = true;
            label4.Visible = true;
            label5.Visible = true;


        }

        private void nowchange_Click(object sender, EventArgs e)
        {
            if (User.Text == "Employee")
            {
                if(v1._validateEmployeePhoneExist(Phone_No.Text)&&v1._validateEmployeePassword(Phone_No.Text,textBox1.Text))
                {
                    int result = controllerObj.changepasswordEMP(textBox2.Text, Phone_No.Text);
                    if (result == 1)
                    {
                        MessageBox.Show("You change your password successfully");
                    }
                    else
                    {
                        MessageBox.Show("please put right password");
                    }
                }
            }
            else if(User.Text == "Lessor")
            {
                if(v1._validateLessorPhoneExist(Phone_No.Text) && v1._validateLessorPassword(Phone_No.Text,textBox1.Text))
                {
                   int result= controllerObj.changepasswordLessor(textBox2.Text, Phone_No.Text);
                    if(result==1)
                    {
                        MessageBox.Show("You change your password successfully");
                    }
                    else
                    {
                        MessageBox.Show("please put right password");
                    }
                }
            
            }
            else if(User.Text == "Renter")
            {
                if (v1._validateRenterPhoneExist(Phone_No.Text) && v1._validateRenterPassword(Phone_No.Text, textBox1.Text))
                {
                    int result = controllerObj.changepasswordRenter(textBox2.Text, Phone_No.Text);
                    if (result == 1)
                    {
                        MessageBox.Show("You change your password successfully");
                    }
                    else
                    {
                        MessageBox.Show("please put right password");
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter The USER");
            }
        }

        private void Interface_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            //if (textBox1.Text == "")
            //{
            //    textBox1.Text = "Current Password";
            //    textBox1.ForeColor = Color.Silver;
            //}
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            //if (textBox1.Text == "Current Password")
            //{
            //    textBox1.Text = "";
            //    textBox1.ForeColor = Color.Black;
            //}
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            //if (textBox2.Text == "")
            //{
            //    textBox2.Text = "New Password";
            //    textBox2.ForeColor = Color.Silver;
            //}
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            //if (textBox2.Text == "New Password")
            //{
            //    textBox1.Text = "";
            //    textBox2.ForeColor = Color.Black;
            //}
        }
    }
}
