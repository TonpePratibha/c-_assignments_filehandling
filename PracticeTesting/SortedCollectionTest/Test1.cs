using PracticeTesting;

namespace SortedCollectionTest
{
    [TestClass]
    public sealed class Test1
    {

        private SortedCollection collection;

        [TestInitialize]
        public void SetUp() { 
        collection = new SortedCollection();
        }

        [TestMethod]
        public void SortedCollectionTest()
        {
            var SortedCollection=new SortedCollection();
            var testlist = new List<int> { 6, 3, 7, 1, 2, 8 };
            SortedCollection.BubbleSort(testlist);
            var expectedlist = new List<int> { 1, 2, 3, 6, 7, 8 };
            CollectionAssert.AreEqual(testlist, expectedlist);

        }
    }
}
