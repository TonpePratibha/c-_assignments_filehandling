using Review3;

namespace CalculatorTest
{
    public class Tests
    {

        private Calculator cal;
        [SetUp]
        public void Setup()
        {
            cal= new Calculator();
        }

        [Test]
        public void AdditionTest()
        {
            int a = 2;
            int b = 3;
            int expected = 5;

            int actual = cal.add(a, b);
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void SubtractionTest()
        {
            int a = 5;
            int b = 3;
            int expected1 = 2;
            int sub = cal.subtract(a, b);
            Assert.AreEqual(expected1, sub);
        }

        [Test]
        public void MultiplicationTest() { 
        int a = 5;
            int b = 3;
            int expected2 = 15;

            int mul= cal.multiply(a, b);

            Assert.AreEqual(expected2, mul);
        }
        [Test]
        public void DivisionTest()
        {
            int a = 5;
            int b = 3;
            int expected3 = 1;

            int division = cal.division(a, b);
            Assert.AreEqual(expected3, division);
        }
    }
}