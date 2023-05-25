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

        [TestMethod]
        public void IsWord_Palindrome_ThrowsNullReferenceException()
        {
            // Create instance to test
            Word word = new Word();

            //Run the method and expect an exception
            Assert.ThrowsException<NullReferenceException>(() => word.IsPalindrome(""));
        }

        [TestMethod]
        public void Word_Counter_Return_input_length()
        {
            // Create instance to test
            Word word = new Word();

            // Run the method
            int count = word.Counter("radar");

            // Verify the result
            Assert.AreEqual(5, count);
        }

        [TestMethod]
        public void Word_Counter_ThrowsNullReferenceException()
        {
            // Create instance to test
            Word word = new Word();

            //Run the method and expect an exception
            Assert.ThrowsException<NullReferenceException>(() => word.Counter(""));
        }
    }
}
