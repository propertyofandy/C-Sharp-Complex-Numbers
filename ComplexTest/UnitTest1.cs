using Complex_Numbers;

namespace ComplexTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestToString()
        {
            /* 
             * test to ensure that the ToString() formats correctly
             */

            Complex c = new Complex(); 
            Complex c2 = new Complex(0,2); 
            Complex c3 = new Complex(2,0);
            Complex c4 = new Complex(1,2);
            Complex c5 = new Complex(1,-2);

            Assert.AreEqual(c.ToString(),"0");
            Assert.AreEqual(c2.ToString(), "2i");
            Assert.AreEqual(c3.ToString(), "2");
            Assert.AreEqual(c4.ToString(), "1 + 2i");
            Assert.AreEqual(c5.ToString(), "1 - 2i");

        }

        [TestMethod]
        public void TestOverLoadOperator()
        {
            /* 
             * testing +, -, *, / operators
             */

            Complex c = new Complex(7,12);
            Complex c2 = new Complex(14, 3);

            Complex c3 = c + c2;

            Assert.AreEqual(c3.ToString(), "21 + 15i");

            c3 = c - c2;

            Assert.AreEqual(c3.ToString(), "-7 + 9i");

            c3 = c / c2;

            Assert.AreEqual(c3.ToString(), "4.5");

            c3 = c * c2;

            Assert.AreEqual(c3.ToString(), "62 + 189i");

            c3 = c ^ 2;

            Assert.AreEqual(c3.ToString(), "-95");

            c3 = c ^ 1;

            Assert.AreEqual(c3.ToString(), c.ToString());

        }
    }
}