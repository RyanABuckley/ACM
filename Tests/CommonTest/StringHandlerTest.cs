using System;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void StringerHandlerTest()
        {
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";

            var actual = source.InsertSpaces();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IinsertSpacesWithExistngSpacesTest()
        {
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";

            var actual = source.InsertSpaces();

            Assert.AreEqual(expected, actual);
        }
    }
}
