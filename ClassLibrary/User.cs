using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class User
    {
        //Manager Properties
        public bool Active { get; set; }


        //private data member for the ManagerID property
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

        public string FirstNameValid(string firstName)
        {
            String Error = "";           

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
            //if lastName is more than 25 characters long
            if (lastName.Length > 26)
            {
                //record the error 
                Error = Error + "LastName must not be more than 25 characters";
            }
            return Error;
        }


    }
}
