using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    public partial class Employee : Form
    {
        ControllerP controllerObj;
        Controller  controllerObj1;

        public Employee()
        {
            InitializeComponent();
        }

        public void hidePanels()
        {
            panel2.Visible = false;
        }

        private void Show_Reports_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            controllerObj = new ControllerP();
            DataTable RSSN = controllerObj.SelectRenter_SSN();
            comboBox1.DataSource = RSSN;
            comboBox1.DisplayMember = "RSSN";
            comboBox1.ValueMember = "RSSN";
            DataTable LSSN = controllerObj.SelectLessor_SSN();
            comboBox2.DataSource = LSSN;
            comboBox2.DisplayMember = "LSSN";
            comboBox2.ValueMember = "LSSN";
            DataTable LicenceNo2 = controllerObj.Select_Licence_NO2();
            comboBox3.DataSource = LicenceNo2;
            comboBox3.DisplayMember = "LicenceNo";
            comboBox3.ValueMember = "LicenceNo";
            DataTable LicenceNo = controllerObj.Select_Licence_NO();
            comboBox4.DataSource = LicenceNo;
            comboBox4.DisplayMember = "LicenceNo";
            comboBox4.ValueMember = "LicenceNo";
            comboBox5.DataSource = LicenceNo;
            comboBox5.DisplayMember = "LicenceNo";
            comboBox5.ValueMember = "LicenceNo";
        }
       
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Show_Requests_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
            panel5.Visible = false;
        }


        private void Show_Click(object sender, EventArgs e)
        {
            controllerObj = new ControllerP();
            controllerObj1 = new Controller();
            // DataTable dt = controllerObj.SelectAllReports();
            DataTable dt = controllerObj1.Show_reports();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Please, select value");
            }

            Int32 RSSN;
            bool valid1 = Int32.TryParse(comboBox1.SelectedValue.ToString(), out RSSN);

            int r = controllerObj.Delete_Renter(RSSN);
            if (r > 0)
                MessageBox.Show("Deleted successfully");
            else
                MessageBox.Show("Failed");
        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Delete_Lessor_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "")
            {
                MessageBox.Show("Please, select value");
            }

            Int32 LSSN;
            bool valid1 = Int32.TryParse(comboBox1.SelectedValue.ToString(), out LSSN);

            int r = controllerObj.Delete_Lessor(LSSN);
            if (r > 0)
                MessageBox.Show("Deleted successfully");
            else
                MessageBox.Show("Failed");
        }

        private void Show_req_Click(object sender, EventArgs e)
        {
            controllerObj = new ControllerP();
            DataTable dt = controllerObj.get_renter_requests();
            dataGridView2.DataSource = dt;
            for (int i = 0; i < dataGridView2.Columns.Count; i++)
                if (dataGridView2.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dataGridView2.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    break;
                }
            //((DataGridViewImageColumn)dataGridView2.Columns[4]).ImageLayout = DataGridViewImageCellLayout.Stretch;
            //dataGridView2.Refresh();
            dataGridView2.Refresh();


        }

        private void Refuse_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                dataGridView2.Rows.RemoveAt(row.Index);
            }

            if (comboBox2.Text == "")
            {
                MessageBox.Show("Please, select value");
            }

            Int32 LicenceNO;
            bool valid1 = Int32.TryParse(comboBox3.SelectedValue.ToString(), out LicenceNO);

            int r = controllerObj.Delete_Request(LicenceNO);
            if (r > 0)
                MessageBox.Show("Deleted successfully");
            else
                MessageBox.Show("Failed");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        byte[] ConvertImageToBytes(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
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

        private void Accept_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView2.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView2.Rows[selectedrowindex];
                string model = Convert.ToString(selectedRow.Cells["Model"].Value);
                string type = Convert.ToString(selectedRow.Cells["Type"].Value);
                Int32 licenceno = Convert.ToInt32(selectedRow.Cells["LicenceNo"].Value);
                string vyear = Convert.ToString(selectedRow.Cells["Vyear"].Value);
                byte[] image = (byte[])selectedRow.Cells["Vimage"].Value;
                Int32 cost = Convert.ToInt32(selectedRow.Cells["Cost"].Value);
                string location = Convert.ToString(selectedRow.Cells["Location"].Value);
                string duration = Convert.ToString(selectedRow.Cells["Duration"].Value);
                Int32 rent_SSN = Convert.ToInt32(selectedRow.Cells["rent_SSN"].Value);
                char available = Convert.ToChar(selectedRow.Cells["available"].Value);
                int result = controllerObj.InsertVehicle2(model, type, licenceno, vyear, image, cost, location, duration, rent_SSN);
            }

            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                dataGridView2.Rows.RemoveAt(row.Index);
            }

            if (comboBox3.Text == "")
            {
                MessageBox.Show("Please, select value");
            }

            Int32 LicenceNO;
            bool valid1 = Int32.TryParse(comboBox3.SelectedValue.ToString(), out LicenceNO);

            int r = controllerObj.Delete_Request(LicenceNO);
            if (r > 0)
                MessageBox.Show("Inserted successfully");
            else
                MessageBox.Show("Failed");

        }

        private void Show_Cars_Click(object sender, EventArgs e)
        {
            controllerObj = new ControllerP();
            DataTable dt = controllerObj.get_vehicle();
            dataGridView3.DataSource = dt;
            dataGridView3.Refresh();
        }

        private void Update_Vehicle_Click(object sender, EventArgs e)
        {
            if (comboBox4.Text == "")
            {
                MessageBox.Show("Please, select value");
            }
            Int32 LicenceNO;
            bool valid1 = Int32.TryParse(comboBox4.SelectedValue.ToString(), out LicenceNO);

            int r = controllerObj.update_vehicle(LicenceNO);
            if (r > 0)
                MessageBox.Show("updated successfully");
            else
                MessageBox.Show("Failed");
        }

        private void Show_RVehicle_Click(object sender, EventArgs e)
        {
            controllerObj = new ControllerP();
            DataTable dt = controllerObj.get_vehicle2();
            dataGridView4.DataSource = dt;
            dataGridView4.Refresh();
        }

        private void Update_Renter_Vehicle_Click(object sender, EventArgs e)
        {
            if (comboBox5.Text == "")
            {
                MessageBox.Show("Please, select value");
            }
            Int32 LicenceNO;
            bool valid1 = Int32.TryParse(comboBox5.SelectedValue.ToString(), out LicenceNO);

            int r = controllerObj.update_vehicle2(LicenceNO);
            if (r > 0)
                MessageBox.Show("updated successfully");
            else
                MessageBox.Show("Failed");
        }

        private void Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Interface Form = new Interface();
            Form.Show();
        }
    }
}
