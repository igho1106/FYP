using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsUser
    {
        //private data member for the list
      
      


        //private data member for the UserID property
        private int mUserID;
        //private data member for the DOB property
        private DateTime mDOB;
        //private data member for the EmailAddress property
        private string mEmailAddress;
        //private data member for the FirstName property
        private string mFirstName;
        //private data member for the LastName property
        private string mLastName;
        //private data member for the Gender property
        private string mGender;
        //private data member for the HomeAddress property
        private string mHomeAddress;
        //private data member for the PhoneNo property
        private string mPhoneNo;

        //private data member for the CareRequirement
        private string mCareRequirement;

        //private data member for the Role
        private int mRole;



        public int UserID
        {
            get
            {
                //return the private data
                return mUserID;
            }
            set
            {
                //set the value of the private data member
                mUserID = value;
            }
        }


        public DateTime DOB
        {
            get
            {
                //return the private data
                return mDOB;
            }
            set
            {
                //set the value of the private data member
                mDOB = value;
            }
        }


        public string EmailAddress
        {
            get
            {
                //return the private data
                return mEmailAddress;
            }
            set
            {
                //set the value of the private data member
                mEmailAddress = value;
            }
        }


        public string FirstName
        {
            get
            {
                //return the private data
                return mFirstName;
            }
            set
            {
                //set the value of the private data member
                mFirstName = value;
            }
        }

        public string LastName
        {
            get
            {
                //return the private data
                return mLastName;
            }
            set
            {
                //set the value of the private data member
                mLastName = value;
            }
        }


        public string Gender
        {
            get
            {
                //return the private data
                return mGender;
            }
            set
            {
                //set the value of the private data member
                mGender = value;
            }
        }

        public string HomeAddress
        {
            get
            {
                //return the private data
                return mHomeAddress;
            }
            set
            {
                //set the value of the private data member
                mHomeAddress = value;
            }
        }

        public string PhoneNo
        {
            get
            {
                //return the private data
                return mPhoneNo;
            }
            set
            {
                //set the value of the private data member
                mPhoneNo = value;
            }
        }

        public string CareRequirement
        {
            get
            {
                //return the private data
                return mCareRequirement;
            }
            set
            {
                //set the value of the private data member
                mCareRequirement = value;
            }
        }

        public int Role
        {
            get
            {
                //return the private data
                return mRole;
            }
            set
            {
                //set the value of the private data member
                mRole = value;
            }
        }


        //USER VALIDATION
        public string FirstNameValid(string firstName)
        {
            String Error = "";

            //check the parameters 
            if (firstName.Length == 0)
            {
                //Record/Display error
                Error = Error + "FirstName field must not be left blank : ";
            }

            //if the first name is more than 50 characters long
            if (firstName.Length > 50)
            {
                //record the error 
                Error = Error + "FirstName must not be more than 50 characters";
            }

            //if gender contains special characters
            //if (firstName.Contains("&^%$£?@<>~+"))
            //{
            //    //record the error
            //    Error = Error + "Invalid Characters entered";

            //}

            return Error;
        }

        public string LastNameValid(string lastName)
        {

            String Error = "";

            //check the parameters 
            if (lastName.Length == 0)
            {
                //record the error
                Error = Error + "LastName field must not be blank : ";
            }
            //if lastName is more than 50 characters long
            if (lastName.Length > 50)
            {
                //record the error 
                Error = Error + "LastName must not be more than 50 characters";
            }
            return Error;
        }

        public string GenderValid(string gender)
        {
            String Error = "";

            //check the parameters
            //if Gender is blank 
            if (gender.Length == 0)
            {
                //record the error
                Error = Error + "The Gender field must not be blank : ";
            }
            //if gender is more than 25 characters long
            if (gender.Length > 25)
            {
                //record the error 
                Error = Error + "Gender must not be more than 25 characters";
            }
            return Error;
        }

        public string EmailAddressValid(string emailAddress)
        {
            String Error = "";
            //if emailAddress is blank or less than 9 characters
            if (emailAddress.Length < 9)
            {
                //record the error
                Error = Error + "The emailAddress field must not be blank : ";
            }
            //if emailAddress is more than 25 characters long
            if (emailAddress.Length > 50)
            {
                //record the error 
                Error = Error + "emailAddress must not be more than 50 characters";
            }
            return Error;
        }

        public string PhoneNoValid(string phoneNo)
        {
            String Error = "";

            //if phoneNo is blank or less than 11 digits
            if (phoneNo.Length < 11)
            {
                //record the error
                Error = Error + "The PhoneNo field must not be blank : ";
            }
            //if phoneNo is more than 7 digits long
            if (phoneNo.Length > 11)
            {
                //record the error 
                Error = Error + "PhoneNo must not be more than 16 characters";
            }
            return Error;
        }

        public string HomeAddressValid(string homeAddress)
        {
            String Error = "";

            //if homeAddress is blank
            if (homeAddress.Length < 10)
            {
                //record the error
                Error = Error + "The homeAddress field must not be blank : ";
            }
            //if homeAddress is more than 25 characters long
            if (homeAddress.Length > 50)
            {
                //record the error 
                Error = Error + "homeAddress must not be more than 51 characters";
            }
            return Error;
        }


        public string DOBValid(DateTime dOB)
        {
            String Error = "";
            DateTime DOBTemp;
            try

            {
                //copy the DOB value to the DOBTemp variable
                DOBTemp = Convert.ToDateTime(dOB);
                //check to see if DOB is less than 18 years from today
                if (DOBTemp > DateTime.Now.AddYears(-18))
                {
                    //record the error
                    Error = Error + "You must be 18 years or above to use this system : ";
                }
                //check to see if DOB is more than 200 years from current date
                if (DOBTemp > DateTime.Now.AddYears(200))
                {
                    //record the error
                    Error = Error + "Please enter a valid DateOfBirth : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date entered was not a valid date";
            }

            //return any error messages
            return Error;
        }


        //private 
        public bool Find(int UserID)
        {
            clsClient client = new clsClient();
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the user id to search for
            DB.AddParameter("UserID", UserID);
            //execute the stored procedure
            DB.Execute("sproc_tblUser_FilterByUserID");
            //if one record is found there should be either one or zero!
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                UserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                FirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                LastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                Gender = Convert.ToString(DB.DataTable.Rows[0]["Gender"]);
                EmailAddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                HomeAddress = Convert.ToString(DB.DataTable.Rows[0]["HomeAddress"]);
                DOB = Convert.ToDateTime(DB.DataTable.Rows[0]["DOB"]);
                PhoneNo = Convert.ToString(DB.DataTable.Rows[0]["PhoneNo"]);
                client.CareRequirement = Convert.ToString(DB.DataTable.Rows[0]["CareRequirements"]);
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }


        }

    }
}
