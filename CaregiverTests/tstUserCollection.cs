using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CaregiverTests
{
    [TestClass]
    public class tstUserCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsUserCollection AllUsers = new clsUserCollection();
            //test to see that it exists
            Assert.IsNotNull(AllUsers);
        }


        [TestMethod]
        public void UserListOK()
        {
            //create an instance of the class we want to create
            clsUserCollection AllCustomers = new clsUserCollection();
            //create some test data to assin to the property
            //in this case the data needs to be a list of objects
            List<clsUser> TestList = new List<clsUser>();
            //add an item to the list
            //create the item of the test data
            clsUser TestItem = new clsUser();
            //set its properties 
            TestItem.UserID = 2;
            TestItem.FirstName = "John";
            TestItem.LastName = "Doe";
            TestItem.Gender = "Male";
            TestItem.EmailAddress = "abc@123.com";
            TestItem.HomeAddress = "8 Millstone Lane";
            TestItem.DOB = DateTime.Now.Date;
            TestItem.PhoneNo = "01234567891";

            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.UserList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.UserList, TestList);
        }

        [TestMethod]
        public void ThisUserPropertyOK()
        {
            //create an instance of the class we want to create
            clsUserCollection AllCustomers = new clsUserCollection();
            //create some test data to assin to the property
            clsUser TestUser = new clsUser();
            //set its properties 
            TestUser.UserID = 2;
            TestUser.FirstName = "John";
            TestUser.LastName = "Doe";
            TestUser.Gender = "Male";
            TestUser.EmailAddress = "abc@123.com";
            TestUser.HomeAddress = "8 Millstone Lane";
            TestUser.DOB = DateTime.Now.Date;
            TestUser.PhoneNo = "01234567891";

            //assign the data to the property
            AllCustomers.ThisUser = TestUser;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisUser, TestUser);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsUserCollection AllUsers = new clsUserCollection();
            //create some test data to assin to the property
            //in this case the data needs to be a list of objects
            List<clsUser> TestList = new List<clsUser>();
            //add an item to the list
            //create the item of the test data
            clsUser TestItem = new clsUser();
            //set its properties 
            TestItem.UserID = 2;
            TestItem.FirstName = "John";
            TestItem.LastName = "Doe";
            TestItem.Gender = "Male";
            TestItem.EmailAddress = "abc@123.com";
            TestItem.HomeAddress = "8 Millstone Lane";
            TestItem.DOB = DateTime.Now.Date;
            TestItem.PhoneNo = "01234567891";

            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllUsers.UserList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllUsers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddUserMethodOK()
        {
            //create an instance of the class we want to create
            clsUserCollection AllUsers = new clsUserCollection();
            //create a the item of the test data
            clsUser TestItem = new clsUser();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.UserID = 2;
            TestItem.FirstName = "John";
            TestItem.LastName = "Doe";
            TestItem.Gender = "Male";
            TestItem.EmailAddress = "abc@123.com";
            TestItem.HomeAddress = "8 Millstone Lane";
            TestItem.DOB = DateTime.Now.Date;
            TestItem.PhoneNo = "01234567891";

            string careRequirement = "";
            careRequirement = careRequirement.PadRight(150, 'A');

            TestItem.CareRequirement = careRequirement;
            TestItem.Role = 2;


            

            //set ThisCustomer to the test data
            AllUsers.ThisUser = TestItem;
            //add the record
            PrimaryKey = AllUsers.AddUserMethod();
            //set the primary key of the test data
            TestItem.UserID = PrimaryKey;
            //find the record
            AllUsers.ThisUser.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllUsers.ThisUser, TestItem);

        }

        //DELETE TEST METHOD

        //UPDATE TEST METHOD

        [TestMethod]
        public void FilterByEmailAddressMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsUserCollection AllUsers = new clsUserCollection();
            //create an instance of the filtered data
            clsUserCollection FilteredCustomers = new clsUserCollection();
            //apply a blank string (should return all records);
            FilteredCustomers.FilterByEmailAddress("");
            //test to see that the two values are the same
            Assert.AreEqual(AllUsers.Count, FilteredCustomers.Count);
        }
    }
}
