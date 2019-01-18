using System;

namespace ClassLibrary
{
    public class clsCaregiver
    {
        //Caregiver Properties
        public bool Active { get; set; }
        public int CaregiverID { get; set; }
        public DateTime DOB { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string HomeAddress { get; set; }
        public string PhoneNo { get; set; }
    }
}