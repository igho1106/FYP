using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CaregiverTests
{
    [TestClass]
    public class tstValidation
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsValidation Valid = new clsValidation();

            //Check to ensure that the class exists
            Assert.IsNotNull(Valid);
        }
    }
}
