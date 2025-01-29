
using TestingPractice;
namespace TsetPrograms
{
    public class Tests
    {
        private TesingPractice.Practice p;

        [SetUp]
        public void Setup()
        {
            p = new TesingPractice.Practice();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}