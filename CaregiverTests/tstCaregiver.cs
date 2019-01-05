using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CaregiverTests
{
    [TestClass]
    public class tstCaregiver
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCaregiver ACaregiver = new clsCaregiver();
        }
    }
}
