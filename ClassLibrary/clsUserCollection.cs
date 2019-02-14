using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsUserCollection
    {
        //private data member thisCustomer
        clsUser mThisUser = new clsUser();

        //private data member for the list
        List<clsUser> mUserList = new List<clsUser>();
        public List<clsUser> UserList
        {
            get
            { //return the private data
                return mUserList;
            }
            set
            {
                //set the private data
                mUserList = value;
            }
        }
        public clsUser ThisUser
        {
            get
            {
                //return the private data
                return mThisUser;
            }
            set
            {
                //set the private data
                mThisUser = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mUserList.Count;
            }
            set
            {
                //TBC
            }
        }

        //constructor for the class
        public clsUserCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblUser_SelectALL");
            //populate the array list with the data table
            PopulateArray(DB);

        }



        public int AddUserMethod()
        {
            //adds a new recoord to the dayanase basaed on the values of mThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure

            DB.AddParameter("@FirstName", mThisUser.FirstName);
            DB.AddParameter("@LastName", mThisUser.LastName);
            DB.AddParameter("@Gender", mThisUser.Gender);
            DB.AddParameter("@EmailAddress", mThisUser.EmailAddress);
            DB.AddParameter("@HomeAddress", mThisUser.HomeAddress);
            DB.AddParameter("@DOB", mThisUser.DOB);
            DB.AddParameter("@PhoneNo", mThisUser.PhoneNo);
            

            //execute query to return the primary key value
            return DB.Execute("sproc_tblUser_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@UserID", mThisUser.UserID);
            //execute the stored procedure
            DB.Execute("sproc_tblUser_Delete");
        }


        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mUserList = new List<clsUser>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsUser AUser = new clsUser();
                //read in the fields from the current record

                AUser.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AUser.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AUser.Gender = Convert.ToString(DB.DataTable.Rows[Index]["Gender"]);
                AUser.EmailAddress = Convert.ToString(DB.DataTable.Rows[Index]["EmailAddress"]);
                AUser.HomeAddress = Convert.ToString(DB.DataTable.Rows[Index]["HomeAddress"]);
                AUser.DOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["DOB"]);
                AUser.PhoneNo = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNo"]);
                
                //add the record to the private data mamber
                mUserList.Add(AUser);
                //point at the next record
                Index++;
            }

        }

        public void FilterByEmailAddress(string EmailAddress)
        {
            //TBC
            return;
        }
    }
}