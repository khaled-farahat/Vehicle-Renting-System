using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace DataBase
{
    public partial class Lessor : Form
    {
        Controller controllerObj;
        //string lessphone;
        int LessSSN;
        DataTable dtvehicles;
        int ivehicle = 0;
        DataRow r;

        public Lessor(int LSSN)
        {
            LessSSN = LSSN;
            InitializeComponent();
        }

        private void Lessor_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();

        }

        private void Report_Click(object sender, EventArgs e)
        {

            panel4.Visible = false;
            panel5.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
        }

        private void Choose_Vehicle_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel5.Visible = false;
            panel3.Visible = false;
            panel2.Visible = true;
        }

        private void txttitle_Leave(object sender, EventArgs e)
        {
            if (txttitle.Text == "")
            {
                txttitle.Text = "Not more than 15 characters";
                txttitle.ForeColor = Color.Silver;
            }
        }

        private void txttitle_Enter(object sender, EventArgs e)
        {
            if (txttitle.Text == "Not more than 15 characters")
            {
                txttitle.Text = "";
                txttitle.ForeColor = Color.Black;
            }
        }

        private void comtyper_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comtyper.Text == "Car")
            {
                comcost.Items.Clear();
                comcost.Items.Add("Between 300,400 EGP per day");
                comcost.Items.Add("Between 400,500 EGP per day");
                comcost.Items.Add("More than 500 EGP per day");

            }
            if (comtyper.Text == "Ship")
            {
                comcost.Items.Clear();
                comcost.Items.Add("Between 20000,22000$ per day");
                comcost.Items.Add("Between 22000,25000$ per day");
                comcost.Items.Add("More than 25000$ per day");
            }
            if (comtyper.Text == "Motorcycle")
            {
                comcost.Items.Clear();
                comcost.Items.Add("Between 50,100 EGP per day");
                comcost.Items.Add("Between 100,200 EGP per day");
                comcost.Items.Add("More than 200 EGP per day");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtorderno.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter The Order Number");
                return;
            }

            if (txtvno.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter The Vehicle Number");
                return;
            }

            if (txttitle.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter The Reason For Complain");
                return;
            }

            if (txttitle.Text.Length > 15)
            {
                MessageBox.Show("The Reason For Complain Doesn't exceed 15 characters " +
                    "\n" + "You can add any other information down at Add any other information");
                txttitle.Focus();
                txttitle.SelectAll();
                return;
            }

            int orderno = controllerObj.RetrieveorderNo(LessSSN);
            int vno = controllerObj.RetrievevehicleNo(LessSSN);
            bool k1; bool k2;
            int v1; int v2;
            k1 = int.TryParse(txtorderno.Text, out v1);
            k2 = int.TryParse(txtvno.Text, out v2);
            if (!k1 || orderno != Convert.ToInt32(txtorderno.Text))
            {
                MessageBox.Show("Wrong Order Number");
                txtorderno.Focus();
                txtorderno.SelectAll();
                return;
            }

            if (!k2 || vno != Convert.ToInt32(txtvno.Text))
            {
                MessageBox.Show("Wrong Vehicle Number");
                txtvno.Focus();
                txtvno.SelectAll();
                return;
            }

            bool caninsert = controllerObj.Retrieverepotitle(orderno, txttitle.Text);
            if (!caninsert)
            {
                MessageBox.Show("You complained for the same reason before , We will see your" +
                   "Report and Apply as soon as possible");

                txttitle.Focus();
                txttitle.SelectAll();
                return;
            }

            int res = controllerObj.insertLessorReport(orderno, txttitle.Text, txtinfo.Text, LessSSN);
            if (res == 0)
            {
                MessageBox.Show("Invalid Information");
                txtorderno.Focus();
                txtorderno.SelectAll();
                txtvno.Focus();
                txtvno.SelectAll();
                txttitle.Focus();
                txttitle.SelectAll();
                return;
            }

            else
            {
                MessageBox.Show("Thanks For Informing Us , We Will Reply As Soon As Possible");
                return;
            }

        }

        private void button3_Click(object sender, EventArgs e)//previos
        {
            button2.Enabled = true;
            if (ivehicle > 0)
            {
                button3.Enabled = true;
                ivehicle--;
                r = dtvehicles.Rows[ivehicle];

            }
            if (ivehicle - 1 < 0)
                button3.Enabled = false;

            lbldetails.Text = "Model : " + r["Model"].ToString()
                + "\n" + "Licence Number : " + r["LicenceNo"].ToString()
                + "\n" + "Year Of Production : " + r["Vyear"].ToString()
                + "\n" + "Cost Per Day : " + r["Cost"].ToString()
                + "\n" + "Vehicle Will Be Available Untill : " + Convert.ToDateTime(r["Duration"]).ToShortDateString()
                + "\n" + "Location : " + r["Location"].ToString();
            if (r["Vimage"] != DBNull.Value)
            {
                byte[] img = (byte[])(r["Vimage"]);
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
            }
        }

        private void button5_Click(object sender, EventArgs e)//choose
        {

            if (comtyper.Text == "")
            {
                MessageBox.Show("Please Choose The VehicleType You Want");
                return;
            }

            if (comcost.Text == "")
            {
                MessageBox.Show("Please Choose The Range of Cost You Need");
                return;
            }
            dtvehicles = controllerObj.Retrievevehicle(comtyper.Text, comcost.Text);
            if (dtvehicles == null)
            {
                MessageBox.Show("No Available Vehicles in That Range"
                    + "You Can Try another type or another cost");
                return;
            }
            if (dtvehicles.Rows.Count > 1)
            {
                button2.Enabled = true;
                button3.Enabled = true;
            }

            r = dtvehicles.Rows[0];

            lbldetails.Text = "Model : " + r["Model"].ToString()
                + "\n" + "Licence Number : " + r["LicenceNo"].ToString()
                + "\n" + "Year Of Production : " + r["Vyear"].ToString()
                + "\n" + "Cost Per Day : " + r["Cost"].ToString()
                + "\n" + "Vehicle Will Be Available Untill : " + Convert.ToDateTime(r["Duration"]).ToShortDateString()
                + "\n" + "Location : " + r["Location"].ToString();
            if (r["Vimage"] != DBNull.Value)
            {
                byte[] img = (byte[])(r["Vimage"]);
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
            }






        }

        private void button2_Click(object sender, EventArgs e)//next
        {
            button3.Enabled = true;
            if (ivehicle + 1 < dtvehicles.Rows.Count)
            {
                button2.Enabled = true;
                ivehicle++;
                r = dtvehicles.Rows[ivehicle];

            }
            if (ivehicle + 1 >= dtvehicles.Rows.Count)
                button2.Enabled = false;



            lbldetails.Text = "Model : " + r["Model"].ToString()
                + "\n" + "Licence Number : " + r["LicenceNo"].ToString()
                + "\n" + "Year Of Production : " + r["Vyear"].ToString()
                + "\n" + "Cost Per Day : " + r["Cost"].ToString()
                + "\n" + "Vehicle Will Be Available Untill : " + Convert.ToDateTime(r["Duration"]).ToShortDateString()
                + "\n" + "Location : " + r["Location"].ToString();
            if (r["Vimage"] != DBNull.Value)
            {
                byte[] img = (byte[])(r["Vimage"]);
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
            }
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (lbldetails.Text != "")
            {
                panel2.Visible = false;
                panel3.Visible = false;
                panel5.Visible = false;
                panel4.Visible = true;
                txtmodel.Text = r["Model"].ToString();
                txtlno.Text = r["LicenceNo"].ToString();
                txtcost.Text = r["Cost"].ToString();
                txtloc.Text = r["Location"].ToString();
                txtyear.Text = r["Vyear"].ToString();
                if (r["Vimage"] != DBNull.Value)
                {
                    byte[] img = (byte[])(r["Vimage"]);
                    MemoryStream ms = new MemoryStream(img);
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
            else
            {
                MessageBox.Show("Please Choose the Vehicle You Want First ");
                return;
            }
        }

        private void btnprogress_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = true;
        }

        private void btnLess_Click(object sender, EventArgs e)
        {
            if (txtdur.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter The Duration");
            }

            bool k1; int v1;
            k1 = int.TryParse(txtdur.Text, out v1);
            if (!k1)
            {
                MessageBox.Show("Please Enter The Duration in Days");
                txtdur.Focus();
                txtdur.SelectAll();
            }
            DateTime Enddateoftheuser = DateTime.Today.AddDays(Convert.ToInt32(txtdur.Text));
            DateTime EnddateofTheVehicle = Convert.ToDateTime(r["Duration"]);
            int result = DateTime.Compare(Enddateoftheuser, EnddateofTheVehicle);
            if (result > 0)
            {
                MessageBox.Show("The Vehicle Would Be Available For That Date Only" + r["Duration"].ToString()
                    + "\n" + "Please Reenter The Duration in Days");
                txtdur.Focus();
                txtdur.SelectAll();
            }
            else
            {
                int MyOrderNumber;
                DataTable dt = new DataTable();
                dt = controllerObj.RetrieveLessorVehicle();
                int Res;
                int Res2;
                if (dt == null)
                {
                    MyOrderNumber = 0;
                    Res = controllerObj.LessAVehicle(LessSSN, MyOrderNumber, Convert.ToInt32(r["LicenceNo"]), Enddateoftheuser, DateTime.Today);
                    Res2 = controllerObj.updateVehicleavailability(Convert.ToInt32(r["LicenceNo"]));
                }
                else
                {
                    DataRow dar = dt.Rows[dt.Rows.Count - 1];
                    MyOrderNumber = Convert.ToInt32(dar["Order_No"]) + 1;
                    Res = controllerObj.LessAVehicle(LessSSN, MyOrderNumber, Convert.ToInt32(r["LicenceNo"]), Enddateoftheuser, DateTime.Today);
                    Res2 = controllerObj.updateVehicleavailability(Convert.ToInt32(r["LicenceNo"]));
                }
                if (Res == 0 || Res2 == 0)
                {
                    MessageBox.Show("Wrong Information" +
                        "\n" + "Please Try Again");
                }
                else
                {
                    MessageBox.Show("You Lessed The Vehicle Successfully ," + "\n" +
                        "You can go and Take it From its Location " + "\n" +
                        "But Please Keep Your Order Number And The Licence Number of the car"
                        + "\n" + "You May need Them Later " + "\n"
                        + "Your Order Number is " + MyOrderNumber + " And The Car Licence Number is " + r["LicenceNo"].ToString() + "\n"
                        + "Happy To Help You , Have a nice day");
                }
            }
        }
        private void Lessor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Interface Form = new Interface();
            Form.Show();
        }

        private void txttitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}