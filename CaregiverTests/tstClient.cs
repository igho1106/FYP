using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CaregiverTests
{
    [TestClass]
    public class tstClient
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsClient AClient = new clsClient();

            //Check to ensure that the class exists
            Assert.IsNotNull(AClient);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //create a test-data to assign to the property
            Boolean TestData = true;
            //assign data to the property
            AClient.Active = TestData;
            //Check to see that the both values are same
            Assert.AreEqual(AClient.Active, TestData);
        }


        [TestMethod]
        public void ClientIDOK()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //create a test data to assign to the property
            int TestData = 1;
            //assign data to the property
            AClient.ClientID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AClient.ClientID, TestData);
        }

        [TestMethod]
        public void DOBPropertyOK()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //create a test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign data to the property
            AClient.DOB = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AClient.DOB, TestData);
        }

        [TestMethod]
        public void EmailAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //create a test data to assign to the property
            string TestData = "abc1@yahoo.com";
            //assign data to the property
            AClient.EmailAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AClient.EmailAddress, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //create a test data to assign to the property
            string TestData = "John";
            //assign data to the property
            AClient.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AClient.FirstName, TestData);
        }

        [TestMethod]
        public void LastNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //create a test data to assign to the property
            string TestData = "Doe";
            //assign data to the property
            AClient.LastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AClient.LastName, TestData);
        }


        [TestMethod]
        public void GenderPropertyOK()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //create a test data to assign to the property
            string TestData = "M";
            //assign data to the property
            AClient.Gender = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AClient.Gender, TestData);
        }

        [TestMethod]
        public void HomeAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //create a test data to assign to the property
            string TestData = "6 Cavendish Mews";
            //assign data to the property
            AClient.HomeAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AClient.HomeAddress, TestData);
        }

        [TestMethod]
        public void PhoneNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //create a test data to assign to the property
            string TestData = "0123456789";
            //assign data to the property
            AClient.CareRequirement = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AClient.CareRequirement, TestData);
        }

        [TestMethod]
        public void CareRequirementOK()
        {
            //create an instance of the class we want to create
            clsClient AClient = new clsClient();
            //create a test data to assign to the property
            string TestData = "Mobility Impairment";
            //assign data to the property
            AClient.CareRequirement = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AClient.CareRequirement, TestData);
        }


        //END OF CLIENT PROPERTIES TEST METHODS
    }
}
