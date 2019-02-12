using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CaregiverTests
{
    [TestClass]
    //Staff test methods
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff AStaff = new clsStaff();

            //Check to ensure that the class exists
            Assert.IsNotNull(AStaff);
        }        

   

        //END OF STAFF PROPERTY TEST METHODS

        [TestMethod]
        public void FindMethodOK()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            int UserID = 1;
            Found = AStaff.Find(UserID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserFirstNameFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            int UserID = 1;
            Found = AStaff.Find(UserID);

            if (AStaff.FirstName != "Igho")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        public void TestUserLastNameFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            int UserID = 1;
            Found = AStaff.Find(UserID);

            if (AStaff.FirstName != "Akponah")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        public void TestUserGenderFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            int UserID = 1;
            Found = AStaff.Find(UserID);

            if (AStaff.FirstName != "Male")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestUserPhoneNoFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            int CustomerID = 1;
            Found = AStaff.Find(CustomerID);

            if (AStaff.PhoneNo != "07397924314")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestUserHomeAddressFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            int CustomerID = 1;
            Found = AStaff.Find(CustomerID);

            if (AStaff.HomeAddress != "6 Cavendish Mews")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestUserEmailAddressFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            int CustomerID = 1;
            Found = AStaff.Find(CustomerID);

            if (AStaff.EmailAddress != "ighoakponah@123.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestUserDOBFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            int CustomerID = 1;
            Found = AStaff.Find(CustomerID);

            if (AStaff.DOB != Convert.ToDateTime("11/06/1989"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}
