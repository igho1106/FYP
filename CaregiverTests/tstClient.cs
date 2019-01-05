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
        }
    }
}
