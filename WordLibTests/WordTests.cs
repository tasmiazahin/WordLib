using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordLib;

namespace WordLibTests
{
    [TestClass]
    public class WordTests
    {
        [TestMethod]
        public void IsWord_Palindrome()
        {
            // Create instance to test
            Word word = new Word();

            // Run the method
            bool IsPalindrome = word.IsPalindrome("radar");

            // Verify the result
            Assert.AreEqual(true, IsPalindrome);
        }
    }
}
