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

        
        
        //END OF CAREGIVER PROPERTIES TEST METHODS
    }
}
