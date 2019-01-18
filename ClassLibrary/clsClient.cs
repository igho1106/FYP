using System;

namespace ClassLibrary
{
    public class clsClient
    {
        //Client Properties
        public bool Active { get; set; }
        public int ManagerID { get; set; }
        public DateTime DOB { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string HomeAddress { get; set; }
        public string CareRequirement { get; set; }
    }
}