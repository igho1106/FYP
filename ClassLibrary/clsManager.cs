using System;


namespace ClassLibrary
{
    public class clsManager : User
    {

        
        //Manager Properties
        
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

        public string Valid(string firstName, string lastName, string gender, string emailAddress, string homeAddress, string DOB, string phoneNo, string careRequirement)
        {
            String Error = "";
            DateTime DOBTemp;

            //check the parameters 
            if (firstName.Length == 0)
            {
                //Record/Display error
                Error = Error + "FirstName field must not be left blank : ";
            }

            //if the first name is more than 25 characters long
            if (firstName.Length > 26)
            {
                //record the error 
                Error = Error + "FirstName must not be more than 25 characters";
            }

            //if lastName is blank
            if (lastName.Length == 0)
            {
                //record the error
                Error = Error + "LastName field must not be blank : ";
            }
            //if lastName is more than 25 characters long
            if (lastName.Length > 26)
            {
                //record the error 
                Error = Error + "LastName must not be more than 25 characters";
            }

            //if Gender is blank or less than 4 characters long
            if (gender.Length == 0)
            {
                //record the error
                Error = Error + "The Gender field must not be blank : ";
            }
            //if gender is more than 10 characters long
            if (gender.Length > 10)
            {
                //record the error 
                Error = Error + "Gender must not be more than 10 characters";
            }
            /*
            //if gender contains special characters
            if (gender.Contains("&^%$£?@<>~+"))
            {
                //record the error
                Error = Error + "Invalid Characters entered";

            }
            */

            //if emailAddress is blank or less than 9 characters
            if (emailAddress.Length < 9)
            {
                //record the error
                Error = Error + "The emailAddress field must not be blank : ";
            }
            //if emailAddress is more than 25 characters long
            if (emailAddress.Length > 51)
            {
                //record the error 
                Error = Error + "emailAddress must not be more than 50 characters";
            }

            //if phoneNo is blank or less than 11 digits
            if (phoneNo.Length < 11)
            {
                //record the error
                Error = Error + "The PhoneNo field must not be blank : ";
            }
            //if phoneNo is more than 7 digits long
            if (phoneNo.Length > 16)
            {
                //record the error 
                Error = Error + "PhoneNo must not be more than 16 characters";
            }

            //if homeAddress is blank
            if (homeAddress.Length < 10)
            {
                //record the error
                Error = Error + "The homeAddress field must not be blank : ";
            }
            //if homeAddress is more than 25 characters long
            if (homeAddress.Length > 51)
            {
                //record the error 
                Error = Error + "homeAddress must not be more than 51 characters";
            }


            try

            {
                //copy the DOB value to the DOBTemp variable
                DOBTemp = Convert.ToDateTime(DOB);
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
                Error = Error + "The date was not a valid date";
            }

            //return any error messages
            return Error;
        }
    }
}