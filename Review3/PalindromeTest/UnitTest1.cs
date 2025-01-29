using Review3;

namespace PalindromeTest
{
    public class Tests
    {

        private Pallindrome palindrome;

        [SetUp]
        public void Setup()
        {palindrome = new Pallindrome(); }
        

        [Test]
        public void PalindromeTest()
        {
            string str = "aba";
            bool expected = true;
            bool actual = palindrome.ispalindrome(str);
            Assert.AreEqual(expected, actual);
        }
    }
}