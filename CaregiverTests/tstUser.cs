using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace CaregiverTests
{
    [TestClass]
    public class tstUser
    {
        [TestMethod]
        public void UserIDK()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            
            //create a test data to assign to the property
            int TestData = 1;
            //assign data to the property
            AUser.UserID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.UserID, TestData);
        }

        [TestMethod]
        public void DOBPropertyOK()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create a test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign data to the property
            AUser.DOB = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.DOB, TestData);
        }

        [TestMethod]
        public void EmailAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create a test data to assign to the property
            string TestData = "abc1@yahoo.com";
            //assign data to the property
            AUser.EmailAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.EmailAddress, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create a test data to assign to the property
            string TestData = "John";
            //assign data to the property
            AUser.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.FirstName, TestData);
        }

        [TestMethod]
        public void LastNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create a test data to assign to the property
            string TestData = "Doe";
            //assign data to the property
            AUser.LastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.LastName, TestData);
        }


        [TestMethod]
        public void GenderPropertyOK()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create a test data to assign to the property
            string TestData = "M";
            //assign data to the property
            AUser.Gender = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.Gender, TestData);
        }

        [TestMethod]
        public void HomeAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create a test data to assign to the property
            string TestData = "6 Cavendish Mews";
            //assign data to the property
            AUser.HomeAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.HomeAddress, TestData);
        }

        [TestMethod]
        public void PhoneNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create a test data to assign to the property
            string TestData = "0123456789";
            //assign data to the property
            AUser.PhoneNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.PhoneNo, TestData);
        }

        //END OF USER PROPERTIES TEST METHODS



        

        //FIRSTNAME

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";

            string firstName = "";

            //invoke the method
            Error = AUser.FirstNameValid(firstName);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMin()
        {
            clsUser AUser = new clsUser();
            String Error = "";

            string firstName = "A";

            //invoke the method
            Error = AUser.FirstNameValid(firstName);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";

            string firstName = "AA";

            //invoke the method
            Error = AUser.FirstNameValid(firstName);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMax()
        {
            clsUser AUser = new clsUser();
            String Error = "";

            //testdata with 50 chars
            string firstName = "";

            firstName = firstName.PadRight(50, 'A');

            //invoke the method
            Error = AUser.FirstNameValid(firstName);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";

            //testdata with 50 chars
            string firstName = "";

            firstName = firstName.PadRight(49, 'A');

            //invoke the method
            Error = AUser.FirstNameValid(firstName);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";


            string firstName = "";

            firstName = firstName.PadRight(51, 'A');

            //invoke the method
            Error = AUser.FirstNameValid(firstName);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMid()
        {
            clsUser AUser = new clsUser();
            String Error = "";


            string firstName = "";

            firstName = firstName.PadRight(25, 'A');

            //invoke the method
            Error = AUser.FirstNameValid(firstName);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            clsUser AUser = new clsUser();
            String Error = "";

            string firstName = "";

            firstName = firstName.PadRight(100, 'A');

            //invoke the method
            Error = AUser.FirstNameValid(firstName);
            Assert.AreNotEqual(Error, "");
        }

        //LASTNAME

        [TestMethod]
        public void LastNameMinLessOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";

            string lastName = "";

            //invoke the method
            Error = AUser.FirstNameValid(lastName);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMin()
        {
            clsUser AUser = new clsUser();
            String Error = "";

            string lastName = "";

            lastName = lastName.PadRight(1, 'A');

            //invoke the method
            Error = AUser.LastNameValid(lastName);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";

            string lastName = "";

            lastName = lastName.PadRight(2, 'A');

            //invoke the method
            Error = AUser.LastNameValid(lastName);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMid()
        {
            clsUser AUser = new clsUser();
            String Error = "";

            string lastName = "";

            lastName = lastName.PadRight(25, 'A');

            //invoke the method
            Error = AUser.LastNameValid(lastName);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void LastNameMax()
        {
            clsUser AUser = new clsUser();
            String Error = "";

            string lastName = "";

            lastName = lastName.PadRight(50, 'A');

            //invoke the method
            Error = AUser.LastNameValid(lastName);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxLessOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";

            string lastName = "";

            lastName = lastName.PadRight(49, 'A');

            //invoke the method
            Error = AUser.LastNameValid(lastName);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";

            string lastName = "";

            lastName = lastName.PadRight(51, 'A');

            //invoke the method
            Error = AUser.LastNameValid(lastName);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameExtremeMax()
        {
            clsUser AUser = new clsUser();
            String Error = "";

            string lastName = "";

            lastName = lastName.PadRight(100, 'A');

            //invoke the method
            Error = AUser.LastNameValid(lastName);
            Assert.AreNotEqual(Error, "");
        }

        //GENDER

        [TestMethod]
        public void GenderMin()
        {
            clsUser AUser = new clsUser();
            String Error = "";

            string gender = "";

            gender = gender.PadRight(1, 'A');

            //invoke the method
            Error = AUser.GenderValid(gender);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenderMinLessOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";

            string gender = "";

            gender = gender.PadRight(0, 'A');

            //invoke the method
            Error = AUser.GenderValid(gender);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GenderMinPlusOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";

            string gender = "";

            gender = gender.PadRight(2, 'A');

            //invoke the method
            Error = AUser.GenderValid(gender);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenderMax()
        {
            clsUser AUser = new clsUser();
            String Error = "";

            string gender = "";

            gender = gender.PadRight(25, 'A');

            //invoke the method
            Error = AUser.GenderValid(gender);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenderMaxLessOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";

            string gender = "";

            gender = gender.PadRight(24, 'A');

            //invoke the method
            Error = AUser.GenderValid(gender);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenderMaxPlusOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";

            string gender = "";

            gender = gender.PadRight(26, 'A');

            //invoke the method
            Error = AUser.GenderValid(gender);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GenderExtremeMax()
        {
            clsUser AUser = new clsUser();
            String Error = "";

            string gender = "";

            gender = gender.PadRight(50, 'A');

            //invoke the method
            Error = AUser.GenderValid(gender);
            Assert.AreNotEqual(Error, "");
        }

        //EMAILADDRESS

        [TestMethod]
        public void EmailAddressMin()
        {
            clsUser AUser = new clsUser();
            String Error = "";

            string emailAddress = "";

            emailAddress = emailAddress.PadRight(9, 'A');

            //invoke the method
            Error = AUser.EmailAddressValid(emailAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMinLessOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";

            string emailAddress = "";

            emailAddress = emailAddress.PadRight(8, 'A');

            //invoke the method
            Error = AUser.EmailAddressValid(emailAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMinPlusOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";

            string emailAddress = "";

            emailAddress = emailAddress.PadRight(10, 'A');

            //invoke the method
            Error = AUser.EmailAddressValid(emailAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMid()
        {
            clsUser AUser = new clsUser();
            String Error = "";

            string emailAddress = "";

            emailAddress = emailAddress.PadRight(25, 'A');

            //invoke the method
            Error = AUser.EmailAddressValid(emailAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMax()
        {
            clsUser AUser = new clsUser();
            String Error = "";

            string emailAddress = "";

            emailAddress = emailAddress.PadRight(50, 'A');

            //invoke the method
            Error = AUser.EmailAddressValid(emailAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMaxPlusOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";

            string emailAddress = "";

            emailAddress = emailAddress.PadRight(51, 'A');

            //invoke the method
            Error = AUser.EmailAddressValid(emailAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressExtremeMax()
        {
            clsUser AUser = new clsUser();
            String Error = "";

            string emailAddress = "";

            emailAddress = emailAddress.PadRight(100, 'A');

            //invoke the method
            Error = AUser.EmailAddressValid(emailAddress);
            Assert.AreNotEqual(Error, "");
        }

        //PHONE NO

        [TestMethod]
        public void PhoneNoMin()
        {
            clsUser AUser = new clsUser();
            String Error = "";

            string phoneNo = "";

            phoneNo = phoneNo.PadRight(11, 'A');

            //invoke the method
            Error = AUser.PhoneNoValid(phoneNo);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMinLessOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";

            string phoneNo = "";

            phoneNo = phoneNo.PadRight(10, 'A');

            //invoke the method
            Error = AUser.PhoneNoValid(phoneNo);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMinPlusOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";

            string phoneNo = "";

            phoneNo = phoneNo.PadRight(12, 'A');

            //invoke the method
            Error = AUser.PhoneNoValid(phoneNo);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMax()
        {
            clsUser AUser = new clsUser();
            String Error = "";

            string phoneNo = "";

            phoneNo = phoneNo.PadRight(11, 'A');

            //invoke the method
            Error = AUser.PhoneNoValid(phoneNo);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoExtremeMax()
        {
            clsUser AUser = new clsUser();
            String Error = "";

            string phoneNo = "";

            phoneNo = phoneNo.PadRight(50, 'A');

            //invoke the method
            Error = AUser.PhoneNoValid(phoneNo);
            Assert.AreNotEqual(Error, "");
        }

        //HOMEADDRESS

        [TestMethod]
        public void HomeAddressMin()
        {
            clsUser AUser = new clsUser();
            String Error = "";

            string homeAddress = "";

            homeAddress = homeAddress.PadRight(10, 'A');

            //invoke the method
            Error = AUser.HomeAddressValid(homeAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HomeAddressMinLessOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";

            string homeAddress = "";

            homeAddress = homeAddress.PadRight(9, 'A');

            //invoke the method
            Error = AUser.HomeAddressValid(homeAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HomeAddressMinPlusOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";

            string homeAddress = "";

            homeAddress = homeAddress.PadRight(11, 'A');

            //invoke the method
            Error = AUser.HomeAddressValid(homeAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HomeAddressMid()
        {
            clsUser AUser = new clsUser();
            String Error = "";

            string homeAddress = "";

            homeAddress = homeAddress.PadRight(25, 'A');

            //invoke the method
            Error = AUser.HomeAddressValid(homeAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HomeAddressMax()
        {
            clsUser AUser = new clsUser();
            String Error = "";

            string homeAddress = "";

            homeAddress = homeAddress.PadRight(50, 'A');

            //invoke the method
            Error = AUser.HomeAddressValid(homeAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HomeAddressMaxPlusOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";

            string homeAddress = "";

            homeAddress = homeAddress.PadRight(51, 'A');

            //invoke the method
            Error = AUser.HomeAddressValid(homeAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HomeAddressMaxLessOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";

            string homeAddress = "";

            homeAddress = homeAddress.PadRight(49, 'A');

            //invoke the method
            Error = AUser.HomeAddressValid(homeAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HomeAddressExtremeMax()
        {
            clsUser AUser = new clsUser();
            String Error = "";

            string homeAddress = "";

            homeAddress = homeAddress.PadRight(100, 'A');

            //invoke the method
            Error = AUser.HomeAddressValid(homeAddress);
            Assert.AreNotEqual(Error, "");
        }

        //DOB (Unfinished)

        [TestMethod]
        public void DOBMin()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            DateTime dOB;
            dOB = DateTime.Now.Date.AddYears(-18);

            dOB = dOB.AddYears(-18);

            //convert the date var to a string var
            string DOB = dOB.ToString();
            

            //invoke the method
            Error = AUser.DOBValid(dOB);
            Assert.AreEqual(Error, "");
        }





   
    }
}
