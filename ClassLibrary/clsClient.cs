using System;

namespace ClassLibrary
{
    public class clsClient : clsUser
    {
        //Client Properties
      
        //private data member for the PhoneNo property
        private string mCareRequirements;

        public new string CareRequirement
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