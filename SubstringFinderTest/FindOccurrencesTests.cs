using Microsoft.VisualStudio.TestTools.UnitTesting;  // MSTest framework
using FindOccurrences;  
using System.Collections.Generic;

namespace SubstringFinderTest
{
    [TestClass]   // Marks this class as a Test class
    public class FindOccurrencesTests
    {
        [TestMethod]   // Each method with this attribute is treated as a test
        public void FindSubstringOccurrences_ShouldReturnCorrectPositions_WhenPatternExists()
        {
            
            var finder = new FindOccurrence();
            string text = "ababcabc";
            string pattern = "abc";

        
            List<int> result = finder.FindSubstringOccurrences(text, pattern);

         
            CollectionAssert.AreEqual(new List<int> { 2, 5 }, result);
        }

        [TestMethod]
        public void FindSubstringOccurrences_ShouldReturnEmpty_WhenPatternNotFound()
        {
            
            var finder = new FindOccurrence();
            string text = "abcdef";
            string pattern = "gh";

            List<int> result = finder.FindSubstringOccurrences(text, pattern);

            
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void FindSubstringOccurrences_ShouldReturnEmpty_WhenTextIsEmpty()
        {
            // Arrange
            var finder = new FindOccurrence();
            string text = "";
            string pattern = "abc";

            // Act
            List<int> result = finder.FindSubstringOccurrences(text, pattern);

            // Assert
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void FindSubstringOccurrences_ShouldReturnEmpty_WhenPatternIsEmpty()
        {
            // Arrange
            var finder = new FindOccurrence();
            string text = "abcdef";
            string pattern = "";

            // Act
            List<int> result = finder.FindSubstringOccurrences(text, pattern);

            // Assert
            Assert.AreEqual(0, result.Count);
        }
    }
}
