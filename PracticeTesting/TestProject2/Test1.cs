using PracticeTesting;

namespace TestProject2
{
    [TestClass]
    public sealed class Test1
    {
        private BasicPrograms programs;
        [TestInitialize]
        public void SetUp() { 
        programs = new BasicPrograms(); 
        }
        [TestMethod]
        [DataRow(2,3,5)]
        public void additionTest(int a, int b, int expected)

        {     
            int actual = programs.add(a, b);
            Assert.AreEqual(expected, actual);

        }

        
       
    }
}
