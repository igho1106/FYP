using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CaregiverTests
{
    [TestClass]
    //Caregiver test methods
    public class tstCaregiver
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCaregiver ACaregiver = new clsCaregiver();

            //Check to ensure that the class exists
            Assert.IsNotNull(ACaregiver);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsCaregiver ACaregiver = new clsCaregiver();
            //create a test-data to assign to the property
            Boolean TestData = true;
            //assign data to the property
            ACaregiver.Active = TestData;
            //Check to see that the both values are same
            Assert.AreEqual(ACaregiver.Active, TestData);
        }

        [TestMethod]
        public void CaregiverIDOK()
        {
            //create an instance of the class we want to create
            clsCaregiver ACaregiver = new clsCaregiver();
            //create a test data to assign to the property
            int TestData = 1;
            //assign data to the property
            ACaregiver.UserID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACaregiver.UserID, TestData);
        }

        [TestMethod]
        public void DOBPropertyOK()
        {
            //create an instance of the class we want to create
            clsCaregiver ACaregiver = new clsCaregiver();
            //create a test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign data to the property
            ACaregiver.DOB = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACaregiver.DOB, TestData);
        }

        [TestMethod]
        public void EmailAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsCaregiver ACaregiver = new clsCaregiver();
            //create a test data to assign to the property
            string TestData = "abc1@yahoo.com";
            //assign data to the property
            ACaregiver.EmailAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACaregiver.EmailAddress, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCaregiver ACaregiver = new clsCaregiver();
            //create a test data to assign to the property
            string TestData = "John";
            //assign data to the property
            ACaregiver.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACaregiver.FirstName, TestData);
        }

        [TestMethod]
        public void LastNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCaregiver ACaregiver = new clsCaregiver();
            //create a test data to assign to the property
            string TestData = "Doe";
            //assign data to the property
            ACaregiver.LastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACaregiver.LastName, TestData);
        }

        [TestMethod]
        public void GenderPropertyOK()
        {
            //create an instance of the class we want to create
            clsCaregiver ACaregiver = new clsCaregiver();
            //create a test data to assign to the property
            string TestData = "M";
            //assign data to the property
            ACaregiver.Gender = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACaregiver.Gender, TestData);
        }

        [TestMethod]
        public void HomeAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsCaregiver ACaregiver = new clsCaregiver();
            //create a test data to assign to the property
            string TestData = "6 Cavendish Mews";
            //assign data to the property
            ACaregiver.HomeAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACaregiver.HomeAddress, TestData);
        }

        [TestMethod]
        public void PhoneNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCaregiver ACaregiver = new clsCaregiver();
            //create a test data to assign to the property
            string TestData = "0123456789";
            //assign data to the property
            ACaregiver.PhoneNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACaregiver.PhoneNo, TestData);
        }

        //END OF CAREGIVER PROPERTIES TEST METHODS
    }
}
