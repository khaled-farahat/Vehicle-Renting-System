using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
namespace DataBase
{
    class Validation
    {
        DBManager dbMan;

        // NOTE --> checks only valid characters, (@ % $ , . ^ ...etc not valid)
        public bool validateString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("INVALID NAME");
                return false;
            }
            for (int i = 0; i < input.Length; i++)
            {
                if ((int)(input[i]) == 32)      // this character is space
                    continue;

                if ((int)(input[i]) < 33 || (int)(input[i]) > 122) //  characters
                {
                    MessageBox.Show("INVALID NAME");
                    return false;
                }
            }
            return true;
        }

        public bool validatePositiveNumber(string input)
        {

            // check if empty
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("INVALID SSN");
                return false;
            }
            // check if -ve
            if (input[0] == '-')
            {
                MessageBox.Show("INVALID SSN");
                return false;
            }

            // check numbers
            for (int i = 0; i < input.Length; i++)
            {
                if ((int)(input[i]) < 48 || (int)(input[i]) > 57)
                {
                    MessageBox.Show("INVALID SSN NUMBER");
                    return false;
                }
            }
            return true;
        }
        public bool _validateRenterPhoneExist(string phone_num)
        {
            dbMan = new DBManager();
            string query = "Select RSSN From Renter Where RPhone_no='" + phone_num + "';";
            if (dbMan.ExecuteReader(query) != null)
                return true;
            else
            {
                MessageBox.Show("Phone Number is Invalid");
                return false;
            }
        }
        public bool _validateRenterPassword(string phone_num,string Pass)
        {
            dbMan = new DBManager();
            string query = "Select RSSN From Renter Where RPhone_no='" + phone_num + "' AND RPassword = '" + Pass + "'; ";
            if (dbMan.ExecuteReader(query) != null)
                return true;
            else
            {
                MessageBox.Show("Password is INVALID");
                return false;
            }
        }
        public bool _validateEmployeePhoneExist(string phone_num)
        {
            dbMan = new DBManager();
            string query = "Select ESSN From Employee Where EmpPhone_no='" + phone_num + "';";
            if (dbMan.ExecuteReader(query) != null)
                return true;
            else
            {
                MessageBox.Show("Phone Number is Invalid");
                return false;
            }
        }
        public bool _validateEmployeePassword(string phone_num, string Pass)
        {
            dbMan = new DBManager();
            string query = "Select ESSN From Employee Where EmpPhone_no='" + phone_num + "' AND EmPPassword = '" + Pass + "'; ";
            if (dbMan.ExecuteReader(query) != null)
                return true;
            else
            {
                MessageBox.Show("Password is INVALID");
                return false;
            }
        }
        public bool _validateLessorPhoneExist(string phone_num)
        {
            dbMan = new DBManager();
            string query = "Select LSSN From Lessor Where LPhone_no='" + phone_num + "';";
            if (dbMan.ExecuteReader(query) != null)
                return true;
            else
            {
                MessageBox.Show("Phone Number is Invalid");
                return false;
            }
        }
        public bool _validateLessorPassword(string phone_num, string Pass)
        {
            dbMan = new DBManager();
            string query = "Select LSSN From Lessor Where LPhone_no='" + phone_num + "' AND LPassword = '" + Pass + "'; ";
            if (dbMan.ExecuteReader(query) != null)
                return true;
            else
            {
                MessageBox.Show("Password is INVALID");
                return false;
            }
        }

        public bool _validatePassword(string password)
        {
            if (password == "")
            {
                MessageBox.Show("Password is required");
                return false;
            }
            int length = password.Length;
            if (length < 8)
            {
                MessageBox.Show("Password is too short");
                return false;
            }

            return true;
        }

        public bool validateNumberRange(decimal number, int start, int end)
        {
            return number >= start && number <= end;
        }


        //  Function to check for any phone number
        public bool Check_Phone_Number(string phone_number)
        {
            int length = phone_number.Length;
            //Validations for the number
            if (phone_number == "" || phone_number == null)
            {
                MessageBox.Show("Empty phone Number ERROR");
                return false;
            }
            else if (length != 11)
            {
                MessageBox.Show("INVALID PHONE NUMBER");
                return false;
            }

            string ff = phone_number;
            bool vv = false;
            for (int i = 0; i < ff.Length; i++)
            {
                if (ff[i] == '0' || ff[i] == '1' || ff[i] == '2' || ff[i] == '3' || ff[i] == '4' || ff[i] == '5' || ff[i] == '6' || ff[i] == '7' || ff[i] == '8' || ff[i] == '9')
                    continue;
                else
                {
                    vv = true;
                    break;
                }
            }

            if (vv)
            {
                MessageBox.Show("INVALID PHONE NUMBER");
                return false;
            }
            else
                return true;

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
    }
}
