using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core.Common.Tests.TestClasses;

namespace Core.Common.Tests
{
    [TestClass]
    public class ObjectBaseTests
    {
        [TestMethod]
        public void Test_Clean_Property_Change()
        {
            TestClass objTest = new TestClass();
            bool propertyChanged = false;

            objTest.PropertyChanged += (s, e) =>
            {
                if (e.PropertyName == "CleanProp")
                    propertyChanged = true;
            };

            objTest.CleanProp = "test value";

            Assert.IsTrue(propertyChanged, "Changing CleanProp should have set the notification flag to true.");
        }
    }
}
