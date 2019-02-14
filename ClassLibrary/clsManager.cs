using System;


namespace ClassLibrary
{
    public class clsManager : clsUser
    {


        //Manager Methods


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