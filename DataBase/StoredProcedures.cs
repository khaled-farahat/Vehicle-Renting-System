using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class StoredProcedures
    {
        public static string InsertVehicle = "insertVehicle";
        public static string InsertVehicle2 = "insertVehicle2";
        public static string InsertReport = "insertReport";
        public static string UpadteVehicle = "UpdateVehicle";
        public static string ShowInformations = "ShowInformations";
        public static string CHECK_VEHICLE = "CHECK_VEHICLE";
        public static string SelectAllReports = "getAllReports";
        public static string SelectRenter_SSN = "getRenterSSN";
        public static string SelectLessor_SSN = "getLessorSSN";
        public static string Delete_Renter = "DeleteRenter";
        public static string Delete_Lessor = "DeleteLessor";

        public static string get_renter_requests = "get_renter_requests";
        public static string Select_Licence_NO = "Select_Licence_NO";
        public static string Select_Licence_NO2 = "Select_Licence_NO2";
        public static string Delete_Request = "DeleteRequest";
        public static string Select_vehicle = "Select_vehicle";
        public static string update_vehicle = "update_vehicle";
        public static string Select_vehicle2 = "Select_vehicle2";
        public static string update_vehicle2 = "update_vehicle2";
    }
}
