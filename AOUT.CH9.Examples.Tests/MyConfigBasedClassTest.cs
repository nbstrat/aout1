﻿// The following code was generated by Microsoft Visual Studio 2005.
// The test owner should check each test for validity.

using NUnit.Framework;

namespace AOUT.CH9.Examples.Tests
{
    [TestFixture()]
    public class MyConfigBasedClassTest
    {

        [Test]
        public void IsConnectionValid_BadConnectionString_ReturnsFalse()
        {
            TestableConfigClass myclass = new TestableConfigClass();
            myclass.theConnectionStringToReturn = "blah";//does not contain 'catalog'

            bool stringValid = myclass.IsConnectionStringValid();
            Assert.IsFalse(stringValid);
        }
    }

    class TestableConfigClass:MyConfigBasedClass
    {
        public string theConnectionStringToReturn;
        public string requestedConStringKey;

        protected override string getConnectionString(string constring)
        {
            requestedConStringKey = constring;

            return theConnectionStringToReturn;
        }
    }
}