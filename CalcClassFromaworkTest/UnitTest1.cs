using CalcClassBr;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalcClassFromaworkTest
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }
        [DataSource("System.Data.SqlClient", @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\steam\Data.mdf;Integrated Security=True;Connect Timeout=30", "Data", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestModBD()
        {
            long a = (long)TestContext.DataRow["a"];
            long b = (long)TestContext.DataRow["b"];
            long expected = (long)TestContext.DataRow["r"];
            long actual;
            actual = CalcClass.Mod(a, b);
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestMod()
        {
            //AAA
            //Arange
            long a = 4; long b = 2;
            long expected = 0;

            //actual

            long actual = CalcClass.Mod(a, b);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestExc09()
        {
            //AAA
            //Arange
            long a = 4; long b = 0;
            //Actual
            CalcClass.Mod(a, b);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Mod_InputOutOfRange_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            long a = long.MaxValue;
            long b = 2;

            // Actual
            CalcClass.Mod(a, b);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Mod_ResultOutOfRange_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            long a = long.MaxValue;
            long b = long.MaxValue;

            // Actual
            CalcClass.Mod(a, b);
        }


    }

}
