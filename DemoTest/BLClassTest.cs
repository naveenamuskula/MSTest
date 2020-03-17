using System;
using BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoTest
{
    [TestClass]
    public class BLClassTest
    {
        [TestMethod]
        public void DivideTest1()
        {
            //Arrange-Declare actuals and expected
            int Numerator = 10;
            int Denominator = 2;
            int expected = 5;
            int actual = 0;

            //Act-call the method and pass the actuals as parameters
            BLClass1 B = new BLClass1();
            actual = B.Divide(Numerator.ToString(), Denominator.ToString());

            //Assert-Check whether Actuals are matching with expected
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void DivideTest2()
        {
            //Arrange-Declare actuals and expected
            int Numerator = 0;
            int Denominator = 2;
            int expected = 0;
            

            //Act-call the method and pass the actuals as parameters
            BLClass1 B = new BLClass1();
            int actual = B.Divide(Numerator.ToString(), Denominator.ToString());

            //Assert-Check whether Actuals are matching with expected
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DivideTest3()
        {
            int Numerator = 10;
            int Denominator = 0;
            BLClass1 B = new BLClass1();
            var ex = Assert.ThrowsException<DivideByZeroException>(()=>B.Divide(Numerator.ToString(),Denominator.ToString()));
            Assert.AreEqual("Cannot divide by zero",ex.Message);
        }
        [TestMethod]
        public void DivideTest4()
        {
            
            BLClass1 B = new BLClass1();
            var ex = Assert.ThrowsException<FormatException>(() => B.Divide("abc","xyz"));
            Assert.AreEqual("only numbers", ex.Message);
        }
    }
}
