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
        public void UserIDK()
        {
            //create an instance of the class we want to create
            clsManager AManager = new clsManager();
            //create a test data to assign to the property
            int TestData = 1;
            //assign data to the property
            AManager.UserID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AManager.UserID, TestData);
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

        [TestMethod]
        public void FindMethodOK()
        {
            clsManager AManager = new clsManager();
            Boolean Found = false;
            int UserID = 1;
            Found = AManager.Find(UserID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserFirstNameFound()
        {
            clsManager AManager = new clsManager();
            Boolean Found = false;
            Boolean OK = true;
            int UserID = 1;
            Found = AManager.Find(UserID);

            if (AManager.FirstName != "Igho")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        public void TestUserLastNameFound()
        {
            clsManager AManager = new clsManager();
            Boolean Found = false;
            Boolean OK = true;
            int UserID = 1;
            Found = AManager.Find(UserID);

            if (AManager.FirstName != "Akponah")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        public void TestUserGenderFound()
        {
            clsManager AManager = new clsManager();
            Boolean Found = false;
            Boolean OK = true;
            int UserID = 1;
            Found = AManager.Find(UserID);

            if (AManager.FirstName != "Male")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestUserPhoneNoFound()
        {
            clsManager AManager = new clsManager();
            Boolean Found = false;
            Boolean OK = true;
            int CustomerID = 1;
            Found = AManager.Find(CustomerID);

            if (AManager.PhoneNo != "07397924314")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestUserHomeAddressFound()
        {
            clsManager AManager = new clsManager();
            Boolean Found = false;
            Boolean OK = true;
            int CustomerID = 1;
            Found = AManager.Find(CustomerID);

            if (AManager.HomeAddress != "6 Cavendish Mews")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestUserEmailAddressFound()
        {
            clsManager AManager = new clsManager();
            Boolean Found = false;
            Boolean OK = true;
            int CustomerID = 1;
            Found = AManager.Find(CustomerID);

            if (AManager.EmailAddress != "ighoakponah@123.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestUserDOBFound()
        {
            clsManager AManager = new clsManager();
            Boolean Found = false;
            Boolean OK = true;
            int CustomerID = 1;
            Found = AManager.Find(CustomerID);

            if (AManager.DOB != Convert.ToDateTime("11/06/1989"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsManager AManager = new clsManager();
            string Error = "";
            string firstName = "Igho";
            string lastName = "Akponah";
            string homeAddress = "6 Cavendish Mews";
            string gender = "Male";
            string emailAddress = "ighoakponah@123.com";
            string phoneNo = "07397924314";
            string DOB = "11/06/1989";
            string careRequirement = "";

            //invoke method
            Error = AManager.Valid(firstName, lastName, gender, emailAddress, homeAddress, DOB, phoneNo, careRequirement);

            //test to see that the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            User AUser = new User();
            String Error = "";

            string firstName = "";

            //invoke the method
            Error = AUser.FirstNameValid(firstName);
            Assert.AreNotEqual(Error, "");
        }

    }

}

