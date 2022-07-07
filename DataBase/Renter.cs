using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    public partial class Renter : Form
    {
        Controller controllerObj = new Controller();
        ControllerP controllerPObj = new ControllerP();
        int rssn;
        public Renter(int RSSN)
        {
             rssn = RSSN;
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Renter_Load(object sender, EventArgs e)
        {

        }

        private void Add_Vehicle_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel2.Visible = true;
        }

        private void Report_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        byte[] ConvertImageToBytes(Image img)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public Image ConverByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files(*.jpg;*.jpeg)|*.jpg;*.jpeg",Multiselect=false})
            {
                if(ofd.ShowDialog()==DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var rd=controllerPObj.check_vehicle(int.Parse(VnoBox.Text));

            bool VehicleExists = rd==null;
            int lino;
            int c;
            int y;
            bool ychk =int.TryParse(YBox.Text,out y) && (YBox.Text.Length == 4) && (y >= 1800) && (y <= 2022);
            
            DateTime today = DateTime.Today;
            bool datechk = dateTimePicker1.Value.Date > today;
            bool picchk = pictureBox1.Image != null;
           
            if(comboBox2.Text!=""&& ModBox.Text!=""&& int.TryParse(VnoBox.Text,out lino)&& int.TryParse(Costbox.Text, out c)&& LocBox.Text!=""&&ychk&&datechk&&picchk&&VehicleExists)
            {
                int result = controllerPObj.InsertVehicle(ModBox.Text, comboBox2.Text, int.Parse(VnoBox.Text), YBox.Text, ConvertImageToBytes(pictureBox1.Image), int.Parse(Costbox.Text), LocBox.Text, dateTimePicker1.Value.Date, rssn);
                if (result == 0)
                {
                    MessageBox.Show("the vehicle not inserted");                    
                }
                else
                {
                    MessageBox.Show("your vehicle is inserted successfully");
                    ModBox.Clear();
                    VnoBox.Clear();
                    YBox.Clear();
                    // pictureBox1.Image = null;
                    LocBox.Text = string.Empty;
                    Costbox.Text = string.Empty;
                }
            }
            else 
            {
                if(!ychk)
                {
                    MessageBox.Show("wrong year");
                }
                else if(!datechk)
                {
                    MessageBox.Show("wrong End Date");
                }
                else if(!picchk)
                {
                    MessageBox.Show("please insert a picture");
                }
                else if(!VehicleExists)
                {
                    MessageBox.Show("you have inserted the vehicle before");
                }
                else
                    MessageBox.Show("wrong datatypes");
            }
        }
       
        private void YBox_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"[^0-9^]");
            MatchCollection matches = regex.Matches(YBox.Text);
            if(matches.Count>0)
            {
                MessageBox.Show("please enter numbers");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            char RorL='R';
            int no;
            //if (radioButton1.Checked == true)
            //    RorL = 'R';
            //if (radioButton2.Checked == true)
            //    RorL = 'L';
            //bool rl = radioButton1.Checked == false && radioButton2.Checked == false;
            
            if (int.TryParse(OrdBox.Text,out no)&&titlebox.Text!=""&&richTextBox1.Text!="")
            {

                bool caninsert = controllerObj.Retrieverepotitle(int.Parse(OrdBox.Text), titlebox.Text);
                if (!caninsert)
                {
                    MessageBox.Show("You complained for the same reason before , We will see your" +
                       "Report and Apply as soon as possible");

                    titlebox.Focus();
                    titlebox.SelectAll();
                    return;
                }
                int result = controllerPObj.InsertReport(int.Parse(OrdBox.Text), richTextBox1.Text, rssn, RorL, titlebox.Text);
                if (result == 0)
                {
                    MessageBox.Show("inValid Data");

                }
                else
                {
                    MessageBox.Show("your report is sumbitted successfully");
                }
            }
            else
                MessageBox.Show("unsufficient data");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel2.Visible = false;
            panel4.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int c;
            int lno;
            DateTime today = DateTime.Today;
            bool datechk = dateTimePicker2.Value.Date > today;
            if(int.TryParse(upnobox.Text,out lno)&&int.TryParse(upcostbox.Text,out c)&&datechk)
            {
                int result = controllerPObj.UpdateVehicle(lno, c, dateTimePicker2.Value.Date);
                if (result == 0)
                {
                    MessageBox.Show("Invalid Data");

                }
                else
                {
                    MessageBox.Show("you update vehicle successfully");
                }
            }
            else
            {
                if(!datechk)
                {
                    MessageBox.Show("put valid date");
                }
                MessageBox.Show("please insert date correctly");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel2.Visible = false;
            panel4.Visible = false;
            panel5.Visible = true;
            DataTable dt = controllerPObj.Show_Information(rssn);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void Renter_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Interface Form = new Interface();
            Form.Show();
            
        }
    }
}
