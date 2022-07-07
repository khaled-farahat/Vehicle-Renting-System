using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DataBase
{
    public class ControllerP
    {
        DBManagerPROC dbManp;
        public ControllerP()
        {
            dbManp = new DBManagerPROC();
        }

        public int InsertVehicle(string Model, string Type, int LicenceNo, string Vyear, byte[] Vimage, int Cost, string Location, DateTime Duration, int rent_SSN)
        {

            string StoredProcedureName = StoredProcedures.InsertVehicle;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Model", Model);
            Parameters.Add("@Type", Type);
            Parameters.Add("@LicenceNo", LicenceNo);
            Parameters.Add("@Vyear", Vyear);
            Parameters.Add("@Vimage", Vimage);
            Parameters.Add("@Cost", Cost);
            Parameters.Add("@Location", Location);
            Parameters.Add("@Duration", Duration);
            Parameters.Add("@rent_SSN", rent_SSN);
            return dbManp.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertReport(int OrderNo, string Data, int RepoSSN, char RorL, string ReportTitle)
        {

            string StoredProcedureName = StoredProcedures.InsertReport;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@OrderNo", OrderNo);
            Parameters.Add("@Data", Data);
            Parameters.Add("@RepoSSN", RepoSSN);
            Parameters.Add("@RorL", RorL);
            Parameters.Add("@ReportTitle", ReportTitle);
            return dbManp.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int UpdateVehicle(int licenceNo,  int Cost, DateTime Duration)
        {

            string StoredProcedureName = StoredProcedures.UpadteVehicle;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@licenceNo", licenceNo);
            Parameters.Add("@Cost", Cost);
            Parameters.Add("@Duration", Duration);
            return dbManp.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable Show_Information(int RSSN)
        {
            string StoredProcedureName = StoredProcedures.ShowInformations;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@RSSN", RSSN);
            return dbManp.ExecuteReader(StoredProcedureName, Parameters);


        }

        public DataTable check_vehicle(int LicenceNo)
        {
            string StoredProcedureName = StoredProcedures.CHECK_VEHICLE;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@LicenceNo", LicenceNo);
            return dbManp.ExecuteReader(StoredProcedureName, Parameters);


        }


        public DataTable SelectAllReports()
        {
            string StoredProcedureName = StoredProcedures.SelectAllReports;
            return dbManp.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable SelectRenter_SSN()
        {
            string StoredProcedureName = StoredProcedures.SelectRenter_SSN;
            return dbManp.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable SelectLessor_SSN()
        {
            string StoredProcedureName = StoredProcedures.SelectLessor_SSN;
            return dbManp.ExecuteReader(StoredProcedureName, null);
        }

        public int Delete_Renter(Int32 RSSN)
        {
            string StoredProcedureName = StoredProcedures.Delete_Renter;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@RSSN", RSSN);
            return dbManp.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int Delete_Lessor(Int32 LSSN)
        {
            string StoredProcedureName = StoredProcedures.Delete_Lessor;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@LSSN", LSSN);
            return dbManp.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable get_renter_requests()
        {
            string StoredProcedureName = StoredProcedures.get_renter_requests;
            return dbManp.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable get_vehicle()
        {
            string StoredProcedureName = StoredProcedures.Select_vehicle;
            return dbManp.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable get_vehicle2()
        {
            string StoredProcedureName = StoredProcedures.Select_vehicle2;
            return dbManp.ExecuteReader(StoredProcedureName, null);
        }

        public int update_vehicle(Int32 LicenceNo)
        {
            string StoredProcedureName = StoredProcedures.update_vehicle;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Licence_no", LicenceNo);
            return dbManp.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int update_vehicle2(Int32 LicenceNo)
        {
            string StoredProcedureName = StoredProcedures.update_vehicle2;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Licence_no", LicenceNo);
            return dbManp.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int InsertVehicle2(string Model, string Type, Int32 LicenceNo, string Vyear, byte[] Vimage, Int32 Cost, string Location, string Duration, Int32 rent_SSN)
        {
            //byte[] Vimage = Encoding.ASCII.GetBytes(image);
            string StoredProcedureName = StoredProcedures.InsertVehicle2;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Model", Model);
            Parameters.Add("@Type", Type);
            Parameters.Add("@LicenceNo", LicenceNo);
            Parameters.Add("@Vyear", Vyear);
            Parameters.Add("@Vimage", Vimage);
            Parameters.Add("@Cost", Cost);
            Parameters.Add("@Location", Location);
            Parameters.Add("@Duration", Duration);
            Parameters.Add("@rent_SSN", rent_SSN);
            return dbManp.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int Delete_Request(Int32 LicenceNO)
        {
            string StoredProcedureName = StoredProcedures.Delete_Request;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Licence_NO", LicenceNO);
            return dbManp.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable Select_Licence_NO()
        {
            string StoredProcedureName = StoredProcedures.Select_Licence_NO;
            return dbManp.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable Select_Licence_NO2()
        {
            string StoredProcedureName = StoredProcedures.Select_Licence_NO2;
            return dbManp.ExecuteReader(StoredProcedureName, null);
        }
    }
}
