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
    public partial class Interface_Sign_Up : Form
    {
        Controller controllerObj;
        Validation v1;

        public Interface_Sign_Up()
        {
            InitializeComponent();
        }

        private void Interface_Sign_Up_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            v1 = new Validation();
        }

        private void Sign_Up_Click(object sender, EventArgs e)
        {

            if (v1.Check_Phone_Number(Phone_No.Text) && v1._validatePassword(Pass.Text) && v1.validatePositiveNumber(SSN.Text) && v1.validateString(Fname.Text) && v1.validateString(LName.Text))
            {
                if (User.Text == "Lessor")
                {
                    int result = controllerObj.insertLessor(Fname.Text, Minit.Text, LName.Text, SSN.Text, Phone_No.Text, Pass.Text);
                    if (result == 1)
                    {
                        MessageBox.Show("Welcome "+ Fname.Text);
                        this.Hide();
                        Lessor Form = new Lessor(controllerObj.RetrieveLessorSSN(Phone_No.Text));
                        Form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Check SSN AND Phone Number");
                    }
                   
                }
                
                else if (User.Text == "Renter")
                {
                    int result = controllerObj.insertRenter(Fname.Text, Minit.Text, LName.Text, SSN.Text, Phone_No.Text, Pass.Text);
                    if (result == 1)
                    {
                        MessageBox.Show("Welcome "+ Fname.Text);
                        this.Hide();
                        Renter Form = new Renter(controllerObj.RetrieveRenterSSN(Phone_No.Text));
                        Form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Check SSN AND Phone Number");
                    }
                }
                else
                {
                    MessageBox.Show("Enter The USER");

                }
            }
        }

        private void Interface_Sign_Up_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
