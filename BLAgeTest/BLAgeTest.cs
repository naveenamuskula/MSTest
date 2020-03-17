using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLayer;

namespace BLAgeTest
{
    [TestClass]
    public class BLAgeTest
    {
        [TestMethod]
        public void Greator()
        {
            DateTime dob = DateTime.Parse("05-07-1950");
            BLAge B = new BLAge();
            var ex = Assert.ThrowsException<CustomException>(() => B.age(dob));
            Assert.AreEqual("age should  not be  grator than 60", ex.Message);
        }
        [TestMethod]
        public void Less()
        {
            DateTime dob = DateTime.Parse("05-07-2010");
            BLAge B = new BLAge();
            var ex = Assert.ThrowsException<CustomException>(() => B.age(dob));
            Assert.AreEqual("age should be greator than 18", ex.Message);
        }
        [TestMethod]
        public void Inbtwn()
        {
            BLAge B = new BLAge();
            DateTime db = DateTime.Parse("10-05-1997");
            int ex = 22;
            int actual = B.age(db);
            Assert.AreEqual(ex, actual);

        }
    }
}
