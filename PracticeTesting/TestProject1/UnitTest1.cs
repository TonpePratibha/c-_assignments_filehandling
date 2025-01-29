using System.ComponentModel;
using PracticeTesting;

namespace TestProject1
{
    public class Tests
    {
        private BasicPrograms p;
        [SetUp]
        public void Setup()
        {
            p=new BasicPrograms();
        }

        [Test]
        public void AdditionTest()
        { //arrange
            int a=3,b=4;
            int expected = 7;

            //act
            var actual=p.add(a,b);
            Assert.AreEqual(expected, actual);
            
        }
        [Test]
        public void EvenTest() {
            int num = 5;
            bool excepted = false;
           var actua=p.isEven(num);
            Assert.AreEqual(excepted, actua);

        }
    }
}