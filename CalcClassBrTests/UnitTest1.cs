using CalcClassBr;

namespace CalcClassBrTests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMod()
        {
            //AAA
            //Arange
            long a = 4; long b=2;
            long expected = 0;

            //actual

             long actual=   CalcClass.Mod(a, b);

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