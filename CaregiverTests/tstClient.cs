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
