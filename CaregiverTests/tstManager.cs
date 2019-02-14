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
        public void AddUserOK()
        {
            User AllUsers = new User();
            //create a test item
            User TestItem = new User();
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.UserID = 1;
            TestItem.FirstName = "John";
            TestItem.LastName = "Doe";
            TestItem.Gender = "Male";
            TestItem.EmailAddress = "johndoe@yahoo.com";
            TestItem.HomeAddress = "1 Millstone Lane";
            TestItem.DOB = DateTime.Now.AddYears(-29);
            TestItem.PhoneNo = "07397924314";
            //set ThisUser to the test data
            AllUsers.ThisUser = TestItem;
            //add the record
            PrimaryKey = AllUsers.AddUser();
            //set the primary key of the test data
            TestItem.UserID = PrimaryKey;
            //find the record
            AllUsers.ThisUser.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllUsers.ThisUser, TestItem);



        }

    }

}

