using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DataBase
{
    class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();

        }

        public int insertLessor(string s1, string s2, string s3, string s4, string s5, string s6)
        {
            string query = "insert into Lessor (LFname,LMinint,LLname,LSSN,LPhone_no,LPassword) values('" + s1 + "', '" + s2 + "', '" + s3 + "', '" + s4 + "', '" + s5 + "','" + s6 + "'); ";
            return dbMan.ExecuteNonQuery(query);

        }
        public int insertEmployee(string s1, string s2, string s3, string s4, string s5, string s6, string s7, char s8,string s9)
        {
            string query = "insert into Employee (Fname,Minint,Lname,ESSN,EmpPhone_no,EmPPassword,EmpAddress,gender,salary) values('" + s1 + "', '" + s2 + "', '" + s3 + "', '" + s4 + "', '" + s5 + "','" + s6 + "','" + s7 + "','" + s8 + "','" + s9 + "'); ";
            return dbMan.ExecuteNonQuery(query);

        }
        public int insertRenter(string s1, string s2, string s3, string s4, string s5, string s6)
        {
            string query = "insert into Renter (RFname,RMinint,RLname,RSSN,RPhone_no,RPassword) values('" + s1 + "', '" + s2 + "', '" + s3 + "', '" + s4 + "', '" + s5 + "','" + s6 + "'); ";
            return dbMan.ExecuteNonQuery(query);

        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
        public int RetrieveLessorSSN(string Phone)
        {
            string q = "select LSSN from Lessor where LPhone_no = " + Phone;
            return (int)dbMan.ExecuteScalar(q);
        }
        public int RetrieveRenterSSN(string Phone)
        {
            string q = "select RSSN from Renter where RPhone_no = " + Phone;
            return (int)dbMan.ExecuteScalar(q);
        }

        public int RetrievevehicleNo(int LSSN)
        {
            string q = "select Vno from LessorVehicle where Less_SSN = " + LSSN;
            return (int)dbMan.ExecuteScalar(q);
        }
        public int RetrieveorderNo(int orderno)
        {
            string q = "select Order_No from LessorVehicle where Less_SSN = " + orderno;
            return (int)dbMan.ExecuteScalar(q);
        }
        public DataTable RetrieveLessorVehicle()
        {
            string q = "select Order_No from LessorVehicle";
            return dbMan.ExecuteReader(q);
        }

        public DataTable Retrievevehicle(string type, string range)
        {
            long upperrange;
            int lowerrange;
            if (type == "Car")
            {
                if (range == "Between 300,400 EGP per day")
                {
                    upperrange = 400;
                    lowerrange = 300;
                }
                else if (range == "Between 400,500 EGP per day")
                {
                    upperrange = 500;
                    lowerrange = 400;
                }
                else
                {
                    upperrange = 9999999999999;
                    lowerrange = 500;
                }
            }
            else if (type == "Ship")
            {
                if (range == "Between 20000,22000$ per day") 
                {
                    upperrange = 22000;
                    lowerrange = 20000; 
                }
                else if (range == "Between 22000,25000$ per day")
                {
                    upperrange = 25000; 
                    lowerrange = 22000;
                }
                else
                {
                    upperrange = 9999999999999;
                    lowerrange = 25000;
                }
            }
            else
            {
                if (range == "Between 50,100 EGP per day")
                {
                    upperrange = 100;
                    lowerrange = 50;
                }
                else if (range == "Between 100,200 EGP per day")
                {
                    upperrange = 200;
                    lowerrange = 100;
                }
                else
                {
                    upperrange = 9999999999999;
                    lowerrange = 200;
                }
            }
            string q = "select * from Vehicle where Type = '" + type + "' and Cost >= " + lowerrange
                + " and Cost <= " + upperrange + " and available='1'";
            return dbMan.ExecuteReader(q);
        }
        public bool Retrieverepotitle(int orderno, string repotitle)
        {

            string q = "select ReportTitle from Report where OrderNo = " + orderno;
            DataTable dt = dbMan.ExecuteReader(q);
            if (dt == null)
                return true;

            foreach (DataRow r in dt.Rows)
                if (r["ReportTitle"].ToString() == repotitle.ToLower())
                    return false;
            return true;

        }
        public int insertLessorReport(int orderno, string repotitle, string Data, int RepoSSN)
        {

            string q = "insert into Report values (" + orderno + ",'" + Data + "'," + RepoSSN + ",'L','" + repotitle + "')";
            return dbMan.ExecuteNonQuery(q);
        }
        public int LessAVehicle(int LSSN, int orderno, int Vno, DateTime dur, DateTime startdate)
        {

            string q = "insert into LessorVehicle values (" + LSSN + "," + Vno + ","
                + orderno + ",'" + dur + "','" + startdate + "')";
            return dbMan.ExecuteNonQuery(q);
        }
        public int updateVehicleavailability(int Vno)
        {

            string q = "update Vehicle set available='0' where LicenceNo = " + Vno;
            return dbMan.ExecuteNonQuery(q);
        }

        public int changepasswordEMP(string pass, string phonenum)
        {
            string query = "UPDATE Employee SET EmPPassword = '" + pass + "' WHERE EmpPhone_no = '" + phonenum + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int changepasswordRenter(string pass, string phonenum)
        {
            string query = "UPDATE Renter SET RPassword = '" + pass + "' WHERE RPhone_no = '" + phonenum + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int changepasswordLessor(string pass, string phonenum)
        {
            string query = "UPDATE Lessor SET LPassword = '" + pass + "' WHERE LPhone_no = '" + phonenum + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public bool _validateAdmin(string phone_num, string Pass)
        {
            dbMan = new DBManager();
            string query = "Select ESSN From Employee Where EmpPhone_no='" + phone_num + "' AND EmPPassword = '" + Pass + "'; ";
            if (dbMan.ExecuteReader(query) != null)
                return true;
            else
            {
                MessageBox.Show("Check Phone Number AND Password");
                return false;
            }
        }

        public DataTable Show_reports()
        {
            string query = "select distinct RepoSSN AS Reporter ,RorL as User_Type, Data,OrderNo, rent_SSN as Reporting   from Report, LessorVehicle, Vehicle Where Report.OrderNo = LessorVehicle.Order_No AND Vno = Vehicle.LicenceNo AND RorL = 'L' UNION select distinct RepoSSN  ,RorL as User_Type , Data, OrderNo, Less_SSN from Report, LessorVehicle  where Report.OrderNo = LessorVehicle.Order_No AND RorL = 'R'";
            return dbMan.ExecuteReader(query);
        }

    }
}
