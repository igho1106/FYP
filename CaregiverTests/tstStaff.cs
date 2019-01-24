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

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a test-data to assign to the property
            Boolean TestData = true;
            //assign data to the property
            AStaff.Active = TestData;
            //Check to see that the both values are same
            Assert.AreEqual(AStaff.Active, TestData);
        }

        [TestMethod]
        public void StaffIDOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a test data to assign to the property
            int TestData = 1;
            //assign data to the property
            AStaff.StaffID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffID, TestData);
        }

        [TestMethod]
        public void DOBPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign data to the property
            AStaff.DOB = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.DOB, TestData);
        }

        [TestMethod]
        public void EmailAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a test data to assign to the property
            string TestData = "abc1@yahoo.com";
            //assign data to the property
            AStaff.EmailAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.EmailAddress, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a test data to assign to the property
            string TestData = "John";
            //assign data to the property
            AStaff.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.FirstName, TestData);
        }

        [TestMethod]
        public void LastNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a test data to assign to the property
            string TestData = "Doe";
            //assign data to the property
            AStaff.LastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.LastName, TestData);
        }

        [TestMethod]
        public void GenderPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a test data to assign to the property
            string TestData = "M";
            //assign data to the property
            AStaff.Gender = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Gender, TestData);
        }

        [TestMethod]
        public void HomeAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a test data to assign to the property
            string TestData = "6 Cavendish Mews";
            //assign data to the property
            AStaff.HomeAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.HomeAddress, TestData);
        }

        [TestMethod]
        public void PhoneNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create a test data to assign to the property
            string TestData = "0123456789";
            //assign data to the property
            AStaff.PhoneNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.PhoneNo, TestData);
        }

        //END OF STAFF PROPERTY TEST METHODS
    }
}
