using GreatestProductFinder;

namespace ProductCalculatorTests
{
    [TestClass]
    public class GreatestProductFinderTests
    {
        private ProductCalculator _productCalculator;

        [TestInitialize]
        public void Setup()
        {
            _productCalculator = new ProductCalculator();
        }

        [TestMethod]
        public void FindGreatestProduct_ValidInput_ReturnsCorrectResult()
        {
            string input = "123456789";
            var (product,digits)= _productCalculator.FindGreatestProduct(input);

            Assert.AreEqual(3024, product); //6*7*8*9
            Assert.AreEqual("6789", digits);
        }
        [TestMethod]
        public void FindGreatestProduct_InputTooShort_ReturnsZero()
        {
            string input = "123";
            var (product,digits)=_productCalculator.FindGreatestProduct(input);
            Assert.AreEqual(0,product);
            Assert.AreEqual(string.Empty, digits);
        }

        [TestMethod]
        public void FindGretestProduct_InputWithNonDigits_SkipInvalidChars() 
        {
            string input = "12abcd8793";
            var (product,digits)=_productCalculator.FindGreatestProduct(input);
            Assert.AreEqual(1512, product);
            Assert.AreEqual("8793", digits);
        }
        [TestMethod]
        public void FindGreatestProduct_InputTooShort_HandlesCorrectly()
        {
            var (product, digits) = _productCalculator.FindGreatestProduct("");
            Assert.AreEqual(0,product);
            Assert.AreEqual(string.Empty,digits);
        }
        
    }
}
