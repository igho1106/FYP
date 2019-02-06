using System;

namespace ClassLibrary
{
    public class clsClient : User
    {
        //Client Properties
      
        //private data member for the PhoneNo property
        private string mCareRequirement;

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

    }
}