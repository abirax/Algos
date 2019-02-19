
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPalindromeSubString
{
    
    [TestFixture]    
    public class PalindromeTest
    {
        StringChecker prg;
        Mock<StringChecker> myMock;
        [SetUp]
        public void SetUp()
        {
            prg= new StringChecker();
            myMock = new Mock<StringChecker>();
        }
        [Test]
        public void TestPalindDrome()
        {
            string str = prg.LongestPalindrome("sdaaddedfgg");
            Assert.AreEqual("daad", str );
        }
        [Test]
        public void TestMockPalindDrome()
        {
            myMock.Setup(x=>x.LongestPalindrome("sdaaddedfgg")).Returns("xyz");
            string str = prg.LongestPalindrome("sdaaddedfgg");
            str = myMock.Object.LongestPalindrome("sdaaddedfgg");
            Assert.AreEqual("daad", str);
        }
    }
}
