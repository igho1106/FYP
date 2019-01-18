using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CaregiverTests
{
    [TestClass]
    //Manager test methods
    public class tstManager
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsManager AManager = new clsManager();

            //Check to ensure that the class exists
            Assert.IsNotNull(AManager);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create a test-data to assign to the property
            Boolean TestData = true;
            //assign data to the property
            AManager.Active = TestData;
            //Check to see that the both values are same
            Assert.AreEqual(AManager.Active, TestData);
        }

      
        [TestMethod]
        public void ManagerIDOK()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create a test data to assign to the property
            int TestData = 1;
            //assign data to the property
            AManager.ManagerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AManager.ManagerID, TestData);
        }

        [TestMethod]
        public void DOBPropertyOK()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create a test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign data to the property
            AManager.DOB = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AManager.DOB, TestData);
        }

        [TestMethod]
        public void EmailAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create a test data to assign to the property
            string TestData = "abc1@yahoo.com";
            //assign data to the property
            AManager.EmailAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AManager.EmailAddress, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create a test data to assign to the property
            string TestData = "John";
            //assign data to the property
            AManager.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AManager.FirstName, TestData);
        }

        [TestMethod]
        public void LastNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create a test data to assign to the property
            string TestData = "Doe";
            //assign data to the property
            AManager.LastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AManager.LastName, TestData);
        }


        [TestMethod]
        public void GenderPropertyOK()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create a test data to assign to the property
            string TestData = "M";
            //assign data to the property
            AManager.Gender = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AManager.Gender, TestData);
        }

        [TestMethod]
        public void HomeAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create a test data to assign to the property
            string TestData = "6 Cavendish Mews";
            //assign data to the property
            AManager.HomeAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AManager.HomeAddress, TestData);
        }

        [TestMethod]
        public void PhoneNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create a test data to assign to the property
            string TestData = "0123456789";
            //assign data to the property
            AManager.PhoneNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AManager.PhoneNo, TestData);
        }

        //END OF MANAGER PROPERTIES TEST METHODS
    }
}
