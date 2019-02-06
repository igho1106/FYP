using System;

namespace ClassLibrary
{
    public class clsClient : User
    {
        //Client Properties
      
        //private data member for the PhoneNo property
        private string mCareRequirements;

        public string CareRequirement
        {
            get
            {
                //return the private data
                return mCareRequirements;
            }
            set
            {
                //set the value of the private data member
                mCareRequirements = value;
            }
        }

    }
}